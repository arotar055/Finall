namespace MediaDevices
{
    public class Flash : StorageDevice
    {
        public double UsbSpeed { get; set; }

        public override void SaveData(string data)
        {
        }

        public override string LoadData()
        {
            return "Data from Flash.";
        }

        public override string GenerateReport()
        {
            return $"Flash: {Manufacturer} {Model}, USB Speed: {UsbSpeed}MB/s";
        }
    }
}
