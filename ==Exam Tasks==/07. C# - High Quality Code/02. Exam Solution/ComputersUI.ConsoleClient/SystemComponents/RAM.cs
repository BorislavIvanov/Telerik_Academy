namespace ComputersUI.ConsoleClient.SystemComponents
{
    public class RAM 
    {
        private int memorisedValue = 0;

        public RAM(int ramCapacity)
        {
            this.RamCapacity = ramCapacity;
        }

        public int RamCapacity { get; private set; }

        public void SaveValue(int newValue)
        { 
            this.memorisedValue = newValue; 
        }

        public int LoadValue() 
        { 
            return this.memorisedValue; 
        } 
    } 
}