using Agendo.Models;
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

        // TODO: Add IsLoginValid class here => need to have LoginViewModel added check Github.
    }
}
