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
      return _name;
    }

    public int GetId()
    {
      return 0;
    }

    public override bool Equals(System.Object otherStylist)
    {
      if(!(otherStylist is Stylist))
      {
        return false;
      }
      else
      {
        Stylist newStylist = (Stylist) otherStylist;
        bool nameEquality = this.GetName().Equals(newStylist.GetName());
        return nameEquality;
      }
    }

  }
}
