﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Application.UseCases.User.Register;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        public IActionResult Register(RequestRegisterUserJson request)
        {
            try
            {
                var useCase = new RegisterUserUseCase();

                var result = useCase.Execute(request);

                return Created(string.Empty, result);
            }
            catch (Exception ex) 
            { 
            
            }
        }
    }
}
