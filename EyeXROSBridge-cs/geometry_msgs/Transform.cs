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
    public class Transform : IMessage
    {
        ///<exclude/>
        public Transform()
        {
            translation = new Vector3();
            rotation = new Quaternion();
        }
        ///<exclude/>
        public Transform(BinaryReader br)
        {
            Deserialize(br);
        }
        ///<exclude/>
        public Vector3 translation { get; set; }
        ///<exclude/>
        public Quaternion rotation { get; set; }
        ///<exclude/>
        public string MessageType
        {
            get { return "geometry_msgs/Transform"; }
        }
        ///<exclude/>
        public string Md5Sum
        {
            get { return "ac9eff44abf714214112b05d54a3cf9b"; }
        }
        ///<exclude/>
        public string MessageDefinition
        {
            get { return "Vector3 translation\nQuaternion rotation"; }
        }
        ///<exclude/>
        public bool HasHeader
        {
            get { return false; }
        }
        ///<exclude/>
        public void Serialize(BinaryWriter bw)
        {
            translation.Serialize(bw);
            rotation.Serialize(bw);
        }
        ///<exclude/>
        public void Deserialize(BinaryReader br)
        {
            translation = new Vector3(br);
            rotation = new Quaternion(br);
        }
        ///<exclude/>
        public int SerializeLength
        {
            get { return translation.SerializeLength + rotation.SerializeLength; }
        }
        ///<exclude/>
        public bool Equals(Transform other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.translation.Equals(translation) && other.rotation.Equals(rotation);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Transform)) return false;
            return Equals((Transform)obj);
        }
        ///<exclude/>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ translation.GetHashCode();
                result = (result * 397) ^ rotation.GetHashCode();
                return result;
            }
        }
    }
}
