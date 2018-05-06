using System;
using CoreMVC3.ViewModels;
using Microsoft.AspNetCore.Mvc;



public class AppController : Controller {
    public IActionResult Index () {
        // throw new InvalidOperationException("bad things happend");
        return View ();
    }
    public IActionResult About () {
        ViewBag.Title = "About us";
        return View ();
    }

    [HttpGet ("contact TCSW")]
    public IActionResult Contact () {
        ViewBag.Title = "Contact us";

        // throw new InvalidOperationException ("bad things happend!!");
        return View ();
    }

[HttpPost("contact TCSW")]
    public IActionResult Contact (ContactViewModel model) {
        ViewBag.Title = "Contact us";

        return View ();
    }

    // public IActionResult Error () {
    //     return View ();
    // }
}