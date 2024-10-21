namespace W4_School
{
    public class Person
    {
        private string name;
        private string surname;
        private int birthYear;

        // getters and setters
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public int BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                {
                    birthYear = value;
                }
            }
        }
    }
}
