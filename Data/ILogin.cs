using ClubMembership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembership.Data
{
    public  interface ILogin
    {
        public User Login(string emailAdress, string password);
    }
}
