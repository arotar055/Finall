namespace MediaDevices
{
    public abstract class StorageDevice
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public double Capacity { get; set; }
        public int Quantity { get; set; }

        public abstract void SaveData(string data);
        public abstract string LoadData();
        public abstract string GenerateReport();
    }
}
