using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;
using GraphQLWebAPI.Data;
using GraphQLWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Web.Http;

namespace GraphQLWebAPI.Controllers
{
   
    public class UserController : GraphController
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        //[Microsoft.AspNetCore.Mvc.Route("GetUser/{Id}")]
        //[Microsoft.AspNetCore.Mvc.HttpGet]
        [QueryRoot("user")]
        public async Task<User> GetUser(int Id)
        {
            try
            {
               
               return await _context.Users.Include(u => u.Posts).FirstOrDefaultAsync(u => u.Id == Id);
                
            }
            catch (ArgumentException ex)
            {
                // Log the exception or handle it as needed
                throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception(ex.Message);
            }

        }
    }
}
