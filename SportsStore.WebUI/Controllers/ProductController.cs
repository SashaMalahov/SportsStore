using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;
            return View(_repository.Products.OrderBy(p=>p.ProductID).ToPagedList(pageNumber, PageSize));
        }
    }
}