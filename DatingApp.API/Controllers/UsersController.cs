using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IDatingRepository _datingRepo;

        private readonly IMapper _mapper;
        public UsersController(IDatingRepository datingRepo, IMapper mapper)
        {
            _datingRepo = datingRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _datingRepo.GetUsers();

            var usersToReturn = _mapper.Map<IEnumerable<UserForListDTOcs>>(users);

            return Ok(usersToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _datingRepo.GetUser(id);

            var userToReturn =  _mapper.Map<UserForDetailedDTO>(user);

            return Ok(userToReturn);
        }
    }
}
