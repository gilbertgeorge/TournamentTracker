namespace TrackerLibrary
{
    /// <summary>
    /// Represents the prize for a particular place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Prize associated with finished place.
        /// </summary>
        public int PlaceNumber { get; set; }
    
        /// <summary>
        /// Name representing the Place (PlaceNumber).
        /// </summary>
        public string PlaceName { get; set; }
    
        /// <summary>
        /// Amount of money associated with the Place.
        /// </summary>
        public decimal PrizeAmount { get; set; }
    
        /// <summary>
        /// Percentage of the total prize pool associated with the Place.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}