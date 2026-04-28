using System;

namespace HomeAffairsDigitalIdentityProcessor
{
    public class CitizenProfile
    {
        // Properties
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        // Constructor
        public CitizenProfile(string name, string id, string status)
        {
            FullName = name;
            IDNumber = id;
            CitizenshipStatus = status;
            Age = CalculateAge();
        }

        // Method to calculate age from SA ID
        private int CalculateAge()
        {
            try
            {
                if (IDNumber.Length < 6)
                    return 0;

                int year = int.Parse(IDNumber.Substring(0, 2));
                int month = int.Parse(IDNumber.Substring(2, 2));
                int day = int.Parse(IDNumber.Substring(4, 2));

                // Determine century
                int currentYear = DateTime.Now.Year % 100;
                int fullYear = (year <= currentYear) ? 2000 + year : 1900 + year;

                DateTime birthDate = new DateTime(fullYear, month, day);

                int age = DateTime.Now.Year - birthDate.Year;

                // Adjust if birthday hasn't happened yet this year
                if (DateTime.Now < birthDate.AddYears(age))
                    age--;

                return age;
            }
            catch
            {
                return 0; // prevents crash if ID is invalid
            }
        }

        // Validation Method
        public string ValidateID()
        {
            if (string.IsNullOrWhiteSpace(IDNumber))
                return "Invalid ID: Cannot be empty";

            if (IDNumber.Length != 13)
                return "Invalid ID: Must be 13 digits";

            if (!long.TryParse(IDNumber, out _))
                return "Invalid ID: Must contain only numbers";

            if (Age <= 0 || Age > 120)
                return "Invalid ID: Age calculation failed";

            return "Valid ID";
        }
    }
}