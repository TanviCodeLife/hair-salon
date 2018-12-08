using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HairSalon;

namespace HairSalon.Models
{
  public class Stylist
  {
    private string _name;
    private int _id;
    private List<Client> _clients;

    public Stylist(string stylistName, int id = 0)
    {
      _name = stylistName;
      _id = id;
      _clients = new List<Client>{};
    }

    public string GetName()
    {
      return "fail";
    }



  }
}
