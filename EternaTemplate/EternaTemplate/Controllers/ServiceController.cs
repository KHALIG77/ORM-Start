using System.Collections.Generic;
using System.Linq;
using EternaTemplate.Data_Access;
using EternaTemplate.Models;
using EternaTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaTemplate.Controllers
{
	public class ServiceController:Controller
	{
        private readonly DataContext _context;

        public ServiceController(DataContext context) {
			_context = context;
		}
		public ActionResult Index()
		{
			//ServiceModel servicemodel = new ServiceModel()
			//{
			//	Services = Data.services
			//};
			List<Service> services = _context.Service.ToList();
			return View(services);
		}
		public ActionResult Detail(int value) {

			//Service da = Data.services.Find(x =>x.Id==value
			Service service = _context.Service.FirstOrDefault(x => x.Id == value);
            if (service != null)
			{
                return View(service);
            }
			else
			{
                return View("Error");
            }
			
			
        }

		
	}
}
