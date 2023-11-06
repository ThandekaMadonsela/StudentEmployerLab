using StudentEmployerLab.Models;
using StudentEmployerLab.Models.Utilities;

Util util = new Util();
IEnumerable<User> users = util.GenerateUsers();


foreach (var user in users)
    if (user is Employer employer)//If User is Employer
        foreach (var opportunity in employer.GetOpportunities())//Opportunities
            foreach (var checkUser in users)
                if (checkUser is Student student)//If User is Student
                        student.ConsumePost(opportunity);
  

