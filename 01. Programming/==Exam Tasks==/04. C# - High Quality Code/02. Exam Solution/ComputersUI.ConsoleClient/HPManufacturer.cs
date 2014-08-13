namespace ComputersUI.ConsoleClient
{
    using ComputersUI.ConsoleClient.SystemComponents;

    class HPManufacturer : ComputerFactory
    {
        public override PersonalComputer MakePersonalComputer()
        {
            CPU cpu = new CPU(2, 32);
            RAM ram = new RAM(2);
            HardDrive hardDrive = new HardDrive(500, false, 0);
            VideoCard videoCard = new VideoCard(false);

            PersonalComputer hpPersonalComputer = new PersonalComputer(cpu, ram, hardDrive, videoCard);

            return hpPersonalComputer;
        }

        public override Laptop MakeLaptop()
        {
            CPU cpu = new CPU(2, 64);
            RAM ram = new RAM(4);
            HardDrive hardDrive = new HardDrive(500, false, 0);
            VideoCard videoCard = new VideoCard(false);
            Battery battery = new Battery();

            Laptop hpLaptop = new Laptop(cpu, ram, hardDrive, videoCard, battery);

            return hpLaptop;
        }

        public override Server MakeServer()
        {
            CPU cpu = new CPU(4, 32);
            RAM ram = new RAM(32);
            HardDrive hardDrive = new HardDrive(1000, true, 2);
            VideoCard videoCard = new VideoCard(true);

            Server hpServer = new Server(cpu, ram, hardDrive, videoCard);

            return hpServer;
        }
    }
}
