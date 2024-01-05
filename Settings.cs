using System.Diagnostics;

namespace USWGame
{
    internal class Settings
    {
        private string FilePath { get; set; }
        public int NumRows { get; set; }
        public int NumCols { get; set; }
        public int NumTraps { get; set; }
        public int NumFood { get; set; }

        public Settings()
        {
            FilePath = "settings.txt";
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
                // Read each line unil the end of the file
                string fileLine;
                while ((fileLine = sr.ReadLine()) != null)
                {
                    Debug.WriteLine(fileLine);
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
                Debug.WriteLine(ToString());
                // Explicitly close streamreader 
                sr.Close();
            }
        }
        public override string ToString()
        {
            return $"NumRows,{NumRows} NumCols,{NumCols} NumFood,{NumFood} NumTraps,{NumTraps}";
        }
    }
}
