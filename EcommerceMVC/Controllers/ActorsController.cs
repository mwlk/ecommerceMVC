﻿using EcommerceMVC.Data;
using EcommerceMVC.Data.Services;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service;

        public ActorsController(IActorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();

            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Profile, FullName, Bio")] Actor model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _service.Add(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
