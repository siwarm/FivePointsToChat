using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatApp.Controllers
{
    public class ConversationController : Controller
    {
        // GET: Conversation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowConversation()
        {
            
            return PartialView("ShowConversation");
        }
        [HttpPost]
        public JsonResult ShowConversation(int IdReceiver)
        {
            string Msgs="Hello";
            return Json(new { success = true, Msgs }, JsonRequestBehavior.AllowGet);
        }
    }
}