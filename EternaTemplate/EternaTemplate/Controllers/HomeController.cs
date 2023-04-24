using System.Collections.Generic;
using System.Linq;
using EternaTemplate.Data_Access;
using EternaTemplate.Models;
using EternaTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaTemplate.Controllers
{
	public class HomeController:Controller
	{
        private readonly DataContext _context;

        public HomeController(DataContext context) {
			_context=context;

		}


		public ActionResult Index() { 
			//HomeModel homeModel = new HomeModel();
			//homeModel.Features = Data.features;
			//homeModel.Services = Data.services;
	         HomeModel model = new HomeModel()
			 {
				 Features =_context.Feature.ToList(),
				 Services=_context.Service.ToList(),
				 Sliders=_context.Slider.ToList(),
			 };
		

			return View(model);
		}	
		public ActionResult About()
		{
			return View();
		}
		public ActionResult Contact()
		{
			return View();
		}
   //     public ActionResult Datas()
   //     {
   //         List<Service> services = Data.services.ToList();
			//List<Feature> features = Data.features.ToList();
			//_context.Feature.AddRange(features);
   //         _context.Service.AddRange(services);
   //         _context.SaveChanges();

   //         return RedirectToAction("Index");
   //     }
    }
}
