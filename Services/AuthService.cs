namespace AuthApp.Services
{
    using System;
    using System.Collections.Generic;
    using AuthApp.Models;  // Import User model

    public class AuthService
    {
        private List<User> users = new List<User>();

        public void SignUp(string email, string password)
        {
            if (users.Exists(u => u.Email == email))
            {
                Console.WriteLine("User already exists! Try a different email.");
                return;
            }
            users.Add(new User(email, password));
            Console.WriteLine("Sign-up successful!");
        }

        public bool SignIn(string email, string password)
        {
            var user = users.Find(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                Console.WriteLine("Sign-in successful! Welcome " + email);
                return true;
            }
            else
            {
                Console.WriteLine("Invalid email or password.");
                return false;
            }
        }
    }
}
