namespace TrackerLibrary.Models
{
    public class PersonModel
    {

        /// <summary>
        /// Name of the team member
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name of the team member
        /// </summary>
        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
    }
}
