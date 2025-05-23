using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Example
{
    class ExtendedSettingData : IXmlSerializableData
    {
        public string Tick { get; set; }
        public string Total { get; set; }
        public string Level1 { get; set; }
        public string Level3 { get; set; }
        public string Level50 { get; set; }

        public void ReadFromXml(XmlReader reader)
        {

            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "TICK":
                            Tick = reader.ReadElementContentAsString();
                            break;
                        case "TOTAL":
                            Total = reader.ReadElementContentAsString();
                            break;
                        case "LEVEL_1":
                            Level1 = reader.ReadElementContentAsString();
                            break;
                        case "LEVEL_3":
                            Level3 = reader.ReadElementContentAsString();
                            break;
                        case "LEVEL_50":
                            Level50 = reader.ReadElementContentAsString();
                            break;
                    }
                }
            }
        }

        public void WriteToXml(XmlWriter writer)
        {
            writer.WriteElementString("TICK", Tick);
            writer.WriteElementString("TOTAL", Total);
            writer.WriteElementString("LEVEL_1", Level1);
            writer.WriteElementString("LEVEL_3", Level3);
            writer.WriteElementString("LEVEL_50", Level50);


            
        }
    }
}
