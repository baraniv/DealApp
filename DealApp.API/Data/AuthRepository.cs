using System;
using System.Linq;
using System.Threading.Tasks;
using DealApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DealApp.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;

        }



        // LOGIN
        public async Task<User> Login(string username, string password)
        {
            // find the matching user in the db and set to a variable(user)..
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == username);
             if(user == null)
             return null;

             if(!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
             return null;

             return user;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                // computing the passwordHash of the password..
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                // comparing each bytes of the hashedpassword..
                for(int i=0; i<computedHash.Length; i++)
                {
                    if(computedHash[i] != passwordHash[i])
                    return false;
                }
            }
            return true;
        }




        // REGISTER
        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            // setting values of user with values computed with CreatePasswordHash method..
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            // saving the user to the db..
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }


        

        // USEREXISTANCE
        public async Task<bool> UserExists(string username)
        {
            if(await _context.Users.AnyAsync(x => x.Username == username))
            return true;

            return false;
        }
    }
}