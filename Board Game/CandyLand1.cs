using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
namespace BoardGame.BoardGameBase;
public class CandyLand : BoardGameBase1
{
    public string Name;
    int MinPlayers;
    int MaxPlayers;
    int PlayTime;
    
    public CandyLand(string name, int minPlayers, int maxPlayers, int playTime){
        Name = name;
        MinPlayers = minPlayers;
        MaxPlayers = maxPlayers;
        PlayTime = playTime;
    }
    public override void Play()
    {
        Console.WriteLine("Welcome to Candy Land");
    }

    enum DrawCard
    {
        Red,
        Green,
        Yellow,
        Blue,
        Purple,
        Orange,
    }

}