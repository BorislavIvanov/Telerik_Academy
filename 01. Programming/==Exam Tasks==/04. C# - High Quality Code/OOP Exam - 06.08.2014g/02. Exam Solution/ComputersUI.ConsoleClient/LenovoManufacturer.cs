namespace ComputersUI.ConsoleClient
{
    using ComputersUI.ConsoleClient.SystemComponents;

    public class LenovoManufacturer : ComputerFactory
    {
        public override PersonalComputer MakePersonalComputer()
        {
            CPU cpu = new CPU(2, 64);
            RAM ram = new RAM(4);
            HardDrive hardDrive = new HardDrive(2000, false, 0);
            VideoCard videoCard = new VideoCard(true);

            PersonalComputer lenovoPersonalComputer = new PersonalComputer(cpu, ram, hardDrive, videoCard);

            return lenovoPersonalComputer;
        }

        public override Laptop MakeLaptop()
        {
            CPU cpu = new CPU(2, 64);
            RAM ram = new RAM(16);
            HardDrive hardDrive = new HardDrive(1000, false, 0);
            VideoCard videoCard = new VideoCard(false);
            Battery battery = new Battery();

            Laptop lenovoLaptop = new Laptop(cpu, ram, hardDrive, videoCard, battery);

            return lenovoLaptop;
        }

        public override Server MakeServer()
        {
            CPU cpu = new CPU(2, 128);
            RAM ram = new RAM(8);
            HardDrive hardDrive = new HardDrive(500, true, 2);
            VideoCard videoCard = new VideoCard(true);

            Server lenovoServer = new Server(cpu, ram, hardDrive, videoCard);

            return lenovoServer;
        }
    }
}
