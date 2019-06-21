using System;
namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        /// <summary>
        /// First name
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        /// <value>The email address.</value>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Cell phone number
        /// </summary>
        /// <value>The cell phone number.</value>
        public string CellPhoneNumber { get; set; }
        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }

        public override string ToString() => FullName;

    }
}
