﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UserApi.project.Data;
using UserApi.project.Models;
using UserApi.project.Repository;

namespace UserApi.project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(ILogger<UserController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        // GET: api/<UserController>/GetAllUsers
        [HttpGet]

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _unitOfWork.userRepository.GetAllUsers();
        }

        // GET: api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<User> GetUserById(int id)
        {
            
            var user = await _unitOfWork.userRepository.GetUserById(id);

            return user;
        }

        
        [HttpGet("StateID")]
        public List<City> GetCityList(int StateID)
        {
            var list = _unitOfWork.userRepository.GetAllCities(StateID);
            ViewBag.CityList = new SelectList(list, "CityID", "CityName");
            return list;
        }

        // POST api/<UserController>/AddUser
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost] 
        public async Task<IActionResult> AddUser([Bind("Name,Address,Email,Phone,State,City,Pincode")] User model)
        {
            User user = new User();
            user.Name = model.Name; ;
            user.Address = model.Address;
            user.Email = model.Email;
            user.Phone = model.Phone;
            user.State = model.State;
            user.City = model.City;
            user.Pincode = model.Pincode;
            await  _unitOfWork.userRepository.AddUserAsync(user);
            return RedirectToAction("GetAllUsers");
        }


        // POST: User/UpdateUser/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateUser(int id, [Bind("Name,Address,Email,Phone,State,City,Pincode")] User user)
        {
            if (id != user.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _unitOfWork.userRepository.UpdateUser(user);
                    _unitOfWork.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(GetAllUsers));
            }
            return View(user);
        }


        // DELETE api/<UserController>/5
        [HttpDelete("id")]       
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                await _unitOfWork.userRepository.DeleteUser(id);
                _unitOfWork.Commit();

                return RedirectToAction(nameof(GetAllUsers));
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                return RedirectToAction(nameof(GetAllUsers));
            }
        }



        private bool UserExists(int id)
        {
            var user = _unitOfWork.userRepository.GetUserById(id);

            if (user != null)
                return true;
            else return false;
        }
    }
}
