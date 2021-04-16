using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_covid_19.Entities;
using team_covid_19.Repository;

namespace team_covid_19.Services
{
    class SignupService
    {
        SignupRepository signRepo;
        public SignupService()
        {
            signRepo = new  SignupRepository();
        }
        public int UserSignup(string firstName, string lastName, string phoneNo, string address, string dob, string gender, string email, string password, int userType)
        {
            return signRepo.Signup(new User(){ FirstName = firstName, LastName=lastName, PhoneNo=phoneNo, Address=address,DOB =dob, Gender=gender,Email=email,Password=password,UserType=userType });
        }

    }
}
