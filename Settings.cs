namespace USWGame
{
    internal class Settings
    {
        private string FilePath { get; set; }
        // Default value get overwritten by settings file if it exists
        public int NumRows { get; set; } = 13;
        public int NumCols { get; set; } = 17;
        public int NumTraps { get; set; } = 10;
        public int NumFood { get; set; } = 8;

        public Settings()
        {
            FilePath = "settings.conf";
            ReadSettingsFile();
        }

        public void SaveSettings()
        {
            string[] settingsList = ToString().Split(" ");
            File.WriteAllLines(FilePath, settingsList);
        }

        public void ReadSettingsFile()
        {
            using (FileStream createFileIfNotExist = File.Open(FilePath, FileMode.OpenOrCreate))
            {
                StreamReader sr = new StreamReader(createFileIfNotExist);
                // Read each line until the end of the file
                string fileLine;
                while ((fileLine = sr.ReadLine()) != null)
                {
                    string[] splitLine = fileLine.Split(',');
                    switch (splitLine[0])
                    {
                        case "NumRows":
                            NumRows = int.Parse(splitLine[1]);
                            break;
                        case "NumCols":
                            NumCols = int.Parse(splitLine[1]);
                            break;
                        case "NumTraps":
                            NumTraps = int.Parse(splitLine[1]);
                            break;
                        case "NumFood":
                            NumFood = int.Parse(splitLine[1]);
                            break;
                    }
                }
                sr.Close();
            }
        }
        public override string ToString()
        {
            return $"NumRows,{NumRows} NumCols,{NumCols} NumFood,{NumFood} NumTraps,{NumTraps}";
        }
    }
}
