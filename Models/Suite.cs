namespace HotelProjectChallenge.Models
{
    public class Suite
    {
        public string? SuiteType { get; set; }
        public int Capacity { get; set; }
        public decimal DailyRate { get; set; }

        public Suite() { }

        public Suite(string suiteType, int capacity, decimal dailyRate)
        {
            this.SuiteType = suiteType;
            this.Capacity = capacity;
            this.DailyRate = dailyRate;
        }

    }
}