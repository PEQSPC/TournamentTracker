using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAcess
{
    public class TextConnection : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonFile = "PersonModels.csv";
        //TODO - Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the text file and convert the text to List<PrizeModel>
           List<PrizeModel> prizes =  PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the max ID
            int currentID = 1;

            if (prizes.Count > 0)
            {
                currentID = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentID;

            //add the new record with the new ID (max +1)
           prizes.Add(model);

            //convert the prizes to listz<string>
            //save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            return model;
        }

        public List<PersonModel> GetPerson_ALL()
        {
            throw new System.NotImplementedException();
        }
    }
}
