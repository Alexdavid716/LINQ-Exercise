using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        List<string> videoGames = new List<string>
        {
            "The Legend of Zelda",
            "Super Mario Odyssey",
            "Red Dead Redemption 2",
            "The Witcher 3",
            "Bloodborne",
            "Dark Souls",
            "Persona 5",
            "Final Fantasy ",
            "Horizon Zero Dawn",
            "Monster Hunter: World"
        };

        
        var orderedGames = videoGames.OrderBy(game => game.Length);

        
        Console.WriteLine("Ordered List of Video Games by Length:");
        foreach (var game in orderedGames)
        {
            Console.WriteLine(game);
        }
    }
}