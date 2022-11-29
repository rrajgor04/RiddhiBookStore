using Microsoft.AspNetCore.Mvc;
using RiddhiBookStore.DataAccess.Data;
using Microsoft.Extensions.DependencyInjection;
using RiddhiBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;


namespace RiddhiBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion

    }
}
