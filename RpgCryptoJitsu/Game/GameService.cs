using Newtonsoft.Json;
using RpgCryptoJitsu.Models;

namespace RpgCryptoJitsu.Game
{
    public class GameService
    {
        public void StartGame()
        {
            string basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Adventures";
            Adventure initialAdventure = new();

            if (File.Exists($"{basePath}\\InitialAdventure.json")) ;
            {
                DirectoryInfo directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("InitialAdventure.json");

                using (StreamReader myFile = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialAdventure = JsonConvert.DeserializeObject<Adventure>(myFile.ReadToEnd());
                }

                Console.WriteLine("New game has been started");
                Console.WriteLine($"Adventure: {initialAdventure.Title}");
                Console.WriteLine($"Description: {initialAdventure.Description}");

            }
        }
    }
}
