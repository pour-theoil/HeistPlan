using System;

namespace yourheist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Plan Your Heist!");
            
            TeamMember person = new TeamMember();
            person.Getinfo();
            person.GetSkill();
            person.GetCourage();

            person.Printinfo();

        }
    }
}
