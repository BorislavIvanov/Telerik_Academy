namespace ComputersUI.ConsoleClient
{
    public abstract class ComputerFactory
    {
        public abstract PersonalComputer MakePersonalComputer();

        public abstract Laptop MakeLaptop();

        public abstract Server MakeServer();
    }
}
