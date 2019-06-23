using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection

    {
        private const string db = "Tournaments";
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <returns>The prize information and the id.</returns>
        /// <param name="model">Prize information.</param>
        public void CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("Tournaments.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
               
            }
        }
        public void CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAdress", model.EmailAddress);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
            }
        }



        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }

        public void CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@TeamName", model.TeamName);
                param.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", param, commandType: CommandType.StoredProcedure);

                model.Id = param.Get<int>("@id");

                foreach (PersonModel p in model.TeamMembers)
                {
                    param = new DynamicParameters();
                    param.Add("@TeamId", model.Id);
                    param.Add("@PersonId", p.Id);

                    connection.Execute("dbo.spTeamMember_Insert", param, commandType: CommandType.StoredProcedure);
                }
            }
        }
        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();

                foreach (TeamModel team in output)
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", param, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }
        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveTournament(model, connection);
                SaveTournamentPrizes(model, connection);
                SaveTournamentEntries(model, connection);
                SaveTournamentRounds(model, connection);
                TournamentLogic.UpdateTournamentResults(model);
            }
        }
        private static void SaveTournament(TournamentModel model, IDbConnection connection)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@TournamentName", model.TournamentName);
            param.Add("@EntryFee", model.EntryFee);
            param.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournament_Insert", param, commandType: CommandType.StoredProcedure);

            model.Id = param.Get<int>("@id");
        }
        private static void SaveTournamentPrizes(TournamentModel model, IDbConnection connection)
        {
            foreach (PrizeModel p in model.Prizes)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@TournamentId", model.Id);
                param.Add("@PrizeId", p.Id);
                param.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spTournamentPrizes_Insert", param, commandType: CommandType.StoredProcedure);
            }
        }
        private static void SaveTournamentEntries(TournamentModel model, IDbConnection connection)
        {
            foreach (TeamModel t in model.EnteredTeams)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@TournamentId", model.Id);
                param.Add("@TeamId", t.Id);
                param.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spTournamentEnterys_Insert", param, commandType: CommandType.StoredProcedure);
            }
        }
        private static void SaveTournamentRounds(TournamentModel tournament, IDbConnection connection)
        {
            //List<List<Matchup>> Rounds
            //List<MatchupEntry> Enterys

            //Looping through the rounds
            //Loop through the Matchups
            //Save the matchup
            //Loop throught the Enterys

            foreach (List<MatchupModel> round in tournament.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@TournamentId", tournament.Id);
                    param.Add("@MatchupRound", matchup.MatchupRound);
                    param.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                    connection.Execute("dbo.spMatchups_Insert", param, commandType: CommandType.StoredProcedure);

                    matchup.Id = param.Get<int>("@id");

                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        param = new DynamicParameters();
                        param.Add("@MatchupId", matchup.Id);


                        if (entry.ParentMatchup == null)
                            param.Add("@ParentMatchupId", null);
                        else
                            param.Add("@ParentMatchupId", entry.ParentMatchup.Id);


                        if (entry.TeamCompeting == null)
                            param.Add("@TeamCompetingId", null);
                        else
                            param.Add("@TeamCompetingId", entry.TeamCompeting.Id);


                        param.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                        connection.Execute("dbo.spMatchupEntry_Insert", param, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();
                DynamicParameters p = new DynamicParameters();

                foreach (TournamentModel t in output)
                {
                    // populate prizes
                    p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);

                    t.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    // populate teams
                    t.EnteredTeams = connection.Query<TeamModel>("dbo.spTeam_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
                    foreach (TeamModel team in t.EnteredTeams)
                    {
                        p = new DynamicParameters();
                        p.Add("@TeamId", team.Id);
                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                    }

                    // populate rounds
                    p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);
                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (MatchupModel matchup in matchups)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.Id);
                        matchup.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();


                        List<TeamModel> allTeams = GetTeam_All();

                        // populate each matchup (1 model)
                        if (matchup.WinnerId > 0)
                        {
                            matchup.Winner = allTeams.Where(x => x.Id == matchup.WinnerId).First();
                        }

                        // populate each entry (2 models)
                        foreach (MatchupEntryModel me in matchup.Entries)
                        {
                            if (me.TeamCompetingId > 0)
                            {
                                me.TeamCompeting = allTeams.Where(x => x.Id == me.TeamCompetingId).First();
                            }

                            if (me.ParentMatchupId > 0)
                            {
                                me.ParentMatchup = matchups.Where(x => x.Id == me.ParentMatchupId).First();
                            }
                        }

                    }

                    // List<List<Matchup>>
                    List<MatchupModel> currentRow = new List<MatchupModel>();
                    int currentRound = 1;
                    foreach (MatchupModel matchup in matchups)
                    {
                        if (matchup.MatchupRound > currentRound)
                        {
                            t.Rounds.Add(currentRow);
                            currentRow = new List<MatchupModel>();
                            currentRound++;
                        }

                        currentRow.Add(matchup);
                    }
                    t.Rounds.Add(currentRow);
                }


            }

            return output;
        }

        public void UpdateMatchup(MatchupModel model)
        {
            // spMatchups_Update @Id @WinnerId
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters param = new DynamicParameters();
                if (model.Winner != null)
                {
                    param.Add("@Id", model.Id);
                    param.Add("@WinnerId", model.Winner.Id);

                    connection.Execute("dbo.spMatchups_Update", param, commandType: CommandType.StoredProcedure);
                }


                // spMatchupsEntries_Update

                foreach (MatchupEntryModel me in model.Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        param = new DynamicParameters();
                        param.Add("@Id", me.Id);
                        param.Add("@TeamCompetingId", me.TeamCompeting.Id);
                        param.Add("@Score", me.Score);

                        connection.Execute("dbo.spMatchupEntries_Update", param, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

        public void CompleteTournament(TournamentModel model)
        {
            //spTournament_Update
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);

                connection.Execute("dbo.spTournament_Update", p, commandType: CommandType.StoredProcedure);
            }
        }
    }


}
