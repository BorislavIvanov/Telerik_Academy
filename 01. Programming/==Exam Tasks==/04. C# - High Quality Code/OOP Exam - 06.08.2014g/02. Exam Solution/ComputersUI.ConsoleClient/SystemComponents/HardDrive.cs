namespace ComputersUI.ConsoleClient.SystemComponents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDrive
    {
        private int capacity;
        private bool isInRaid;
        private int hardDrivesInRaid;
        private Dictionary<int, string> data;
        private List<HardDrive> hardDrives;

        public HardDrive()
        {
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.Capacity = capacity;
            this.IsInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.data = new Dictionary<int, string>(capacity);
            this.hardDrives = new List<HardDrive>();
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid, List<HardDrive> hardDrives)
        {
            this.Capacity = capacity;
            this.IsInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.data = new Dictionary<int, string>(capacity);
            this.hardDrives = new List<HardDrive>();
            this.hardDrives = hardDrives;
        }

        public int Capacity
        {
            get
            {
                if (this.IsInRaid)
                {
                    if (!this.hardDrives.Any())
                    {
                        return 0;
                    }

                    return this.hardDrives.First().Capacity;
                }
                else
                {
                    return this.capacity;
                }
            }

            private set
            {
            }
        }

        public bool IsInRaid { get; private set; }

        public void SaveData(int address, string dataForSave)
        {
            if (this.IsInRaid)
            {
                foreach (var hardDrive in this.hardDrives)
                {
                    // BottleNeck - This line of code make unneeded recursion.
                    //// hardDrive.SaveData(address, dataForSave);

                    //// Solution
                    hardDrive.data[address] = dataForSave;
                }
            }
            else
            {
                this.data[address] = dataForSave;
            }
        }

        public string LoadData(int address)
        {
            if (this.IsInRaid)
            {
                try
                {
                    if (!this.hardDrives.Any())
                    {
                        throw new OutOfMemoryException("No hard drive in the RAID array!");
                    }
                }
                catch (OutOfMemoryException)
                {
                    string outputMessage = "No hard drive in the RAID array!";
                    return outputMessage;
                }
                
                return this.hardDrives.First().LoadData(address);
            }
            else if (true)
            {
                return this.data[address];
            }
        }
    }
}
