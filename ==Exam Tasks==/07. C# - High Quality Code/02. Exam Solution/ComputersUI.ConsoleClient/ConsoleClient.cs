namespace ComputersUI.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using ComputersUI.ConsoleClient.SystemComponents;

    public class ConsoleClient
    {
        public static void Main()
        {
            var manufacturer = Console.ReadLine();

            PersonalComputer pc = null;
            Laptop laptop = null;
            Server server = null;

            CheckTheManufacturer(manufacturer, ref pc, ref laptop, ref server);

            while (true)
            {
                var consoleCommandLine = Console.ReadLine();

                if (consoleCommandLine.StartsWith("Exit") || consoleCommandLine == null)
                {
                    break;
                }

                var commandParameters = consoleCommandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandParameters.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                ExecuteCommand(pc, laptop, server, commandParameters);
            }

            Console.ReadLine();
        }

        private static void CheckTheManufacturer(string manufacturer, ref PersonalComputer pc, ref Laptop laptop, ref Server server)
        {
            if (manufacturer == "HP")
            {
                var hpManufacturer = new HPManufacturer();
                var factoryManager = new FactoryManager(hpManufacturer);

                pc = factoryManager.MakePersonalComputer();
                laptop = factoryManager.MakeLaptop();
                server = factoryManager.MakeServer();
            }
            else if (manufacturer == "Dell")
            {
                var dellManufacturer = new DellManufacturer();
                var factoryManager = new FactoryManager(dellManufacturer);

                pc = factoryManager.MakePersonalComputer();
                laptop = factoryManager.MakeLaptop();
                server = factoryManager.MakeServer();
            }
            else if (manufacturer == "Lenovo")
            {
                var lenovoManufacturer = new LenovoManufacturer();
                var factoryManager = new FactoryManager(lenovoManufacturer);

                pc = factoryManager.MakePersonalComputer();
                laptop = factoryManager.MakeLaptop();
                server = factoryManager.MakeServer();
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }
        }

        private static void ExecuteCommand(PersonalComputer pc, Laptop laptop, Server server, string[] commandParameters)
        {
            var inputConsoleCommand = commandParameters[0];
            var commandArgument = int.Parse(commandParameters[1]);

            if (inputConsoleCommand == "Charge")
            {
                string result = laptop.ChargeBattery(commandArgument);
                laptop.VideoCardOfComputer.Draw(result + "%");
            }
            else if (inputConsoleCommand == "Process")
            {
                string result = server.Process(commandArgument);
                server.VideoCardOfComputer.Draw(result);
            }
            else if (inputConsoleCommand == "Play")
            {
                string result = pc.Play(commandArgument);
                pc.VideoCardOfComputer.Draw(result);
            }
            else
            {
                Console.WriteLine("Invalid command!");
            }
        }
    }
}
