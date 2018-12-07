using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest
  {
    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=tanvi_garg_test;";
    }

    [TestMethod]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
    {
      Client newClient = new Client("test", "test-name", 1);
      Assert.AreEqual(typeof(Client), newClient.GetType());
    }


  }
}
