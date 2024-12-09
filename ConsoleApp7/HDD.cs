namespace MediaDevices
{
    public class HDD : StorageDevice
    {
        public int SpindleSpeed { get; set; }

        public override void SaveData(string data)
        {
        }

        public override string LoadData()
        {
            return "Data from HDD.";
        }

        public override string GenerateReport()
        {
            return $"HDD: {Manufacturer} {Model}, Spindle Speed: {SpindleSpeed} RPM";
        }
    }
}
