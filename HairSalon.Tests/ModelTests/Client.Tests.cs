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
      Client newClient = new Client("test", "test-phone", 1);
      Assert.AreEqual(typeof(Client), newClient.GetType());
    }

    [TestMethod]
    public void GetClientName_ReturnsClient_String()
    {
      //Arrange
      string clientName = "test client";
      Client testClient = new Client(clientName, "test-phone", 1);

      //Act
      string resultName = testClient.GetClientName();

      //Assert
      Assert.AreEqual(clientName, resultName);
    }


  }
}
