
namespace SnoopQA.Data
{
    class TestData
    {
        public static string Login { get; set; } = "Yoya";
        public static string Passwrod { get; set; } = "123123";
        public static string loginSuccess { get; set; } = "Sign Out";

        public static string RandomUserId { get; set; } = Faker.RandomNumber.Next(1, 99999).ToString();
        public static string Password { get; set; } = Faker.Internet.UserName();
        public static string FirstName { get; set; } = Faker.Name.First();
        public static string LastName { get; set; } = Faker.Name.Last();
        public static string Email { get; set; } = Faker.Internet.Email();
        public static string Phone { get; set; } = Faker.Phone.Number();
        public static string Address { get; set; } = Faker.Address.StreetAddress();
        public static string City { get; set; } = Faker.Address.City();
        public static string State { get; set; } = Faker.Address.UsState();
        public static string ZipCode { get; set; } = Faker.Address.ZipCode();
        public static string Country { get; set; } = Faker.Address.Country();

    }






}
