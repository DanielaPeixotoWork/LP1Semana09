using System;
using System.Collections.Generic;

public class Player
{
    public PlayerClass PCClass { get; }
    public string Name { get; }

    public Player(PlayerClass pcClass, string name)
    {
        PCClass = pcClass;
        Name = name;
    }

    public override int GetHashCode()
    {
        return PCClass.GetHashCode() ^ Name.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Player))
            return false;

        Player other = (Player)obj;
        return PCClass == other.PCClass && Name == other.Name;
    }
}

public enum PlayerClass
{
    Tank, Fighter, Slayer, Mage,
    Controller, Marksmen
}

class Program
{
    static void Main(string[] args)
    {
        HashSet<Player> setOfPlayers = new HashSet<Player>();

        Player player1 = new Player(PlayerClass.Tank, "Ana");
        Player player2 = new Player(PlayerClass.Slayer, "Paulo");
        Player player3 = new Player(PlayerClass.Tank, "Ana");

        setOfPlayers.Add(player1);
        setOfPlayers.Add(player2);
        setOfPlayers.Add(player3);

        foreach (Player p in setOfPlayers)
        {
            Console.WriteLine($"{p.Name} is a {p.PCClass}");
        }
    }
}
