using Newtonsoft.Json;
using RpgCryptoJitsu.Game;
using RpgCryptoJitsu.Models;
using System;
using System.Text.Json.Serialization;

class Program
{
        
    private static GameService gameService = new GameService();
    private static void Main(string[] args)
    {
        MakeTitle();
        MakeMainMenu();

    }

    private static void MakeTitle()
    {
        string title = @"
 _______ .______    __    ______    .______        ___   .___________.___________. __       _______ 
|   ____||   _  \  |  |  /      |   |   _  \      /   \  |           |           ||  |     |   ____|
|  |__   |  |_)  | |  | |  ,----'   |  |_)  |    /  ^  \ `---|  |----`---|  |----`|  |     |  |__   
|   __|  |   ___/  |  | |  |        |   _  <    /  /_\  \    |  |        |  |     |  |     |   __|  
|  |____ |  |      |  | |  `----.   |  |_)  |  /  _____  \   |  |        |  |     |  `----.|  |____ 
|_______|| _|      |__|  \______|   |______/  /__/     \__\  |__|        |__|     |_______||_______|
                                                                                                    
";
        //Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(title);
        Console.WriteLine("----------------------------");
        Console.ResetColor();
        //Console.ForegroundColor = ConsoleColor.White;

    }

    private static void MakeMainMenu()
    {
        MakeMenuOptions();
        bool inputValid = false;

        while (!inputValid)
        {
 
            switch (Console.ReadLine().ToUpper())
            {
                case "S":
                    gameService.StartGame();
                    inputValid = true;
                    break;
                case "L":
                    LoadGame();
                    inputValid = true;
                    break;
                case "C":
                    CreateCharacter();
                    inputValid = true;
                    break;
                default:
                    Console.WriteLine("Um.. wrong letter?1?");
                    MakeMenuOptions();
                    break;
            }

            //if (userMain == "S" || userMain == "L" || userMain == "C")
            //{
            //    //Console.WriteLine($"You chose {userMain}");
            //    if (userMain == "S")
            //    {
            //        StartGame();
            //    }
            //    else if (userMain == "L")
            //    {
            //        LoadGame();
            //    }
            //    else
            //    {
            //        CreateCharacter();
            //    }
            //    inputValid = true;
            //}
            //else
            //{
            //    Console.WriteLine("Um.. wrong letter?1?");
            //    MakeMenuOptions();
            //}
        }


    }

    private static void MakeMenuOptions()
    {
        Console.WriteLine("\n\n(S)tart a new game");
        Console.WriteLine("(L)oad a game");
        Console.WriteLine("(C)reate a new character");
    }

   

    private static void CreateCharacter()
    {
        Console.WriteLine("Create a new character");
    }

    private static void LoadGame()
    {
        Console.WriteLine("Loading...");
    }
}