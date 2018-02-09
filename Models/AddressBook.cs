using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phoneNumber;
    private int _id;
    private static List<Contact> _contactList = new List<Contact>{};

    public Contact(string contactName, string contactAddress, string contactPhoneNumber)
    {
      _name = contactName;
      _address = contactAddress;
      _phoneNumber = contactPhoneNumber;
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
    public string GetContactPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetContactPhoneNumber(string newContactPhoneNumber)
    {
      _phoneNumber = newContactPhoneNumber;
    }
    public int GetID()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _contactList;
    }
    public void Save()
    {
      _contactList.Add(this);
      _id = _contactList.Count;
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
