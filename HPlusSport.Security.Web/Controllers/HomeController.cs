using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPlusSport.Security.Web.Controllers;

/*Course: 		Web Programming 3
* Assessment: 	Milestone 3
* Created by: 	Eric Stoian - 2249612
* Date: 		14/11/2024
* Class Name: 	HomeController.cs
* Description: 	Shows the homeView, which is basically the first page you arrive on when starting up the app.
* Time Task:	1 hour 
*/
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
