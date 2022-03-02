using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers {
  public class ItemsController : Controller{
    [HttpGet("/items")]
    public ActionResult Index() {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }
    [HttpGet("/items/new")]
    public ActionResult CreateForm() {
      return View();
    }
    [HttpPost("/items")]
    public ActionResult Create(string description) {
      Item myItem = new Item(description);
      return RedirectToAction("Index");  //  tells the server to invoke the Index() route after the Create() route has been invoked
    }
    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }
  }
}