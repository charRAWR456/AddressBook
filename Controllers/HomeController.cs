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
    [HttpGet("/addressList")]
    public ActionResult AddressList()
    {
      if (Contact.GetAll() != null)
      {
        List<Contact> allContacts = Contact.GetAll();
        return View("AddressList", allContacts);
      }
      return View();
    }
    [HttpGet("/addcontact")]
    public ActionResult AddContact()
    {
      return View();
    }

    [HttpPost("/addresslist")]
    public ActionResult CreateAddressList()
    {
      string contactName = Request.Form[("contact-name")];
      string contactAddress = Request.Form[("contact-address")];
      string contactPhoneNumber = Request.Form[("contact-phone-number")];
      Contact newContact = new Contact(contactName, contactAddress, contactPhoneNumber);
      newContact.Save();

      List<Contact> allContacts = Contact.GetAll();
      return View("AddressList", allContacts);
    }
    [HttpPost("/addresslist/delete")]
         public ActionResult DeleteAll()
         {
             Contact.ClearAll();
             return View();
         }

    // [httpGet("/{id}")]
    // public ActionResult ContactDetails(int id)
    // {
    //   Contact.found contact = Contact.Find(id);
    //   return View("FoundContact");
    // }
  }
}
