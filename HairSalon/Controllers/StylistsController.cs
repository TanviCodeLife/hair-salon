using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    [HttpGet("/stylists")]
    public ActionResult Index()
    {
      List<Stylist> allStylists = Stylist.GetAll();
      return View(allStylists);
    }

    [HttpGet("/stylists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/stylists")]
    public ActionResult Create(string stylistName)
    {
      Stylist newStylist = new Stylist(stylistName);
      newStylist.Save();
      List<Stylist> allStylists = Stylist.GetAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/stylists/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist selectedStylist = Stylist.Find(id);
      List<Client> stylistClients = selectedStylist.GetClients();
      model.Add("stylist", selectedStylist);
      model.Add("clients", stylistClients);
      return View(model);
    }

    [HttpGet("/stylists/{id}/edit")]
    public ActionResult Edit(int id)
    {
      Stylist newStylist = Stylist.Find(id);
      return View(newStylist);
    }

    [HttpPost("/stylists/{id}/update")]
    public ActionResult Update(int id, string name)
    {
      Stylist newStylist = Stylist.Find(id);
      newStylist.Edit(name);
      return RedirectToAction("Index");
    }

    [HttpPost("/stylists/{id}/delete")]
    public ActionResult Delete(int id)
    {
      Stylist stylist = Stylist.Find(id);
      stylist.Delete();
      return RedirectToAction("Index");
    }

    //Http Post Create for Clients used here to reuse stylists controller Show view
    [HttpPost("/stylists/{stylistId}/clients")]
    public ActionResult Create(int stylistId, string clientName, string clientPhone)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist foundStylist = Stylist.Find(stylistId);
      Client newClient = new Client(clientName, clientPhone, stylistId);
      newClient.Save();
      List<Client> stylistClients = foundStylist.GetClients();
      model.Add("stylist", foundStylist);
      model.Add("clients", stylistClients);
      return View("Show", model);
    }

  }

}
