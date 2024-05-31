using System;

public class Program
{
    public static void Main(string[] args)
    {
        Char RickGrimes = new Char(1025, "Rick Grimes", "Revolver", 42, "Leader", true);
        RickGrimes.Intro();

        Char DarylDixon = new Char(987, "Daryl Dixon", "Crossbow", 45, "Hunter", true);
        DarylDixon.Intro();

        Char GlennRhee = new Char(752, "Glenn Rhee", "Butterfly Knife", 25, "Scout", false);
        GlennRhee.Intro();
    }
}

public class Char
{
    private string Name { get; set; }
    private string Weapon { get; set; }
    private double Kills { get; set; }

    public int Age { get; set; }
    public string Role { get; set; }
    public bool IsAlive { get; set; }

    public Char() 
    {
        Name = "Unknown";
        Weapon = "Unknown";
        Kills = 0;
        Age = 0;
        Role = "Unknown";
        IsAlive = false;
    }

    public Char(double kills)
    {
        Kills = kills;
        Name = "Unknown";
        Weapon = "Unknown";
        Age = 0;
        Role = "Unknown";
        IsAlive = false;
    }

    public Char(double kills, string name) : this(kills)
    {
        Name = name;
        Weapon = "Unknown";
        Age = 0;
        Role = "Unknown";
        IsAlive = false;
    }

    public Char(double kills, string name, string weapon) : this(kills, name)
    {
        Weapon = weapon;
        Age = 0;
        Role = "Unknown";
        IsAlive = false;
    }

    public Char(double kills, string name, string weapon, int age, string role, bool isAlive) : this(kills, name, weapon)
    {
        Age = age;
        Role = role;
        IsAlive = isAlive;
    }

    public void Intro()
    {
        Console.WriteLine($"{Name} - {Weapon} - {Kills} kills. Age: {Age}, Role: {Role}, Alive: {IsAlive}");
    }

    private double CalculateEfficiency()
    {
        return Kills / (Age > 0 ? Age : 1);
    }

    public double GetEfficiency()
    {
        return CalculateEfficiency();
    }

    public void ChangeWeapon(string newWeapon)
    {
        Weapon = newWeapon;
    }
    }