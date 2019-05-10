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

    [HttpPost("/Stylist/{id}/Replace")]
    public ActionResult ReplaceIt(int id, bool change, string drop)
    {
        Stylist theStylist = Stylist.Find(id);
        if(change == true)
        {
          theStylist.SetScissorsName(drop);
          string scisName = theStylist.GetScissorsName();

          if(scisName.Contains("Magic") == true)
          {
            theStylist.SetScissors(10);
          }else if(scisName.Contains("Diamond")  == true)
          {
            theStylist.SetScissors(5);
          }else if(scisName.Contains("Gold")  == true)
          {
            theStylist.SetScissors(4);
          }else if(scisName.Contains("Silver")  == true)
          {
            theStylist.SetScissors(3);
          }else if(scisName.Contains("Steel")  == true)
          {
            theStylist.SetScissors(2);
          }
          if(scisName.Contains("Strength")  == true)
          {
            theStylist.SetScissors(theStylist.GetScissors()*2);
          }else if(scisName.Contains("Fragility")  == true)
          {
            theStylist.SetScissors(theStylist.GetScissors()/2);
          }
        }
        theStylist.Update("scissors_name",theStylist.GetScissorsName());
        theStylist.Update("scissors",theStylist.GetScissors().ToString());
        return View("Show",theStylist);
    }

    [HttpGet("/Stylist/{id}")]
    public ActionResult Show(int id)
    {
      Stylist theStylist = Stylist.Find(id);
      return View(theStylist);
    }

    [HttpPost("/Stylist")]
    public ActionResult New(string name, string description)
    {
        Stylist addStylist = new Stylist(name, description);
        addStylist.Save();
        return RedirectToAction("Index");
    }

    [HttpPost("/Client")]
    public ActionResult Add(string name, string stylist)
    {
        Client addClient = new Client(name, int.Parse(stylist));
        addClient.Save();
        return RedirectToAction("Index");
    }

  }
}
