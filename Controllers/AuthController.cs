// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;

// namespace MyApp.Namespace
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class AuthController : ControllerBase
//     {
//     }
// }

// using Microsoft.AspNetCore.Mvc;

// namespace MyApp.Namespace
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class AuthController : ControllerBase
//     {
//         [HttpPost("register")]
//         public IActionResult Register([FromBody] UserDto userDto)
//         {
//             if (userDto.Username == "two@gmail.com" && userDto.Password == "Two@2002")
//             {
//                 return Ok(new { message = "User registered successfully" });
//             }
//             return BadRequest(new { message = "Invalid registration details" });
//         }

//         [HttpPost("login")]
//         public IActionResult Login([FromBody] UserDto userDto)
//         {
//             if (userDto.Username == "two@gmail.com" && userDto.Password == "Two@2002")
//             {
//                 return Ok(new { token = "mock-jwt-token" });
//             }
//             return Unauthorized(new { message = "Invalid username or password" });
//         }
//     }

//     public class UserDto
//     {
//         public string Username { get; set; }
//         public string Password { get; set; }
//     }
// }


using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody] UserDto userDto)
        {
            if (userDto.Username == "two@gmail.com" && userDto.Password == "Two@2002")
            {
                return Ok(new { message = "User registered successfully" });
            }
            return BadRequest(new { message = "Invalid registration details" });
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserDto userDto)
        {
            if (userDto.Username == "two@gmail.com" && userDto.Password == "Two@2002")
            {
                return Ok(new { token = "Login successfully" });
            }
            return Unauthorized(new { message = "Invalid username or password" });
        }
    }

    public class UserDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}


// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Authorization;
// using System.Threading.Tasks;
// using AuthApp.Models;  // Ensure this is present


// [Route("api/auth")]
// [ApiController]
// public class AuthController : ControllerBase
// {
//     private readonly UserManager<User> _userManager;
//     private readonly SignInManager<User> _signInManager;

//     public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
//     {
//         _userManager = userManager;
//         _signInManager = signInManager;
//     }

//     // Register a new user
//     [HttpPost("register")]
//     public async Task<IActionResult> Register([FromBody] RegisterModel model)
//     {
//         if (model == null || string.IsNullOrWhiteSpace(model.Username) || string.IsNullOrWhiteSpace(model.Password))
//         {
//             return BadRequest(new { message = "Username and password are required." });
//         }

//         var user = new User { UserName = model.Username, Email = model.Email };
//         var result = await _userManager.CreateAsync(user, model.Password);

//         if (!result.Succeeded)
//         {
//             return BadRequest(result.Errors);
//         }

//         return Ok(new { message = "User registered successfully!" });
//     }

//     // Login user
//     [HttpPost("login")]
//     public async Task<IActionResult> Login([FromBody] LoginModel model)
//     {
//         if (model == null || string.IsNullOrWhiteSpace(model.Username) || string.IsNullOrWhiteSpace(model.Password))
//         {
//             return BadRequest(new { message = "Username and password are required." });
//         }

//         var user = await _userManager.FindByNameAsync(model.Username);
//         if (user == null)
//         {
//             return Unauthorized(new { message = "Invalid username or password." });
//         }

//         var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);
//         if (!result.Succeeded)
//         {
//             return Unauthorized(new { message = "Invalid username or password." });
//         }

//         return Ok(new { message = "Login successful!" });
//     }

//     // Logout user
//     [Authorize]
//     [HttpPost("logout")]
//     public async Task<IActionResult> Logout()
//     {
//         await _signInManager.SignOutAsync();
//         return Ok(new { message = "Logout successful!" });
//     }
// }


// // Register model
// public class RegisterModel
// {
//     public string Username { get; set; } = string.Empty;
//     public string Email { get; set; } = string.Empty;
//     public string Password { get; set; } = string.Empty;
// }

// // Login model
// public class LoginModel
// {
//     public string Username { get; set; } = string.Empty;
//     public string Password { get; set; } = string.Empty;
// }