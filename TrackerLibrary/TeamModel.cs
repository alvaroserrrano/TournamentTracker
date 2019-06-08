using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        public string TeamName { get; set; }
    }
}
