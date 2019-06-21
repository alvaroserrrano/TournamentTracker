using System;
namespace TrackerLibrary.Models
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
        public double PrizePercentage { get; set; }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount,string prizePercentage)
        {
            PlaceName = placeName;

            int.TryParse(placeNumber, out int PlaceNumberValue);
            PlaceNumber = PlaceNumberValue;

            decimal.TryParse(prizeAmount, out decimal PrizeAmountValue);
            PrizeAmount = PrizeAmountValue;

            double.TryParse(prizePercentage, out double PrizePercentageValue);
            PrizePercentage = PrizePercentageValue;
        }
        public override string ToString() => $"{PlaceNumber}. Platz - {PlaceName}";
    }
}
