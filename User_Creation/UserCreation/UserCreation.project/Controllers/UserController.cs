using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UserCreation.project.Data;
using UserCreation.project.Models;
using UserCreation.project.Repository;

namespace UserCreation.project.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(ILogger<UserController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        // GET: User
        public async Task<IActionResult> GetAllUsers()
        {
            return View(await _unitOfWork.userRepository.GetAllUsers());
        }

        // GET: User/Details/5
        public async Task<IActionResult> GetUserById(int id)
        {
            
            var user = await _unitOfWork.userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        public async Task<IActionResult> AddUSerAsync()
        {
            
           // State st = new State();
            //List<State> States = await _unitOfWork.userRepository.GetAllStates();
            ViewBag.States = new SelectList(await _unitOfWork.userRepository.GetAllStates(), "StateID", "StateName");
          
        
            return View();
        }

        


        // GET: User/Edit/5
        public async Task<IActionResult> UpdateUser(int id)
        {
            try
            {
                var user = await _unitOfWork.userRepository.GetUserById(id);
                //_unitOfWork.Commit();
                return View(user);
            }
            catch (Exception e)
            {
                //_unitOfWork.Rollback();
                throw e;
            }
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
       
        private bool UserExists(int id)
        {
            var user = _unitOfWork.userRepository.GetUserById(id);

            if (user != null)
                return true;
            else return false;
        }
    }
}
