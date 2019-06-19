using System;
namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique Identifier for id
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gives the place number
        /// </summary>
        /// <value>The place number.</value>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Gives the place name
        /// </summary>
        /// <value>The name of the place.</value>
        public string PlaceName { get; set; }
        /// <summary>
        /// Amount of the prize
        /// </summary>
        /// <value>The prize amount.</value>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of the prize
        /// </summary>
        /// <value>The price percentage.</value>
        public double PricePercentage { get; set; }
    }
}
