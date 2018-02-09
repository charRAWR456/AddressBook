using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Home()
    {
      return View();
    }
    [HttpGet("/addcontact")]
    public ActionResult AddContact()
    {
      return View();
    }
    [HttpPost("/addcontact")]
    public ActionResult AddContactForm()
    {
      string contactName = Request.Form[("contact-name")];
      string contactAddress = Request.Form[("contact-address")];
      Contact newContact = new Contact(contactName, contactAddress);
      newContact.Save();

      List<Contact> allContacts = Contact.GetAll();
      return View("AddressList", allContacts);
    }

    // [httpGet("/{id}")]
    // public ActionResult ContactDetails(int id)
    // {
    //   Contact found contact = Contact.Find(id);
    //   return View("FoundContact")
    // }
  }
}
