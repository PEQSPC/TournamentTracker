namespace TrackerLibrary.Models
{
    public class PrizeModel
    {

        /// <summary>
        /// Unique id to identify the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Lugar da qualificaçao
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Nome da qualificacao 
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Preço de cada qualificacao
        /// </summary>
        public decimal PrizeAmount { get; set; }

        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }

    }
}
