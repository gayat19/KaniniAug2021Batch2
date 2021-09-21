﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateMVCApplication.Models;
using TemplateMVCApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace TemplateMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepo<Employee> _repo;

        public EmployeeController(IRepo<Employee> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        public IActionResult Details(int id)
        {
            return View(_repo.Get(id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _repo.Add(employee);
            return RedirectToAction("Index");       
        }
        public IActionResult Edit(int id)
        {
            return View(_repo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(int id,Employee employee)
        {
            _repo.Update(employee);
            return RedirectToAction("Index");
        }
    }
}
