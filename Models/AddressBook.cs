using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _address;
    private int _id;
    private static List<Contact> _contactList = new List<Contact>{};

    public Contact(string contactName, string contactAddress)
    {
      _name = contactName;
      _address = contactAddress;
    }
    public string GetContactName()
    {
      return _name;
    }
    public void SetContactName(string newContactName)
    {
      _name = newContactName;
    }
    public string GetContactAddress()
    {
      return _address;
    }
    public void SetContactAddress(string newContactAddress)
    {
      _address = newContactAddress;
    }
    public int GetID()
    {
      return _id;
    }
    public void Save()
    {
      _contactList.Add(this);
      _id = _contactList.Count;
    }
    public static List<Contact> GetAll()
    {
      return _contactList;
    }
    public static void ClearAll()
    {
      _contactList.Clear();
    }

    public static Contact Find(int id)
    {
      return _contactList[id -1];

    }
  }
}
