// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using StudentEmployerLab.Data;
using StudentEmployerLab.Models;
using StudentEmployerLab.Models.Utilities;

Console.WriteLine("Student Employment Lab!");

//USERS
List<User> users = GenerateUsers();

//DISPLAY

foreach (var user in users)
{
    DisplayUserNames(user);
    DisplayUserAddresses(user);

    //If User is Employer

    if (user is Employer employer)
    {
        DisplayEmpoyerPosts(employer);
    }

    //If User is Student

    if(user is Student student)
    {

        // Select users of type Employer
        //'employers' list contains only users of type Employer

        List<Employer> employersList = users.OfType<Employer>().ToList();

        ShowAvailablePosts(employersList, student);
    }
   
    Console.WriteLine();
}

//GENERATE USERS
List<User> GenerateUsers()
{
    List<User> generatedUsers = new List<User>();

    // ADD EMPLOYERS TO LIST OF USERS
    for (int i = 0; i < 10; i++)
    {
        string StaffNumberPrefix = Util.GetAorB();

        Employer employer = new Employer(Data.FirstNames[i], Data.Surnames[i], StaffNumberPrefix + Data.StuffNumbers[i]);

        employer.SetIDNumber(Data.SAIDs[i]);
        employer.SetPhoneNumber(Data.telephoneNumbers[i]);

        if (!Util.AssignAddresses(employer))
        {
            Console.WriteLine("Unable to assigning address to employer");
        }

        var RandomNumberOfPosts = Util.Random.Next(0, 3);

        while (RandomNumberOfPosts > 0)
        {
            RandomNumberOfPosts--;
            employer.CreatePost();
        }
        generatedUsers.Add(employer);
    }

    // ADD STUDENTS TO LIST OF USERS
    for (int i = 11; i < 20; i++)
    {
        Student student = new Student(Data.FirstNames[i], Data.Surnames[i], Data.StudentNumbers[i]);

        student.SetIDNumber(Data.SAIDs[i]);
        student.SetPhoneNumber(Data.telephoneNumbers[i]);

        if (!Util.AssignAddresses(student))
        {
            Console.WriteLine("Unable to assigning address to student");
        }

        generatedUsers.Add(student);
    }

     return generatedUsers;
}    

//DISPLAY USER NAMES
void DisplayUserNames(User currentUser)
{
    if(currentUser is Student)
    {
        Console.WriteLine("--------------------------------------------- STUDENT ---------------------------------------- ");
        Console.WriteLine();
    }

    if (currentUser is Employer)
    {
        Console.WriteLine("--------------------------------------------- EMPLOYER ---------------------------------------- ");
        Console.WriteLine();
    }
    string firstName, Surname;

    currentUser.GetFullName(out firstName, out Surname);

    if (firstName == null || Surname == null)
        Console.WriteLine($"Invalid name or surname");

    Console.WriteLine();
    Console.WriteLine($"Names: {firstName} {Surname}");
}

//DISPLAY USER ADDRESSES
void DisplayUserAddresses(User currentUser)
{
    Console.WriteLine("Addresses:");

    foreach (var address in currentUser.Addresses)
    {
        Console.WriteLine($"- {address.AddressName}, {address.Street}, {address.CityOrTown}, {address.Province}, {address.PostalCode}");
    }
}

//DISPLAY EMPLOYER'S POSTS
void DisplayEmpoyerPosts(Employer currentEmployer)
{
    Console.WriteLine();
    Console.WriteLine($"Employer validation:");
    currentEmployer.ValidateUser();

    Console.WriteLine();
    Console.WriteLine("                   -----Employer's Posts-----            ");
    Console.WriteLine();

    if (currentEmployer.Posts.Count == 0)
    {
        Console.WriteLine("Employer does not have any posts");
        return;
    }
    else
    {
        int postCount = 1;

        foreach (var post in currentEmployer.Posts)
        {
            Console.WriteLine($"Post: {postCount}");
            Console.WriteLine($"Company name -> {post.GetCompanyName()}");
            Console.WriteLine($"Description -> {post.GetJobDescription()}");
            Console.WriteLine($"Department -> {post.GetDepartment()}");
            Console.WriteLine($"Rate -> {post.GetRate()}");
            Console.WriteLine($"Start date -> {post.GetStartDate()}");
            Console.WriteLine();

            postCount++;
        }
    }
}

//SHOW AVAILABLE POSTS

void ShowAvailablePosts(List<Employer> employersList, Student currentStudent)
{
    Console.WriteLine();
    Console.WriteLine($"Student validation:");
    currentStudent.ValidateUser();

    Console.WriteLine();
    Console.WriteLine("                   ----- Available Posts -----            ");
    Console.WriteLine();

    if (employersList == null)
    {
        Console.WriteLine("No posts available");
        return;
    }
    else
    {
        int postCount = 1;
        foreach (var employer in employersList)
        {
            foreach (var post in employer.Posts)
            {
                Console.WriteLine($"Post: {postCount}");
                currentStudent.ConsumePost(post);

                postCount++;
            }
        }
    }
}