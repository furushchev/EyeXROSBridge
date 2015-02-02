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
    public class TwistStamped : IMessage
    {
        ///<exclude/>
        public TwistStamped()
        {
            header = new Header();
            twist = new Twist();
        }
        ///<exclude/>
        public TwistStamped(BinaryReader br)
        {
            Deserialize(br);
        }
        ///<exclude/>
        public Header header { get; set; }
        ///<exclude/>
        public Twist twist { get; set; }
        ///<exclude/>
        public string MessageType
        {
            get { return "geometry_msgs/TwistStamped"; }
        }
        ///<exclude/>
        public string Md5Sum
        {
            get { return "98d34b0043a2093cf9d9345ab6eef12e"; }
        }
        ///<exclude/>
        public string MessageDefinition
        {
            get { return "Header header\nTwist twist"; }
        }
        ///<exclude/>
        public bool HasHeader
        {
            get { return true; }
        }
        ///<exclude/>
        public void Serialize(BinaryWriter bw)
        {
            header.Serialize(bw);
            twist.Serialize(bw);
        }
        ///<exclude/>
        public void Deserialize(BinaryReader br)
        {
            header = new Header(br);
            twist = new Twist(br);
        }
        ///<exclude/>
        public int SerializeLength
        {
            get { return header.SerializeLength + twist.SerializeLength; }
        }
        ///<exclude/>
        public bool Equals(TwistStamped other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.header.Equals(header) && other.twist.Equals(twist);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(TwistStamped)) return false;
            return Equals((TwistStamped)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ header.GetHashCode();
                result = (result * 397) ^ twist.GetHashCode();
                return result;
            }
        }
    }
}