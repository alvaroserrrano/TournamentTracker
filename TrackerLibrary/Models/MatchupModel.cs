using System;
using System.Collections.Generic;
namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// List of matchup entries
        /// </summary>
        /// <value>The entries.</value>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Gives the winner of the matchup
        /// </summary>
        /// <value>The winner.</value>
        public TeamModel Winner{ get; set; }
        /// <summary>
        /// Gives the matchup round
        /// </summary>
        /// <value>The matchup round.</value>
        public int MatchupRound { get; set; }
    }
}
