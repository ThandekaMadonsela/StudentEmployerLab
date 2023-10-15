// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using StudentEmployerLab.Data;
using StudentEmployerLab.Models;
using StudentEmployerLab.Models.Utilities;

Console.WriteLine("Student Employment Lab!");


//////////////////////////// POPULATE USERS /////////////////////////////////////

//EMPTY LIST OF USERS
List<User> users = new List<User>();

Console.WriteLine("-------------------------STUDENTS INITIALIZING VALIDATIONS-------------------------------");
// ADD STUDENTS TO LIST OF USERS
for (int i = 0; i < 10; i++)
{
    Student student = new Student(Data.FirstNames[i], Data.Surnames[i], Data.StudentNumbers[i]);
    student.SetIDNumber(Data.SAIDs[i]);
    student.SetPhoneNumber(Data.telephoneNumbers[i]);
    
    ;    if (!Util.AssignAddresses(student, Data.StreetNames, Data.Cities, Data.Provinces, Data.AddressNames))
    {
        Console.WriteLine("Unable to assigning address to student");
    }
    else
    {
        users.Add(student);
    }
}
Console.WriteLine("-------------------------EMPLOYERS INITIALIZING VALIDATIONS-------------------------------");
// ADD EMPLOYERS TO LIST OF USERS
for (int i = 0; i < 10; i++)
{
    string StaffNumberPrefix = Util.GetAorB();

    Employer employer = new Employer(Data.FirstNames[i], Data.Surnames[i], StaffNumberPrefix + Data.StuffNumbers[i]);

    if (!Util.AssignAddresses(employer, Data.StreetNames, Data.Cities, Data.Provinces, Data.AddressNames))
    {
        Console.WriteLine("Unable to assigning address to employer");
    }
    else
    {
        users.Add(employer);
    }
    //var RandomNumberOfPosts = Util.Random.Next(0, 3);

    //while (RandomNumberOfPosts > 0)
    //{
    //    RandomNumberOfPosts--;
    //    var post = employer.CreatePost();
    //    employer.Posts.Add(post);
    //}
}
////////////////////////////////////////// DISPLAY /////////////////////////////////////////

string firstName, Surname;
Console.WriteLine("--------------------------------------------- USERS ---------------------------------------- ");
foreach (var user in users)
{
    Console.WriteLine();
    Console.WriteLine($"User validation:");
    user.ValidateUser();
    Console.WriteLine();

    user.GetFullName(out firstName, out Surname);

    Console.WriteLine();

    if (firstName == null || Surname == null)
    {
        Console.WriteLine($"Invalid name or surname");
    }
    else
    {
        Console.WriteLine($"Names: {firstName} {Surname}");
    }
    Console.WriteLine("Addresses:");
    foreach (var address in user.Addresses)
    {
        Console.WriteLine($"- {address.AddressName}, {address.Street}, {address.CityOrTown}, {address.Province}, {address.PostalCode}");

    }

    //if(user is Employer employer)
    //{
    //    Console.WriteLine("                   -----Employer Posts-----            ");
    //    foreach (var post in employer.Posts)
    //    {
    //        Console.WriteLine("Post:");
    //        Console.WriteLine($"Company name -> {post.GetCompanyName}");
    //        Console.WriteLine($"Description -> {post.GetJobDescription}");
    //        Console.WriteLine($"Department -> {post.GetDepartment}");
    //        Console.WriteLine($"Rate -> {post.GetRate}");
    //        Console.WriteLine($"Start date -> {post.GetStartDate}");
    //        Console.WriteLine();
    //    }
       
        
    //}
    Console.WriteLine("------------------------------------------------------------------------------------------");
}
        
