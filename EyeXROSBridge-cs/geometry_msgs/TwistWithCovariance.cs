//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2015-02-02T21:01:48+09:00
// </auto-generated>
//----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RosSharp.Message;
using RosSharp.Service;
using RosSharp.std_msgs;
namespace RosSharp.geometry_msgs
{
    ///<exclude/>
    public class TwistWithCovariance : IMessage
    {
        ///<exclude/>
        public TwistWithCovariance()
        {
            twist = new Twist();
            covariance = new double[36];
        }
        ///<exclude/>
        public TwistWithCovariance(BinaryReader br)
        {
            Deserialize(br);
        }
        ///<exclude/>
        public Twist twist { get; set; }
        ///<exclude/>
        public double[] covariance { get; set; }
        ///<exclude/>
        public string MessageType
        {
            get { return "geometry_msgs/TwistWithCovariance"; }
        }
        ///<exclude/>
        public string Md5Sum
        {
            get { return "1fe8a28e6890a4cc3ae4c3ca5c7d82e6"; }
        }
        ///<exclude/>
        public string MessageDefinition
        {
            get { return "Twist twist\nfloat64[36] covariance"; }
        }
        ///<exclude/>
        public bool HasHeader
        {
            get { return false; }
        }
        ///<exclude/>
        public void Serialize(BinaryWriter bw)
        {
            twist.Serialize(bw);
            for(int i=0; i<36; i++) { bw.Write(covariance[i]);}
        }
        ///<exclude/>
        public void Deserialize(BinaryReader br)
        {
            twist = new Twist(br);
            for(int i=0; i<36; i++) { covariance[i] = covariance[i] = br.ReadDouble();}
        }
        ///<exclude/>
        public int SerializeLength
        {
            get { return twist.SerializeLength + covariance.Sum(x => 8); }
        }
        ///<exclude/>
        public bool Equals(TwistWithCovariance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.twist.Equals(twist) && other.covariance.SequenceEqual(covariance);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TwistWithCovariance)) return false;
            return Equals((TwistWithCovariance)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ twist.GetHashCode();
                result = (result * 397) ^ covariance.GetHashCode();
                return result;
            }
        }
    }
}
