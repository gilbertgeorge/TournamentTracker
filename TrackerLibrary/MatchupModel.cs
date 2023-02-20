using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one matchup in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
    
        /// <summary>
        /// Winner of the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
    
        /// <summary>
        /// Round number of the matchup.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}