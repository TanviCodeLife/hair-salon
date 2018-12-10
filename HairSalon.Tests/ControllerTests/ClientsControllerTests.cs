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

    [TestMethod]
    public void New_HasCorrectModelType_Stylist()
    {
      //Arrange
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();
      ViewResult newView = new ClientsController().New(testStylist.GetId()) as ViewResult;

      //Act
      var result = newView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(Stylist));
    }

    [TestMethod]
    public void Show_ReturnsCorrectView_True()
    {
      //Arrange
      ClientsController controller = new ClientsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();
      int stylistId = testStylist.GetId();
      Client testClient = new Client("test client1", "503-XXX-XXXX", testStylist.GetId());
      testClient.Save();

      //Act
      ActionResult showView = controller.Show(stylistId, testClient.GetClientId());

      //Assert
      Assert.IsInstanceOfType(showView, typeof(ViewResult));
    }

    [TestMethod]
    public void Show_HasCorrectModelType_Dictionary()
    {
      //Arrange
      ClientsController controller = new ClientsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();
      Client testClient = new Client("test client1", "503-XXX-XXXX", testStylist.GetId());
      testClient.Save();
      int stylistId = testStylist.GetId();
      ViewResult showView = controller.Show(stylistId, testClient.GetClientId()) as ViewResult;

      //Act
      var result = showView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
    }

    [TestMethod]
    public void Edit_ReturnsCorrectView_True()
    {
      //Arrange
      ClientsController controller = new ClientsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();
      Client testClient = new Client("test client1", "503-XXX-XXXX", testStylist.GetId());
      testClient.Save();

      //Act
      ActionResult editView = controller.Edit(testStylist.GetId(), testClient.GetClientId());

      //Assert
      Assert.IsInstanceOfType(editView, typeof(ViewResult));
    }

    [TestMethod]
    public void Edit_HasCorrectModelType_Dictionary()
    {
      //Arrange
      ClientsController controller = new ClientsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();
      Client testClient = new Client("test client1", "503-XXX-XXXX", testStylist.GetId());
      testClient.Save();
      ViewResult editView = controller.Edit(testStylist.GetId(), testClient.GetClientId()) as ViewResult;

      //Act
      var result = editView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
    }

  }
}
