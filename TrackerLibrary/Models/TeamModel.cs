﻿using System;
using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Gives members of a team
        /// </summary>
        /// <value>The team members.</value>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Name of the team
        /// </summary>
        /// <value>The name of the team.</value>
        public string TeamName { get; set; }

        public override string ToString() => TeamName;
    }
}
