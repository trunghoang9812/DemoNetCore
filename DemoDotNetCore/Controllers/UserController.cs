using DemoDotNetCore.Domain.Entities;
using DemoDotNetCore.Infrastructor.IRepositories;
using DemoDotNetCore.RequestModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoDotNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        /// <summary>
        /// API Tạo người dùng
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("Create")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            var user = new User(request.Name, request.Gender, request.Age, request.Address);
            user = _userRepository.Create(user);
            _userRepository.SaveChange();
            return Ok(user);
        }
    }
}
