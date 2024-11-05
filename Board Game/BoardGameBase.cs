using System.Dynamic;
abstract public class BoardGameBase1()
{
    string Name { get; set;}
    int MinPlayers { get; set;}

    int MaxPlayers { get; set;}
    int PlayTime { get; set;}


    public virtual void Play()
    {
        Console.WriteLine("Playing the Board Game.");
    }

    public void DisplayInfo(string name, int minPlayers, int maxPlayers,int playTime)
    {
        Name = name;
        MinPlayers = minPlayers;
        MaxPlayers = maxPlayers;
        PlayTime = playTime;


    }


}
