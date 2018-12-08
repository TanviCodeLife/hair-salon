using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest
  {
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
    public void Equals_ReturnsTrueIfStylistsAreTheSame_Category()
    {
      //Arrange, Act
      Stylist Stylist01 = new Stylist("Household chores");
      Stylist Stylist02 = new Stylist("Household chores");

      //Assert
      Assert.AreEqual(Stylist01, Stylist02);
    }

  }
}
