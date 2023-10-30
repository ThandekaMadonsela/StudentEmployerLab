using System;
using StudentEmployerLab.Interfaces;
using StudentEmployerLab.Models;
using StudentEmployerLab.Models.Utilities;

//Console.WriteLine("Student Employment Lab!");
Util util = new Util();
List<IOpportunity> opportunities = new List<IOpportunity>();
List<Address> addresses = new List<Address>();
IEnumerable<User> users = util.GenerateUsers(opportunities,addresses);


int studentCount = 1;
foreach (var user in users)
{
    ////If User is Employer
    if (user is Employer employer)
    {
         foreach (var checkUser in users)
         {
             if (checkUser is Student student)
             {
                util.StudentCount(studentCount);
                studentCount++;

                for (int i = 0; i < employer.Opportunities.Count; i++)
                {
                    student.ConsumePost(employer.Opportunities[i], student);
                }
             }
         }
    }
}

