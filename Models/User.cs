// namespace AuthApp.Models  // Ensure this matches your project name
// {
//     public class User
//     {
//         public string Email { get; set; } = string.Empty;
//         public string Password { get; set; } = string.Empty;

//         public User(string email, string password)
//         {
//             Email = email;
//             Password = password;
//         }

//         public User() { }  // Parameterless constructor
//     }
// }


using System.ComponentModel.DataAnnotations;

namespace AuthApp.Models  // Ensure this matches your project name
{
    public class User
    {
        [Key]  // Defines 'Id' as the primary key
        public int Id { get; set; }  

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public User() { }  // Parameterless constructor
    }
}

// using System.ComponentModel.DataAnnotations;

// namespace AuthApp.Models  // Ensure this matches your project name
// {
//     public class User
//     {
//         [Key]  // Defines 'Id' as the primary key
//         public int Id { get; set; }  

//         [Required]
//         [EmailAddress]
//         public string Email { get; set; } = string.Empty;

//         [Required]
//         public string Password { get; set; } = string.Empty;

//         [Required]
//         public string UserName { get; set; } = string.Empty;  // Add this property

//         // Constructor with default UserName
//         public User(string email, string password, string userName = "DefaultUser")
//         {
//             Email = email;
//             Password = password;
//             UserName = userName;
//         }

//         public User() { }  // Parameterless constructor
//     }
// }
