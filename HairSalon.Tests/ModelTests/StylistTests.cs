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
    public void GetName_ReturnsStylistame_String()
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
    public void Equals_ReturnsTrueIfStylistsAreTheSame_Category()
    {
      //Arrange, Act
      Stylist testStylist01 = new Stylist("test stylist1");
      Stylist testStylist02 = new Stylist("test stylist1");

      //Assert
      Assert.AreEqual(testStylist01, testStylist02);
    }




  }
}
