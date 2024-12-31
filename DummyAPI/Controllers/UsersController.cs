using DummyAPI.Models;
using DummyAPI.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DummyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService) =>
            _userService = userService;

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<List<DummyUser>> Get()
        {
            return _userService.Get();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<DummyUser> Get(int id)
        {
            return await _userService.GetAsync(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public async void Post([FromBody] DummyUser value)
        {
            await _userService.CreateAsync(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] DummyUser value)
        {
            await _userService.UpdateAsync(id, value);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _userService.RemoveAsync(id);
        }
    }
}
