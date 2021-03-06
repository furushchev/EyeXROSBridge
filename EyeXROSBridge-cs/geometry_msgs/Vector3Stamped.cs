//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2015-02-02T21:01:49+09:00
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
    public class Vector3Stamped : IMessage
    {
        ///<exclude/>
        public Vector3Stamped()
        {
            header = new Header();
            vector = new Vector3();
        }
        ///<exclude/>
        public Vector3Stamped(BinaryReader br)
        {
            Deserialize(br);
        }
        ///<exclude/>
        public Header header { get; set; }
        ///<exclude/>
        public Vector3 vector { get; set; }
        ///<exclude/>
        public string MessageType
        {
            get { return "geometry_msgs/Vector3Stamped"; }
        }
        ///<exclude/>
        public string Md5Sum
        {
            get { return "7b324c7325e683bf02a9b14b01090ec7"; }
        }
        ///<exclude/>
        public string MessageDefinition
        {
            get { return "Header header\nVector3 vector"; }
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
            vector.Serialize(bw);
        }
        ///<exclude/>
        public void Deserialize(BinaryReader br)
        {
            header = new Header(br);
            vector = new Vector3(br);
        }
        ///<exclude/>
        public int SerializeLength
        {
            get { return header.SerializeLength + vector.SerializeLength; }
        }
        ///<exclude/>
        public bool Equals(Vector3Stamped other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.header.Equals(header) && other.vector.Equals(vector);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Vector3Stamped)) return false;
            return Equals((Vector3Stamped)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ header.GetHashCode();
                result = (result * 397) ^ vector.GetHashCode();
                return result;
            }
        }
    }
}
