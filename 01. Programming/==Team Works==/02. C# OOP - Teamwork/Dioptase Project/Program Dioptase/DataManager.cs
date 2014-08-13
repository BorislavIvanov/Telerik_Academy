namespace ProgramDioptase
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using ProgramDioptase.Interfaces.DatabaseManager;
    using ProgramDioptase.Interfaces.ItemDescription;

    public sealed class DataManager : IFileManager
    {
        private static Uri ResourcePath = new Uri(@"Resources", UriKind.RelativeOrAbsolute);
        private static Uri ClientPath = new Uri(@"../../Clients", UriKind.RelativeOrAbsolute);
        private static Uri LibraryPath = new Uri(@"Library", UriKind.RelativeOrAbsolute);
        private static Uri MoviePath = new Uri(string.Format(@"../../{0}\Movies", LibraryPath), UriKind.RelativeOrAbsolute);
        private static Uri GamePath = new Uri(string.Format(@"../../{0}\Games", LibraryPath), UriKind.RelativeOrAbsolute);
        private static Uri MusicPath = new Uri(string.Format(@"../../{0}\Music", LibraryPath), UriKind.RelativeOrAbsolute);

        public DataManager()
        {
        }

        public string GetOrdersCount(Uri baseDirectory)
        {
            string count = new StreamReader(string.Format(@"{0}\statistics.txt", baseDirectory)).ReadToEnd();

            using (StreamReader countReader = new StreamReader(string.Format(@"{0}\statistics.txt", baseDirectory)))
            {
                count = countReader.ReadLine();
            }

            return count;
        }

        public Uri GetBaseDirectory(string type)
        {
            Uri baseDirectory = default(Uri);

            switch (type)
            {
                case "Movie": baseDirectory = DataManager.MoviePath; break;
                case "Game": baseDirectory = DataManager.GamePath; break;
                case "Music": baseDirectory = DataManager.MusicPath; break;
                case "Client": baseDirectory = DataManager.ClientPath; break;
                case "Resource": baseDirectory = DataManager.ResourcePath; break;
            }

            if (baseDirectory == null)
            {
                throw new ArgumentException();
            }

            return baseDirectory;
        }

        public IList<T> GetItems<T>(Uri baseDirectory)
            where T : IDataInitializable, new()
        {
            var allItems = new List<T>();

            if (Directory.Exists(baseDirectory.ToString()) && File.Exists(string.Format(@"{0}\items.txt", baseDirectory)))
            {
                // Reading all items names
                var itemNames = this.ReadItemsNames(baseDirectory);

                // Reading item information by item name
                this.InitializeObjectData<T>(itemNames, baseDirectory, allItems);
            }

            return allItems;
        }

        public IList<string> ReadItemsNames(Uri baseDirectory)
        {
            var itemNames = new List<string>();

            using (StreamReader itemNameReader = new StreamReader(string.Format(@"{0}\items.txt", baseDirectory)))
            {
                while (!itemNameReader.EndOfStream)
                {
                    itemNames.Add(itemNameReader.ReadLine());
                }
            }

            return itemNames;
        }

        public void InitializeObjectData<T>(IList<string> itemNames, Uri baseDirectory, IList<T> allItems)
            where T : IDataInitializable, new()
        {
            // Reading item information by item name
            foreach (var itemName in itemNames)
            {
                string itemDirectory = string.Format(@"{0}\{1}", baseDirectory, itemName);

                if (Directory.Exists(itemDirectory) && File.Exists(itemDirectory + @"\info.txt"))
                {
                    using (StreamReader itemInfo = new StreamReader(string.Format(@"{0}\{1}\info.txt", baseDirectory, itemName)))
                    {
                        string[] components = itemInfo.ReadToEnd().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                        var currentItem = new T();
                        currentItem.InitializeData(components);

                        allItems.Add(currentItem);
                    }
                }
            }
        }
    }
}