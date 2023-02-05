using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.ErrorsHandlers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using core.Entities.Identity;
using core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using API.ApiErrorMiddleWares;
using AutoMapper;
using API.DTOs;

namespace API.Controllers
{
    public class UserController : ApiControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        public UserController(UserManager<AppUser> userManager,
        
        
         SignInManager<AppUser> signInManager, ITokenService tokenService, IMapper mapper)
        {
            _mapper = mapper;
            _tokenService = tokenService;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        // Use to get a new user
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<UserDTO>> GetCurrentUser(){

            var user = await _userManager.FindByEmailByClaimPrinciple(HttpContext.User);

            return new UserDTO {

                nickName = user.NickName,
                email = user.Email,
                token =  _tokenService.createToken(user)
                

            };

            
        }

        [Authorize]
        [HttpGet("address")]
        public async Task<ActionResult<AddressDTO>> GetAddress(){

            var user = await _userManager.FindUserByClaimPrincipleWIthAddress(HttpContext.User);

            return _mapper.Map<Address,AddressDTO>(user.address);
            }

        [Authorize]
        [HttpPut("address")]
        public async Task<ActionResult<AddressDTO>> UpdateAddress(AddressDTO address){

            var user = await _userManager.FindUserByClaimPrincipleWIthAddress(HttpContext.User);

            user.address = _mapper.Map<AddressDTO,Address>(address);

            var result = await _userManager.UpdateAsync(user);

            if(!result.Succeeded) return Ok(_mapper.Map<Address,AddressDTO>(user.address));

            return BadRequest("Could not update user");
            }


        
        // Check if Email Exist
         [HttpGet("emailexist")]
        public async Task<ActionResult<bool>> CheckEmail([FromQuery] string email){
               
                return await _userManager.FindByEmailAsync(email)!=null;
        }

        // Use for login
         [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDTO){
                   
            var user = await _userManager.FindByEmailAsync(loginDTO.email);
           

            if(user == null) return Unauthorized(new Responses(401));

            var result = await  _signInManager.CheckPasswordSignInAsync(user,loginDTO.password,false);

            if(!result.Succeeded) return Unauthorized(new Responses(401));

            return new UserDTO {

                nickName = user.NickName,
                email = user.Email,
                token =  _tokenService.createToken(user)
                

            };

                 
        }
      
    //   Use to register a new customer
        [HttpPost("register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDTO registerDTO){

             var user = new AppUser{

                        NickName = registerDTO.nickName,
                        Email = registerDTO.email,
                        UserName = registerDTO.email
             };
                   
            var result = await _userManager.CreateAsync(user, registerDTO.password);
        
            if(!result.Succeeded) return Unauthorized(new Responses(401));

            return new UserDTO {

                nickName = user.NickName,
                email = user.Email,
                token = _tokenService.createToken(user)
                

            };

                 
        }


    }
}