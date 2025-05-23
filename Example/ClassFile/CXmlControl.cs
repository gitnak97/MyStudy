using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Example
{

    public class XmlDataManager<T> where T : IXmlSerializableData, new()
    {
        public T Read(string path)
        {
            T data = new T();
            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement("SETTING"))
                    {
                        string id = reader["ID"];
                        reader.Read(); // Move to first content node
                        data.ReadFromXml(reader);
                        break;
                    }
                }
            }
            return data;
        }

        public void Write(string path, T data, string id = "0001")
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = System.Text.Encoding.UTF8
            };

            using (XmlWriter writer = XmlWriter.Create(path, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("SETTING");
                writer.WriteAttributeString("ID", id);

                data.WriteToXml(writer);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}