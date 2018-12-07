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
      _clientName = newClientName;
    }

    public string GetClientPhone()
    {
      return _clientPhone;
    }

    public void SetClientPhone(string newClientPhone)
    {
      _clientPhone = newClientPhone;
    }

    public int GetStylistId()
    {
      return _stylistId;
    }

    // public override bool Equals(System.Object otherClient)
    // {
    //   if (!(otherClient is Client))
    //   {
    //     return false;
    //   }
    //   else
    //   {
    //     Client newClient = (Client) otherClient;
    //     bool nameEquality = (this.GetClientName() == newClient.GetClientName());
    //     bool phoneEquality = this.GetClientPhone() == newClient.GetClientPhone();
    //     return (nameEquality && phoneEquality);
    //   }

      public static List<Client> GetAll()
      {
        List<Client> allClients = new List<Client> {};
        MySqlConnection conn = DB.Connection();
        conn.Open();
        MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM clients;";
        MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        while(rdr.Read())
        {
          int clientId = rdr.GetInt32(0);
          string clientName = rdr.GetString(1);
          string clientPhone = rdr.GetString(2);
          int stylistId = rdr.GetInt32(3);
          Client newClient = new Client(clientName, clientPhone, stylistId, clientId);
          allClients.Add(newClient);
        }
        conn.Close();
        if (conn != null)
        {
          conn.Dispose();
        }

        return allClients;
      }




    }
  }
