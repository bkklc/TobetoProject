﻿using Business.Abstracts;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.UserRequests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateUserRequest createUserRequest)
        {
            var result = await _userService.Add(createUserRequest);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id, bool permanent)
        {
            var result = await _userService.Delete(Id, permanent);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetCourseById")]
        public async Task<IActionResult> Get(int Id)
        {
            var result = await _userService.GetUserById(Id);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateUserRequest updateUserRequest)
        {
            var result = await _userService.Update(updateUserRequest);
            return Ok(result);
        }
    }
}
