using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembership.Data
{
    public interface IRegister
    {
        bool Register(string[] fields);
        bool EmailExists(string emailAddress);
    }
}
