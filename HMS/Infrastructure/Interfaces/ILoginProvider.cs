using HMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure.Interfaces
{
    public interface ILoginProvider
    {
         string getEmpId(string user);
         bool registerEmployee(RegisterViewModel user);
         string CreatePasswordHash(string password, string salt);
    }
}
