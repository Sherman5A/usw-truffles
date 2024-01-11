namespace USWGame
{
    /// <summary>
    /// Settings class to manage game settings
    /// </summary>
    internal class Settings
    {
        private string FilePath { get; set; }
        // Default value get overwritten by settings file if it exists
        public int NumRows { get; set; } = 13;
        public int NumCols { get; set; } = 17;
        public int NumTraps { get; set; } = 10;
        public int NumFood { get; set; } = 8;
        public int NumReveals { get; set; } = 1;

        public Settings()
        {
            FilePath = "settings.conf";
            ReadSettingsFile();
        }

        /// <summary>
        /// Saves the object settings state to a file in CSV format
        /// First element denotes the variable, second variable denotes the value of it
        /// </summary>
        public void SaveSettings()
        {
            string[] settingsList = ToString().Split(" ");
            File.WriteAllLines(FilePath, settingsList);
        }

        /// <summary>
        /// Reads and parses the settings file
        /// </summary>
        public void ReadSettingsFile()
        {
            // Create the file if it does not exist
            using (FileStream createFileIfNotExist = File.Open(FilePath, FileMode.OpenOrCreate))
            {
                // Create a file reader
                StreamReader sr = new StreamReader(createFileIfNotExist);
                // Read each line until the end of the file
                string fileLine;
                while ((fileLine = sr.ReadLine()) != null)
                {
                    // Split by comma into arrays
                    string[] splitLine = fileLine.Split(',');
                    // Switch statement for different variables
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
                        case "NumReaveals":
                            NumReveals = int.Parse(splitLine[1]); 
                            break;
                    }
                }
                // Close StreamReader to avoid possible leaks 
                sr.Close();
            }
        }
        public override string ToString()
        {
            return $"NumRows,{NumRows} NumCols,{NumCols} NumFood,{NumFood} NumTraps,{NumTraps} NumReveals,{NumReveals}";
        }
    }
}
