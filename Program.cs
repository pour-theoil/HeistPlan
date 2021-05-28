using System;

namespace yourheist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("");
            Console.WriteLine("It's time to build your team.");
            Console.WriteLine("");

            Team heistteam = new Team();
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter the name of a member or return to got to the next step");
                Console.WriteLine("");

                TeamMember person = new TeamMember();
                Console.WriteLine($"Hello fellow heist member, what should we call you?");
                string name = Console.ReadLine();
                try
                {
                    person.Getinfo(name);
                    person.GetSkill();
                    person.GetCourage();
                    person.Printinfo();

                    heistteam.Addmember(person);

                }
                catch
                {
                    break;
                }
            }

            Console.WriteLine($"You have {heistteam.teamsize()}");
            heistteam.readteam();

        }
    }
}
