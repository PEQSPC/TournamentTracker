using System.Collections.Generic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAcess
{
    public interface IDataConnection
    {

        PrizeModel CreatePrize(PrizeModel model);


        //TODO- CREATE DATA CONNECTION PERSON
        PersonModel CreatePerson(PersonModel model);

        List<PersonModel> GetPerson_ALL();

    }
}
