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

    [TestMethod]
    public void SetClientName_SetClientName_String()
    {
      //Arrange
      string clientName = "test client";
      Client testClient = new Client(clientName, "test-phone", 1);

      //Act
      string newClientName = "test client 2";
      testClient.SetClientName(newClientName);
      string resultName = testClient.GetClientName();

      //Assert
      Assert.AreEqual(newClientName, resultName);
    }

    [TestMethod]
    public void GetClientPhone_ReturnsClientPhoneNumber_String()
    {
      //Arrange
      string clientPhone = "503-XXX-XXXX";
      Client testClient = new Client("testname", clientPhone, 1);

      //Act
      string resultPhone = testClient.GetClientPhone();

      //Assert
      Assert.AreEqual(clientPhone, resultPhone);
    }

    [TestMethod]
    public void SetClientPhone_SetClientPhone_String()
    {
      //Arrange
      string clientPhone = "503-XXX-XXXX";
      Client testClient = new Client("testname", clientPhone, 1);

      //Act
      string newClientPhone = "949-XXX-XXXX";
      testClient.SetClientPhone(newClientPhone);
      string resultPhone = testClient.GetClientPhone();

      //Assert
      Assert.AreEqual(newClientPhone, resultPhone);
    }

    [TestMethod]
    public void GetStylistId_ReturnsStylistId_Integer()
    {
      //Arrange
      int stylistId = 1;
      Client testClient = new Client("testname", "503-XXX-XXXX", stylistId);

      //Act
      int resultStylistId = testClient.GetStylistId();

      //Assert
      Assert.AreEqual(stylistId, resultStylistId);
    }

    // [TestMethod]
    // public void Equals_ReturnsTrueIfNameAndPhoneAreSame_Client()
    // {
    //   // Arrange, Act
    //   Client testClient1 = new Client("testname", "503-XXX-XXXX", 1);
    //   Client testClient2 = new Client("testname", "503-XXX-XXXX", 1);
    //
    //   // Assert
    //   Assert.AreEqual(testClient1, testClient2);
    // }

    [TestMethod]
    public void GetAll_ReturnsEmptyClientList_ClientList()
    {
      //Arrange
      List<Client> newList = new List<Client> { };

      //Act
      List<Client> result = Client.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }



  }
}
