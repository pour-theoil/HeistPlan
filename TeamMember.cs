using System;

namespace yourheist
{
    public class TeamMember
    {
        public string name { get; set; }

        public int skilllevel { get; set; }

        public double couragefactor { get; set; }

        public TeamMember()
        {
            skilllevel = 0;
            couragefactor = 0;
        }

        public void Getinfo(string memname)
        {
            Console.WriteLine($"Hello fellow heist member, what should we call you?");
            name = memname;
        }

        public void GetSkill()
        {

            while (true)
            {
                Console.WriteLine($"I've heard you are good, but how good are you?");
                string skill = Console.ReadLine();
                if (int.TryParse(skill, out int skills) && skills >=0)
                {
                    skilllevel = skills;
                    break;
                }
                
                    Console.WriteLine("We don't have time for your antics, please enter a number larger than 0.");
                
            }
        }

        public void GetCourage()
        {

            while (true)
            {
                Console.WriteLine($"You are pretty fierce? Enter your courage factor: 0-2");
                string courage = Console.ReadLine();
                if (double.TryParse(courage, out double skills) && skills >= 0 && skills <= 2)
                {
                    couragefactor = skills;
                    break;
                }
                else
                {
                    Console.WriteLine("Seriously, you know the drill, please 0-2!");
                }
            }
        }

        public void Printinfo()
        {
            Console.WriteLine(
                $@"{name} are ready to go? 
You are awesome and have a skill of {skilllevel}
But only {couragefactor} courage. What gives?");
        }

    }
}
