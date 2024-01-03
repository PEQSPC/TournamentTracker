using TrackerLibrary.Models;

namespace TrackerLibrary.DataAcess
{
    public interface IDataConnection
    {

        PrizeModel CreatePrize(PrizeModel model);

    }
}
