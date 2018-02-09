using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home()
    {
      return View();
    }
  }
}
