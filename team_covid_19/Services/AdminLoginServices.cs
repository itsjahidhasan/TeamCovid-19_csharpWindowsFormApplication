using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_covid_19.Entities;
using team_covid_19.Repository;

namespace team_covid_19.Services
{
    class AdminLoginServices
    {
        AdminLoginRepository loginRepo;
        public AdminLoginServices()
        {
            loginRepo = new AdminLoginRepository();
        }

        public int AdminLoginValidation(string username, string password)
        {
            return loginRepo.Validation(new Admin() { Email = username, Password = password });
        }
    }
}
