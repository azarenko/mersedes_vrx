using System.IO;
using System.Xml.Serialization;
using VrxViewer.Models;

namespace VrxViewer
{
    internal class VrxParser
    {
        private readonly VehicleReport _vehicleReport;

        public VrxParser(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(path);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(VehicleReport));
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                _vehicleReport = (VehicleReport)serializer.Deserialize(fileStream);
            }
        }

        public VehicleReport VehicleReport { get { return _vehicleReport; } }
    }
}
