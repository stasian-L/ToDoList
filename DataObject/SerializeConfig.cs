﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DataObjects
{
    public class SerializeConfig<T> where T : class
    {
        public static void Serialize(string path, T type)
        {
            var serializer = new XmlSerializer(type.GetType());
            using (var writer = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(writer, type);
            }
        }

        public static T DeSerialize(string path)
        {
            T type;
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = XmlReader.Create(path))
            {
                type = serializer.Deserialize(reader) as T;
            }
            return type;
        }
    }
}
