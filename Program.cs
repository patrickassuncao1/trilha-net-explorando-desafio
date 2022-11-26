using HotelProjectChallenge.Models;

List<Person> guests = new List<Person>();
guests.Add(new Person(name: "Paulo"));
guests.Add(new Person(name: "Silva"));

Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyRate: 30);

Reserve reserve = new Reserve(reservedDays: 9);
reserve.RegisterSuite(suite);
reserve.RegisterGuests(guests);

Console.WriteLine($"Hóspedes: {reserve.GetNumberOfGuests()}");
Console.WriteLine($"Valor diária: {reserve.CalculateDailyRate()}");


