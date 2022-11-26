namespace HotelProjectChallenge.Models
{
    public class Reserve
    {
        public List<Person>? Guests { get; set; }
        public Suite? Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reserve(int reservedDays)
        {
            this.ReservedDays = reservedDays;
        }

        public void RegisterGuests(List<Person> guests)
        {

            if (guests.Count() > this.Suite!.Capacity)
            {
                throw new Exception("A mais hóspedes do que a capacidade da suite ");
            }
            else
            {
                this.Guests = guests;
            }
        }

        public void RegisterSuite(Suite suite)
        {
            this.Suite = suite;
        }

        public int GetNumberOfGuests()
        {
            return this.Guests is not null ? this.Guests.Count() : 0;
        }

        public decimal CalculateDailyRate()
        {
            decimal price = this.ReservedDays * this.Suite!.DailyRate;

            const decimal discountPercentage = 0.1M;

            return this.ReservedDays >= 10 ? price - (price * discountPercentage) : price;

        }

    }
}