using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class AddressBook
  {
    private string _name;
    private string _address;
    private int _id;

    private static List<ContactList> _contactList = new List<ContactList>{};

    public void Contact(string contactName, string contactAddress)
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
    public void GetContactAddress(string newContactAddress)
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
    public static List<ContactList> GetContactList()
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
