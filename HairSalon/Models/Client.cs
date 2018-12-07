using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;
using HairSalon;

namespace HairSalon.Models
{
  public class Client
  {
    private string _clientName;
    private string _clientPhone;
    private int _stylistId;
    private int _clientId;

    public Client (string clientName, string clientPhone, int stylistId, int id = 0)
    {
      _clientName = clientName;
      _clientPhone = clientPhone;
      _stylistId = stylistId;
      _clientId = id;
    }

    public string GetClientName()
    {
      return _clientName;
    }

    public void SetClientName(string newClientName)
    {

    }


  }
}
