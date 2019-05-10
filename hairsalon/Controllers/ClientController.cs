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
  }
}
