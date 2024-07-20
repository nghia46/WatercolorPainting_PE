using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ITokenRepository
    {
        string GenerateAccessToken(string email, int role);
    }
}
