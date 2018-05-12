using System;
using System.Linq;
using CoreMVC3.Data;
using CoreMVC3.Services;
using CoreMVC3.ViewModels;
using Microsoft.AspNetCore.Mvc;

public class AppController : Controller {

public readonly IMailService _mailService;
public readonly DutchContext _context;
    public AppController(IMailService mailService, DutchContext context)
    {
        _mailService = mailService;
        _context = context;
    }

    public IActionResult Shop() {
        // var results = _context.Products.ToList();

        var results = from p in _context.Products
        orderby p.Category
        select p;

        return View(results.ToList());
    }

    public IActionResult Index () {
        // throw new InvalidOperationException("bad things happend");
        return View ();
    }
    public IActionResult About () {
        ViewBag.Title = "About me";
        return View ();
    }

    [HttpGet ("contact TCSW")]
    public IActionResult Contact () {
        ViewBag.Title = "Contact us";

        // throw new InvalidOperationException ("bad things happend!!");
        return View ();
    }

    [HttpPost ("contact TCSW")]
    public IActionResult Contact (ContactViewModel model) {
        ViewBag.Title = "Contact us";
        if (ModelState.IsValid) {
            //TODO: send email
            _mailService.SendMessage("tom.god@gmail.com", model.Subject, $"Form: {model.Name} - {model.Email}, Message: {model.Message}");

            ViewBag.UserMessage = "Mail sent. Robbie!";
            ModelState.Clear();
        } 

        return View();
    }

    // public IActionResult Error () {
    //     return View ();
    // }
}