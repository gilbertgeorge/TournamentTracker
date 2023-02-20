using System.Collections.Generic;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Players on the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    
        /// <summary>
        /// Name of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}