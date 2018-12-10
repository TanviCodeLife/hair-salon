using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientsControllerTest : IDisposable
  {
    public void Dispose()
    {
      Client.ClearAll();
      Stylist.ClearAll();
    }

    public ClientsControllerTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=tanvi_garg_test;";
    }

    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      ClientsController controller = new ClientsController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_ClientList()
    {
      //Arrange
      ViewResult index = new ClientsController().Index() as ViewResult;

      //Act
      var result = index.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Client>));
    }

    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      //Arrange
      ClientsController controller = new ClientsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();


      //Act
      ActionResult newView = controller.New(testStylist.GetId());

      //Assert
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

  }
}
