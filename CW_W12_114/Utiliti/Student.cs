using System.Text.RegularExpressions;

namespace CW_W12_114.Utiliti
{
    public class Student : IStudent
    {
        static string _pattern = @"\w{3,}";
        Regex regex = new Regex(_pattern);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Student(string firstName, string lastName)
        {
            ValidateFirstName(firstName);
            ValidateLastName(lastName);

        }

        private void ValidateLastName(string lastName)
        {
            if (regex.IsMatch(lastName))
            {
                LastName = lastName;
            }
            else
            {
                throw new ArgumentException("Invalid lastname");
            }
        }

        private void ValidateFirstName(string firstName)
        {
            if (regex.IsMatch(firstName))
            {
                FirstName = firstName;
            }
            else
            {
                throw new ArgumentException("Invalid firstname");
            }
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
