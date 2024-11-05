namespace BoardGame.BoardGameBase;
public class Sorry : BoardGameBase1
{
    public string Name;
    int MinPlayers;
    int MaxPlayers;
    int PlayTime;
    
    public Sorry(string name, int minPlayers, int maxPlayers, int playTime){
        Name = name;
        MinPlayers = minPlayers;
        MaxPlayers = maxPlayers;
        PlayTime = playTime;
    }
    public override void Play()
    {
        Console.WriteLine("Sorry not Sorry!");
    }

}