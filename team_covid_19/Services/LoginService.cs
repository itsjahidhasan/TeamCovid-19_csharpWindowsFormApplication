using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_covid_19.Entities;
using team_covid_19.Repository;

namespace team_covid_19.Services
{
    class LoginService
    {
        LoginRepository loginRepo;
        public LoginService()
        {
            loginRepo = new LoginRepository();
        }

        public int LoginValidation(string username, string password)
        {
            return loginRepo.Validation(new User() { Email = username, Password = password });
        }
    }
}
