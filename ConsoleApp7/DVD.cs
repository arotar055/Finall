namespace MediaDevices
{
    public class DVD : StorageDevice
    {
        public double WriteSpeed { get; set; }

        public override void SaveData(string data)
        {

        }

        public override string LoadData()
        {
            return "Data from DVD.";
        }

        public override string GenerateReport()
        {
            return $"DVD: {Manufacturer} {Model}, Write Speed: {WriteSpeed}x";
        }
    }
}
