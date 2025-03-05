using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;
using GraphQLWebAPI.Data;
using GraphQLWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace GraphQLWebAPI.Controllers
{
   
    public class UserController : GraphController
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [QueryRoot("user")]
        public async Task<User> GetUser(int Id)
        {
            return await _context.Users.Include(u => u.Posts).FirstOrDefaultAsync(u=>u.Id == Id);
        }
    }
}
