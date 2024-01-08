namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
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

       public string FullName
        {
            get {

                return $"{FirstName} {LastName}";
            }
        }

        public PersonModel()
        {
            
        }

        

    }
}
