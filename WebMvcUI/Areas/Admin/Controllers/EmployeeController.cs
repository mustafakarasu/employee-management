﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvcUI.Models.Entities.Concrete;
using WebMvcUI.Models.Reposities.Abstract;

namespace WebMvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SiteManager")]
    public class EmployeeController : Controller
    {
        IEntityRepository<User> _userRepository;
        IEntityRepository<Role> _roleRepository;

        public EmployeeController(IEntityRepository<User> userRepository, IEntityRepository<Role> roleRepository)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public IActionResult Index()
        {
            var model = _userRepository.GetList(x => x.IsActive == true && x.RoleId == 3);
            return View(model);
        }
    }
}
