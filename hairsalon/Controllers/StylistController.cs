using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {



    [HttpGet("/Stylist")]
    public ActionResult Index()
    {
        List<Stylist> allStylists = Stylist.GetAll();
        return View(allStylists);
    }

    [HttpGet("/Stylist/New")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/Stylist")]
    public ActionResult New(string name, string description)
    {
        Stylist addStylist = new Stylist(name, description);
        addStylist.Save();
        return RedirectToAction("Index");
    }



  }
}
