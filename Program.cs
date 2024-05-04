using System.Runtime.CompilerServices;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Char RickGrimes = new Char(1025, "Rick Grimes", "Revolver");
            RickGrimes.Intro();

            Char DarylDixon = new Char(987, "Daryl Dixon", "Crossbow");
            DarylDixon.Intro();

            Char GlennRhee = new Char(752, "Glenn Rhee", "Butterfly Knife");
            GlennRhee.Intro();
        }
    }

    public class Char
    {
        private string Name { get; set; }

        private string Weapon { get; set; }

        private double Kills { get; set; }

        public Char() { }

        public Char(double kills)
        {
            Kills = kills;
        }

        public Char(double kills, string name) : this(kills)
        {
            Name = name;
        }

        public Char(double kills, string name, string weapon) : this(kills, name)
        {
            Weapon = weapon;
        }

        public void Intro()
        {
            Console.WriteLine($"{Name} - {Weapon} - {Kills} kills.");
        }
    }
}

