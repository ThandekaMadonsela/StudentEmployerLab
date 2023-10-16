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


// ADD EMPLOYERS TO LIST OF USERS
for (int i = 0; i < 10; i++)
{
    string StaffNumberPrefix = Util.GetAorB();

    Employer employer = new Employer(Data.FirstNames[i], Data.Surnames[i], StaffNumberPrefix + Data.StuffNumbers[i]);
    employer.SetIDNumber(Data.SAIDs[i]);
    employer.SetPhoneNumber(Data.telephoneNumbers[i]);
    if (!Util.AssignAddresses(employer, Data.StreetNames, Data.Cities, Data.Provinces, Data.AddressNames))
    {
        Console.WriteLine("Unable to assigning address to employer");
    }
    else
    {
        users.Add(employer);
    }
    var RandomNumberOfPosts = Util.Random.Next(0, 3);

    while (RandomNumberOfPosts > 0)
    {
        RandomNumberOfPosts--;
        Post post = employer.CreatePost();
        if (post != null)
        {
            employer.Posts.Add(post);
        };
    }
}

// ADD STUDENTS TO LIST OF USERS
for (int i = 11; i < 20; i++)
{
    Student student = new Student(Data.FirstNames[i], Data.Surnames[i], Data.StudentNumbers[i]);
    student.SetIDNumber(Data.SAIDs[i]);
    student.SetPhoneNumber(Data.telephoneNumbers[i]);

    if (!Util.AssignAddresses(student, Data.StreetNames, Data.Cities, Data.Provinces, Data.AddressNames))
    {
        Console.WriteLine("Unable to assigning address to student");
    }
    else
    {
        var randomEmployers = users.OfType<Employer>().OrderBy(x => Guid.NewGuid()).Take(2);

        foreach (var employer in randomEmployers)
        {
            foreach (var post in employer.Posts)
            {
                student.ConsumePost(post);
            }
        }
        users.Add(student);
    }
}
////////////////////////////////////////// DISPLAY /////////////////////////////////////////

string firstName, Surname;
Console.WriteLine("--------------------------------------------- USERS ---------------------------------------- ");
foreach (var user in users)
{
    Console.WriteLine();
    
    if(user is Employer employer)
    {
        
        Console.WriteLine($"Employer validation:");
        employer.ValidateUser();
    }
    if(user is Student student)
    {
        Console.WriteLine($"Student validation:");
        student.ValidateUser();
    }
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

    Console.WriteLine();
    Console.WriteLine("Addresses:");
    foreach (var address in user.Addresses)
    {
        Console.WriteLine($"- {address.AddressName}, {address.Street}, {address.CityOrTown}, {address.Province}, {address.PostalCode}");

    }

    if (user is Employer employerPost)
    {
        Console.WriteLine();
        Console.WriteLine("                   -----Employer's Posts-----            ");
        Console.WriteLine();
       
            foreach (var post in employerPost.Posts)
            {
                    Console.WriteLine("Post:");
                    Console.WriteLine($"Company name -> {post.GetCompanyName()}");
                    Console.WriteLine($"Description -> {post.GetJobDescription()}");
                    Console.WriteLine($"Department -> {post.GetDepartment()}");
                    Console.WriteLine($"Rate -> {post.GetRate()}");
                    Console.WriteLine($"Start date -> {post.GetStartDate()}");
                    Console.WriteLine();
            }
        
    }
    if (user is Student studentPost)
    {
        Console.WriteLine();
        Console.WriteLine("                   -----Student's Applications-----            ");
        Console.WriteLine();

        foreach (var application in studentPost.Posts)
        {
            Console.WriteLine("Application:");
            Console.WriteLine($"Full name of student -> {firstName} {Surname}");
            Console.WriteLine($"Company name -> {application.GetCompanyName()}");
            Console.WriteLine($"Description -> {application.GetJobDescription()}");
            Console.WriteLine($"Department -> {application.GetDepartment()}");
            Console.WriteLine($"Rate -> {application.GetRate()}");
            Console.WriteLine($"Start date -> {application.GetStartDate()}");
            Console.WriteLine();
        }

    }


    Console.WriteLine("------------------------------------------------------------------------------------------");
}
        
