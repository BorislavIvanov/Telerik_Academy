namespace ComputersUI.ConsoleClient
{
    public class FactoryManager
    {
        private ComputerFactory manufacturer = null;

        public FactoryManager(ComputerFactory computerManufacturer)
        {
            this.manufacturer = computerManufacturer;
        }

        public PersonalComputer MakePersonalComputer()
        {
            return this.manufacturer.MakePersonalComputer();
        }

        public Laptop MakeLaptop()
        {
            return this.manufacturer.MakeLaptop();
        }

        public Server MakeServer()
        {
            return this.manufacturer.MakeServer();
        }
    }
}
