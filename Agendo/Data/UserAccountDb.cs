using Agendo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendo.Data
{
    public static class UserAccountDb
    {
        /// <summary>
        /// Add UserAccounts to database. Return user with ID populated.
        /// </summary>
        /// <param name="context">db context class</param>
        /// <param name="user">user account being added</param>
        /// <returns></returns>
        public async static Task<UserAccount> Add(AgendoContext context, UserAccount user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return user;
        }

        
        /// <summary>
        /// Checks if credentials are found in the database.
        /// The matching user is returned for valid credentials.
        /// Null is returned if there are no matches.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async static Task<UserAccount> IsLoginValid(LoginViewModel model, AgendoContext context)
        {
            return await (from m in context.Users
                          where (m.UserName == model.UsernameOrEmail || m.EmailAddress == model.UsernameOrEmail)
                                                      && m.Password == model.Password
                          select m).SingleOrDefaultAsync(); // finds object that matches.
        }
    }
}
