using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using HairSalon.Controllers;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistsControllerTest : IDisposable
  {

    public void Dispose()
    {
      Stylist.ClearAll();
    }

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
      ActionResult index = controller.Index();

      //Assert
      Assert.IsInstanceOfType(index, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_StylistList()
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

    [TestMethod]
    public void Create_ReturnsCorrectView_True()
    {
      //Arrange
      StylistsController controller = new StylistsController();

      //Act
      ActionResult create = controller.Create("test name1");

      //Assert
      Assert.IsInstanceOfType(create, typeof(RedirectToActionResult));
    }

    // [TestMethod]
    // public void Create_HasCorrectModelType_StylistList()
    // {
    //   //Arrange
    //   ViewResult create = new StylistsController().Create("test name1") as ViewResult;
    //
    //   //Act
    //   var result = create.ViewData.Model;
    //
    //   //Assert
    //   Assert.IsInstanceOfType(result, typeof(List<Stylist>));
    // }

    [TestMethod]
    public void Create_ReturnsCorrectActionName_True()
    {
      //Arrange
      StylistsController controller = new StylistsController();
      RedirectToActionResult index = controller.Create("test name1") as RedirectToActionResult;

      //Act
      var result = index.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }

    [TestMethod]
    public void Show_ReturnsCorrectView_True()
    {
      //Arrange
      StylistsController controller = new StylistsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();
      Client testClient = new Client("test client1", "503-XXX-XXXX", testStylist.GetId());
      testClient.Save();

      //Act
      ActionResult show = controller.Show(testStylist.GetId());

      //Assert
      Assert.IsInstanceOfType(show, typeof(ViewResult));
    }

    [TestMethod]
    public void Show_HasCorrectModelType_Dictionary()
    {
      //Arrange
      StylistsController controller = new StylistsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();
      Client testClient = new Client("test client1", "503-XXX-XXXX", testStylist.GetId());
      testClient.Save();
      ViewResult showView = controller.Show(testStylist.GetId()) as ViewResult;

      //Act
      var result = showView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
    }

    [TestMethod]
    public void Edit_ReturnsCorrectView_True()
    {
      //Arrange
      StylistsController controller = new StylistsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();

      //Act
      ActionResult editView = controller.Edit(testStylist.GetId());

      //Assert
      Assert.IsInstanceOfType(editView, typeof(ViewResult));
    }

    [TestMethod]
    public void Edit_HasCorrectModelType_Stylist()
    {
      //Arrange
      StylistsController controller = new StylistsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();
      ViewResult editView = controller.Edit(testStylist.GetId()) as ViewResult;

      //Act
      var result = editView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(Stylist));
    }

    [TestMethod]
    public void Update_ReturnsCorrectView_True()
    {
      //Arrange
      StylistsController controller = new StylistsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();

      //Act
      ActionResult updateView = controller.Update(testStylist.GetId(), "test stylist2");

      //Assert
      Assert.IsInstanceOfType(updateView, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Update_ReturnsCorrectActionName_True()
    {
      //Arrange
      StylistsController controller = new StylistsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();
      RedirectToActionResult indexView = controller.Update( testStylist.GetId(), "test stylist2") as RedirectToActionResult;

      //Act
      var result = indexView.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }

    [TestMethod]
    public void Delete_ReturnsCorrectView_True()
    {
      //Arrange
      StylistsController controller = new StylistsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();

      //Act
      ActionResult deleteView = controller.Delete(testStylist.GetId());

      //Assert
      Assert.IsInstanceOfType(deleteView, typeof(RedirectToActionResult));
    }
    
    [TestMethod]
    public void Delete_ReturnsCorrectActionName_True()
    {
      //Arrange
      StylistsController controller = new StylistsController();
      Stylist testStylist = new Stylist("test stylist1");
      testStylist.Save();
      RedirectToActionResult indexView = controller.Delete( testStylist.GetId()) as RedirectToActionResult;

      //Act
      var result = indexView.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }

  }
}
