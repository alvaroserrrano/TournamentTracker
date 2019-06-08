using System;
using System.Collections.Generic;
namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of tournament
        /// </summary>
        /// <value>The name of the tournament.</value>
        public string TournamentName { get; set; }
        /// <summary>
        /// Tournament entry fee
        /// </summary>
        /// <value>The entry fee.</value>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teams participating in the tournament
        /// </summary>
        /// <value>The entered teams.</value>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Prizes given in the tournament
        /// </summary>
        /// <value>The prizes.</value>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Rounds of the tournament
        /// </summary>
        /// <value>The rounds.</value>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
    