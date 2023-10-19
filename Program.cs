class Program
{
    static void Main(string[] args)
    {
       List <HSItem> Highscores = new List<HSItem>();
       Highscores.Add(new HSItem("Lisa", 587));
       Highscores.Add(new HSItem("Majvor", 823));
       Highscores.Add(new HSItem("Siv", 123));
    }
}
public class Highscore
{
    public void Highscore();
    {
        public int MaxInList;
        Highscore (int maxinlist)
        {
            MaxInList = maxinlist;
        }
    }
    
}
public class HSItem
{
    public string Name;
    public int Points;
    public HSItem (string name, int points)
    {
        Name = name;
        Points = points;
    }
}
