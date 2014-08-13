namespace ComputersUI.ConsoleClient
{
    using ComputersUI.ConsoleClient.SystemComponents;

    public class DellManufacturer : ComputerFactory
    {
        public override PersonalComputer MakePersonalComputer()
        {
            CPU cpu = new CPU(4, 64);
            RAM ram = new RAM(8);
            HardDrive hardDrive = new HardDrive(1000, false, 0);
            VideoCard videoCard = new VideoCard(false);

            PersonalComputer dellPersonalComputer = new PersonalComputer(cpu, ram, hardDrive, videoCard);

            return dellPersonalComputer;
        }

        public override Laptop MakeLaptop()
        {
            CPU cpu = new CPU(4, 32);
            RAM ram = new RAM(8);
            HardDrive hardDrive = new HardDrive(1000, false, 0);
            VideoCard videoCard = new VideoCard(false);
            Battery battery = new Battery();

            Laptop dellLaptop = new Laptop(cpu, ram, hardDrive, videoCard, battery);

            return dellLaptop;
        }

        public override Server MakeServer()
        {
            CPU cpu = new CPU(8, 64);
            RAM ram = new RAM(64);
            HardDrive hardDrive = new HardDrive(2000, true, 2);
            VideoCard videoCard = new VideoCard(true);

            Server dellServer = new Server(cpu, ram, hardDrive, videoCard);

            return dellServer;
        }
    }
}
