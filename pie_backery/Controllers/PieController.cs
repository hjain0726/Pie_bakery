﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pie_backery.Models;
using pie_backery.ViewModels;

namespace pie_backery.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {   
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Cheese cakes";
         
            return View(piesListViewModel);
        }

        public IActionResult longDescrip(string id)
        {
            //longDescripViewModel longDescrip = new longDescripViewModel();
            //longDescrip.pie=pieObj;
            //return View(longDescrip);
            return View(_pieRepository.GetPieById(id));
        }
    }
}