using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one tournament.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
    
        /// <summary>
        /// Fee for entering the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
    
        /// <summary>
        /// Teams that are entered in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
    
        /// <summary>
        /// Prizes available in the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
    
        /// <summary>
        /// Rounds of the tournament.
        /// A round is a list of matchups.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}