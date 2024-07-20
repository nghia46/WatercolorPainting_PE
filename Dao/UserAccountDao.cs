using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class UserAccountdao
    {
        private readonly WatercolorsPainting2024DbContext _context;
        public UserAccountdao()
        {
            _context = new WatercolorsPainting2024DbContext();
        }

        public async Task<UserAccount> Login(string email, string password)
        {
            return await _context.UserAccounts.FirstOrDefaultAsync(u => u.UserEmail == email && u.UserPassword == password);
        }
    }
}
