using Newtonsoft.Json;
using PetLibrary.GameSettings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLibrary
{
    public class SaveAndLoad
    {
        private static string pathToSaveFolder = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName.ToString();
        public static string PathToSaveFolder
        {
            get
            {
                return pathToSaveFolder;
            }
        }
        private static string pathToPetFile = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName.ToString() + @"\petFile.txt";
        public static string PathToPetFile
        {
            get
            {
                return pathToPetFile;
            }
            set
            {
                pathToSettingsFile = value;
            }
        }
        private static string pathToSettingsFile = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName.ToString() + @"\settingsFile.txt";
        public static string PathToSettingsFile
        {
            get
            {
                return pathToSettingsFile;
            }
            set
            {
                pathToSettingsFile = value;
            }
        }

        public static void Save(Pet pet)
        {
            string petJSON = JsonConvert.SerializeObject(pet);
            File.WriteAllText(PathToPetFile, petJSON);
        }
        public static void Save(StateTimer stateTimer)
        {
            string stateJSON = JsonConvert.SerializeObject(stateTimer);
            File.WriteAllText(PathToSettingsFile, stateJSON);
        }
        public static Pet LoadPet()
        {
            string petJSON = File.ReadAllText(PathToPetFile);
            return JsonConvert.DeserializeObject<Pet>(petJSON);
        }
        public static StateTimer LoadSettings()
        {
            string stateJSON = File.ReadAllText(PathToSettingsFile);
            return JsonConvert.DeserializeObject<StateTimer>(stateJSON);
        }
    }
}