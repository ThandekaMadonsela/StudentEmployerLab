// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using StudentEmployerLab.Models;
using StudentEmployerLab.Models.Utilities;

Console.WriteLine("Hello, World!");

List<string> names = new List<string>
            {
                "John", "Alice", "Bob", "Eva", "Michael", "Sophia", "David", "Olivia",
                "Daniel", "Emma", "James", "Emily", "William", "Ava", "Joseph", "Mia",
                "Christopher", "Abigail", "Matthew", "Charlotte"
            };

List<string> surnames = new List<string>
            {
                "Smith", "Johnson", "Brown", "Lee", "Davis", "Williams", "Jones", "Miller",
                "Taylor", "Wilson", "Anderson", "Moore", "Jackson", "White", "Harris",
                "Martin", "Thompson", "Walker", "Clark", "Lewis"
            };

List<string> telephoneNumbers = new List<string>
            {
                "0123456789", "0112345678", "0134567890", "0145678901", "0156789012",
                "0167890123", "0178901234", "0189012345", "0190123456", "0201234567",
                "0212345678", "0223456789", "0234567890", "0245678901", "0256789012",
                "0267890123", "0278901234", "0289012345", "0290123456", "0301234567"
            };

List<string> SAIDs = new List<string>
            {
                "5905116388065", "7302265708368", "9004172179992", "6804273533323",
                "5107217249236", "5902272315207", "8505153463408", "9107226107399",
                "5708155319433", "7006202415153", "9403182353832", "9108151749826",
                "6603202562140", "8302271714988", "9206124551888", "6806111665734",
                "6101163646023", "9408231394990", "9802123139483", "5707123345887"
            };

List<string> streetNames = new List<string>
            {
                "Main Street", "Oak Avenue", "Maple Road", "Elm Crescent", "Cedar Lane",
                "Willow Street", "Pine Avenue", "Birch Road", "Magnolia Close", "Acacia Way",
                "Rosemary Lane", "Jasmine Street", "Lily Road", "Sunflower Avenue", "Bluebell Crescent",
                "Iris Lane", "Lavender Road", "Marigold Way", "Violet Street", "Daisy Lane"
            };

List<string> cities = new List<string>
            {
                "Johannesburg", "Cape Town", "Durban", "Pretoria", "Port Elizabeth",
                "Bloemfontein", "Pietermaritzburg", "East London", "Nelspruit", "Kimberley",
                "Polokwane", "Rustenburg", "George", "Mthatha", "Vereeniging", "Witbank",
                "Upington", "Mafikeng", "Bethlehem", "Klerksdorp"
            };

List<string> provinces = new List<string>
            {
                "Gauteng", "Western Cape", "KwaZulu-Natal", "Eastern Cape", "Limpopo",
                "Mpumalanga", "North West", "Free State", "Gauteng", "KwaZulu-Natal",
                "Northern Cape", "Eastern Cape", "Western Cape", "Gauteng", "Limpopo",
                "North West", "Mpumalanga", "Free State", "KwaZulu-Natal"
            };

// Create student and employer objects with addresses
List<User> users = new List<User>();

// Create student objects
for (int i = 0; i < 5; i++)
{
    var student = CreateStudent(names[i], surnames[i], SAIDs[i], telephoneNumbers[i]);
    AssignAddresses(student, streetNames, cities, provinces);
    users.Add(student);
}

// Create employer objects
for (int i = 5; i < 10; i++)
{
    var employer = CreateEmployer(names[i], surnames[i], SAIDs[i], telephoneNumbers[i]);
    AssignAddresses(employer, streetNames, cities, provinces);
    users.Add(employer);
}

// Display user information
foreach (var user in users)
{
    Console.WriteLine($"Name: {user.Firstname} {user.Surname}");
    Console.WriteLine("Addresses:");
    foreach (var address in user.Addresses)
    {
        Console.WriteLine($"- {address.AddressName}, {address.Street}, {address.CityOrTown}, {address.Province}, {address.PostalCode}");
    }
    Console.WriteLine();
}
        

        static Student CreateStudent(string fname, string lname, string idNumber, string phoneNumber)
{
    var studentNumber = Util.GenerateRandomNumbers(1, 10000000, 99999999, 8)[0];
    return new Student(fname, lname, studentNumber)
    {
        IDnumber = idNumber,
        PhoneNumber = phoneNumber
    };
}

static Employer CreateEmployer(string fname, string lname, string idNumber, string phoneNumber)
{
    var staffNumber = Util.GenerateRandomNumbers(1, 1000000, 9999999, 7)[0];
    return new Employer(fname, lname, staffNumber)
    {
        IDnumber = idNumber,
        PhoneNumber = phoneNumber
    };
}

static void AssignAddresses(User user, List<string> streetNames, List<string> cities, List<string> provinces)
{
    Random random = new Random();
    int numAddresses = random.Next(1, 4); // Assign 1 to 3 addresses

    for (int i = 0; i < numAddresses; i++)
    {
        var address = new Address
        {
            AddressName = $"Address {i + 1}",
            Street = streetNames[random.Next(streetNames.Count)],
            CityOrTown = cities[random.Next(cities.Count)],
            Province = provinces[random.Next(provinces.Count)],
            PostalCode = Util.GenerateRandomNumbers(1, 1000, 9999, 4)[0]
        };

        user.Addresses.Add(address);
    }
}