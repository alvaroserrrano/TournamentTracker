using System;
namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        /// <value>The team competing.</value>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        /// <value>The score.</value>
        public double Score { get; set; }
        /// <summary>
        /// Representd the matchup that this team came from as winner
        /// </summary>
        /// <value>The parent matchup.</value>
        public MatchupModel ParentMatchup{ get; set; }
    }
}
