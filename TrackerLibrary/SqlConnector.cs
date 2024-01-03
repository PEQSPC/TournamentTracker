namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method,actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize Information</param>
        /// <returns>The prize information,including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;

            return model;
        }

    }
}
