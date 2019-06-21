using System;
using System.Collections.Generic;
namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }
        /// <summary>
        /// List of matchup entries
        /// </summary>
        /// <value>The entries.</value>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Gives the winner of the matchup
        /// </summary>
        /// <value>The winner.</value>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Gives the matchup round
        /// </summary>
        /// <value>The matchup round.</value>
        public int MatchupRound { get; set; }
        public int WinnerId { get; set; }
        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Matchup not yet determined";
                        break;
                    }
                }
                return output;
            }
        }

        public override string ToString()
        {
            return $"Round: {MatchupRound}";
        }

    }
}