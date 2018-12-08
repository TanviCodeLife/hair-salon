using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistsControllerTest
  {
    // public void Dispose()
    // {
    //   Stylist.DeleteAll();
    // }

    public StylistsControllerTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=tanvi_garg_test;";
    }

    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      StylistsController controller = new StylistsController();

      //Act
      ActionResult Index = controller.Index();

      //Assert
      Assert.IsInstanceOfType(Index, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_Account()
    {
      //Arrange
      ViewResult Index = new StylistsController().Index() as ViewResult;

      //Act
      var result = Index.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Stylist>));
    }

    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      //Arrange
      StylistsController controller = new StylistsController();

      //Act
      ActionResult New = controller.New();

      //Assert
      Assert.IsInstanceOfType(New, typeof(ViewResult));
    }

  }
}
