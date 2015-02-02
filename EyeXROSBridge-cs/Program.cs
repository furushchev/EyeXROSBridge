using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tobii.EyeX.Framework;
using EyeXFramework;

using RosSharp;
using RosSharp.Topic;
using RosSharp.Utility;
using RosSharp.geometry_msgs;

namespace EyeXROSBridge
{
    class Program
    {
        static Publisher<PointStamped> gaze_pub;
        static void Main(string[] args)
        {
            // init ros
            var ROS_HOSTNAME = System.Environment.GetEnvironmentVariable("ROS_HOSTNAME");
            if (ROS_HOSTNAME == "") ROS_HOSTNAME = "localhost";
            var ROS_MASTER_URI = System.Environment.GetEnvironmentVariable("ROS_MASTER_URI");
            if (ROS_MASTER_URI == "") ROS_MASTER_URI = "http://localhost:11311/";

            Console.WriteLine("ROS_HOSTNAME={0}", ROS_HOSTNAME);
            Console.WriteLine("ROS_MASTER_URI={0}", ROS_MASTER_URI);
            
            try
            {
                Ros.HostName = ROS_HOSTNAME;
                Ros.MasterUri = new Uri(ROS_MASTER_URI);
                var rosNode = Ros.InitNodeAsync("eyex_ros_bridge").Result;
                gaze_pub = rosNode.PublisherAsync<PointStamped>("/gaze").Result;

            }
            catch (Exception e)
            {
                Fatal("failed to initialize ros: {0}", e);
            }

            // init eyex
            try
            {
                var eyeXHost = new EyeXHost();
                var lightlyFilteredGazeDataStream = eyeXHost.CreateGazePointDataStream(GazePointDataMode.LightlyFiltered);
                eyeXHost.Start();
                lightlyFilteredGazeDataStream.Next += new EventHandler<GazePointEventArgs>(onGazeReceived);
            }
            catch (Exception e)
            {
                Fatal("failed to initialize EyeX: {0}", e);
            }

            Info("Listening for gaze data, press any key to exit...");
            Console.In.Read();
        }

        static void onGazeReceived(object s, GazePointEventArgs ea)
        {
            PointStamped p = new PointStamped();
            p.header.stamp = DateTime.Now;
            p.point.x = ea.X;
            p.point.y = ea.Y;

            gaze_pub.OnNext(p);
        }

        static void Info(string format, params object[] args)
        {
            Console.WriteLine("Info: " + format, args);
        }

        static void Error(string format, params object[] args)
        {
            Console.WriteLine("Error: " + format, args);
            Console.In.Read();
        }

        static void Fatal(string format, params object[] args)
        {
            Console.WriteLine("Fatal: " + format, args);
            Console.In.Read();
            Environment.Exit(-1);
        }
    }
}
