using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {

    [HttpGet("/Client/New")]
    public ActionResult New()
    {   List<Stylist> allStylists = Stylist.GetAll();
        return View(allStylists);
    }

    [HttpGet("/Client/{id}")]
    public ActionResult Show(int id)
    {   Client theClient = Client.Find(id);
        return View(theClient);
    }



    [HttpPost("/Client/{id}")]
    public ActionResult Change(int id, string stylist)
    {
        Client theClient = Client.Find(id);
        theClient.Update("stylist", stylist);
        theClient = Client.Find(id);
        return View("Show",theClient);
    }
  }
}
