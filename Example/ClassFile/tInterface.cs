using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;

namespace Example
{
    public interface IXmlSerializableData
    {
        void ReadFromXml(XmlReader reader);
        void WriteToXml(XmlWriter writer);
    }

    public interface TimerUtils
    {
        void Start();
        void Stop();
        bool IsRunning { get; }
    }
}
