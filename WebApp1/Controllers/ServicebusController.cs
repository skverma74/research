using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharekloudApp.Models.ServiceBusModels;
namespace WebApp1.Controllers
{
    public class ServicebusController : Controller
    {
        public IActionResult MessageQueue(int id)
        {
            ViewData["Message"] = "Service Bus Message Queue Adder page.";
            MessageModel msg = new MessageModel();
            if (id == 10)
            {
                msg.Body = "Congrats! Message posted";
            }
            else
            {
                msg.Body = "Initial Message";
            }
            return View(msg);
        }

        [HttpPost]
        public ActionResult PostMessageToQueue(MessageModel model)
        {
            
            string msgText = model.Body;

            //TODO
            //Post this message to Service Bus


            //return Content("Message Posted");

            return RedirectToAction("MessageQueue", new { id = 10 });
        }
    }
}