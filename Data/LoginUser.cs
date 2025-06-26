using ClubMembership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClubMembership.Data
{
    public class LoginUser : ILogin

    {

        public User Login(string emailAdress, string password)

        {
            User user = null; //null because it could be not found

            using (var dbContext= new ClubMembershipDbContext()) //disposable with (using)
            {
                user  = dbContext.Users.FirstOrDefault(u => u.EmailAddress.Trim().ToLower()== emailAdress.Trim().ToLower() && u.Password.Equals(password)) ;

            }
            return user;
        }
    }
}
