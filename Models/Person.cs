namespace HotelProjectChallenge.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string? LastName { get; set; }
        public string FullName => $"{Name} {LastName}".ToUpper();

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }
    }
}