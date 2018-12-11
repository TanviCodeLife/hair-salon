using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest : IDisposable
  {

    public void Dispose()
    {
      Stylist.ClearAll();
      Client.ClearAll();
    }

    public StylistTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=tanvi_garg_test;";
    }

    [TestMethod]
    public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
    {
      Stylist testStylist = new Stylist("test stylist");
      Assert.AreEqual(typeof(Stylist), testStylist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsStylistName_String()
    {
      //Arrange
      string name = "test stylist";
      Stylist newStylist = new Stylist(name);

      //Act
      string resultName = newStylist.GetName();

      //Assert
      Assert.AreEqual(name, resultName);
    }

    [TestMethod]
    public void GetId_ReturnsStylistId_String()
    {
      //Arrange
      int stylistId = 1;
      Stylist testStylist01 = new Stylist("test stylist1", 1);

      //Act
      int resultId = testStylist01.GetId();

      //Assert
      Assert.AreEqual(stylistId, resultId);
    }

    [TestMethod]
    public void Equals_ReturnsTrueIfStylistsAreTheSame_Stylist()
    {
      //Arrange, Act
      Stylist testStylist01 = new Stylist("test stylist1");
      Stylist testStylist02 = new Stylist("test stylist1");

      //Assert
      Assert.AreEqual(testStylist01, testStylist02);
    }

    [TestMethod]
    public void GetAll_StylistsEmptyAtFirst_List()
    {
      //Arrange, Act
      int result = Stylist.GetAll().Count;

      //Assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllStylistObjects_StylistList()
    {
      //Arrange
      Stylist testStylist01 = new Stylist("test stylist1");
      Stylist testStylist02 = new Stylist("test stylist2");
      testStylist01.Save();
      testStylist02.Save();
      List<Stylist> newStylistList = new List<Stylist> { testStylist01, testStylist02 };

      //Act
      List<Stylist> result = Stylist.GetAll();

      //Assert
      CollectionAssert.AreEqual(newStylistList, result);
    }

    [TestMethod]
    public void Save_SavesStylistToDatabase_StylistList()
    {
      //Arrange
      Stylist testStylist01 = new Stylist("test stylist1");
      testStylist01.Save();

      //Act
      List<Stylist> result = Stylist.GetAll();
      List<Stylist> testList = new List<Stylist>{testStylist01};

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void Find_ReturnsStylistInDatabase_Stylist()
    {
      //Arrange
      Stylist testStylist01 = new Stylist("test stylist1");
      testStylist01.Save();

      //Act
      Stylist foundStylist = Stylist.Find(testStylist01.GetId());

      //Assert
      Assert.AreEqual(testStylist01, foundStylist);
    }

    [TestMethod]
    public void Edit_UpdatesStylistInDatabase_StylistName()
    {
      //Arrange
      Stylist testStylist01 = new Stylist("test stylist1");
      testStylist01.Save();

      //Act
      string newName = "test stylist2";
      testStylist01.Edit(newName);
      string resultName = Stylist.Find(testStylist01.GetId()).GetName();

      //Assert
      Assert.AreEqual(newName, resultName);
    }

    [TestMethod]
    public void GetClients_RetrievesAllClientsWithStylist_ClientList()
    {
      //Arrange
      Stylist testStylist01 = new Stylist("test stylist1");
      testStylist01.Save();
      Client testClient1 = new Client("testname1", "503-XXX-XXXX", testStylist01.GetId());
      Client testClient2 = new Client("testname2", "949-XXX-XXXX", testStylist01.GetId());
      testClient1.Save();
      testClient2.Save();
      List<Client> testClientList = new List<Client> { testClient1, testClient2};

      //Act
      List<Client> resultClientList = testStylist01.GetClients();

      //Assert
      CollectionAssert.AreEqual(testClientList, resultClientList);
    }

    [TestMethod]
    public void Delete_DeletesStylistFromDatabase_StylistList()
    {
      //Arrange
      Stylist testStylist01 = new Stylist("test stylist1");
      Stylist testStylist02 = new Stylist("test stylist2");
      testStylist01.Save();
      testStylist02.Save();
      Client testClient = new Client("test client1", "503-XXX-XXX", testStylist01.GetId());
      testClient.Save();

      //Act
      testStylist01.Delete();
      List<Stylist> allStylists = Stylist.GetAll();
      List<Stylist> expectedList = new List<Stylist>{ testStylist02 };

      //Assert
      CollectionAssert.AreEqual(expectedList, allStylists);
    }

    [TestMethod]
    public void Delete_DeletesStylistFromClientDatabase_StylistList()
    {
      //Arrange
      Stylist testStylist01 = new Stylist("test stylist1");
      Stylist testStylist02 = new Stylist("test stylist2");
      testStylist01.Save();
      testStylist02.Save();
      Client testClient = new Client("test client1", "503-XXX-XXX", testStylist01.GetId());
      testClient.Save();

      //Act
      testStylist01.Delete();
      List<Stylist> allStylists = Stylist.GetAll();
      List<Stylist> expectedList = new List<Stylist>{ testStylist02 };
      Client foundClient = Client.Find(testClient.GetClientId());

      //Assert
      Assert.AreEqual(0, foundClient.GetStylistId());
    }

  }
}
