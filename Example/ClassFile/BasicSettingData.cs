using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Example
{
    class BasicSettingData : IXmlSerializableData
    {
        public string TextData { get; set; }
        public string CBoxData { get; set; }
        public string NumberData { get; set; }

        public void ReadFromXml(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "TEXT_DATA":
                            TextData = reader.ReadElementContentAsString();
                            break;
                        case "CBOX_DATA":
                            CBoxData = reader.ReadElementContentAsString();
                            break;
                        case "NUMBER_DATA":
                            NumberData = reader.ReadElementContentAsString();
                            break;
                    }
                }

            }
            return;            
        }

        public void WriteToXml(XmlWriter writer)
        {
            writer.WriteElementString("TEXT_DATA", TextData);
            writer.WriteElementString("CBOX_DATA", CBoxData);
            writer.WriteElementString("NUMBER_DATA", NumberData);
        }
    }
}
