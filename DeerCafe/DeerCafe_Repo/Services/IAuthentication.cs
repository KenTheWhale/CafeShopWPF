using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCafe_Repo.Services
{
    public interface IAuthentication
    {
        string Authenticate(string username, string password);
    }
}
