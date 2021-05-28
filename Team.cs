using System;
using System.Collections.Generic;

namespace yourheist
{
    public class Team{
        public List<TeamMember> team {get; set; }

        public Team(){
            team = new List<TeamMember>();
        }
        
        public void Addmember(TeamMember member){
            team.Add(member);
        }

        public void readteam(){
            foreach(var mem in team)
            {
                Console.WriteLine($@"
Name: {mem.name}
Skill: {mem.skilllevel}
Courage: {mem.couragefactor}");
            }
        }

        public int teamsize(){
            return team.Count;
        }

    }
}