using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_covid_19.Interfaces;
using team_covid_19.Entities;
using team_covid_19.Repository;

namespace team_covid_19.Services
{
    public class UserService
    {
        IRepository<User> repo;
        public UserService()
        {
            this.repo = new UserRepository();
        }
        public List<User> GetAllUser()
        {
            return repo.GetAll();
        }
        public List<User> GetUserById(int id)
        {
            var data = repo.Get(id);
            User user = new User();
            user.UserId = data.UserId;
            user.FirstName = data.FirstName;
            user.LastName = data.LastName;
            user.DOB = data.DOB;
            user.Gender = data.Gender;
            user.PhoneNo = data.PhoneNo;
            user.Address = data.Address;
            user.Email = data.Email;
            //user.UserType = data.UserType;
            List<User> list = new List<User>();
            list.Add(user);
            return list;
        }
        public int AddUser(int UserId,string FirstName,string LastName,string DOB,string Gender,string PhoneNo,string Address,string Email)
        {
            
            int result = repo.Insert(new User() { FirstName = FirstName, LastName = LastName, DOB = DOB, Gender = Gender });
            return result;
        }

        public int EditUser(int UserId, string FirstNam, string LastNam, string DOB1, string PhoneNo1)
        {

            int result = repo.Update(new User() { FirstName = FirstNam, LastName = LastNam, DOB = DOB1,  PhoneNo = PhoneNo1 });
            return result;
        }
        public int RemoveUser(int UserId)
        {
            int result = repo.Delete(UserId);
            return result;
        }


       
    }
}
