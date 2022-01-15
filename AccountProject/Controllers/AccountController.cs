using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountProject.Models;

namespace AccountProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {

            IList<Account> account = new List<Account>();

            account.Add(new Account() { AccID = 5678, AccHolderName = "Srihari", AccHolderAddress = "HYD" });
            account.Add(new Account() { AccID = 3459, AccHolderName = "Srikanth", AccHolderAddress = "KMM" });
            account.Add(new Account() { AccID = 8765, AccHolderName = "Venkatesh", AccHolderAddress = "SRPT" });
            account.Add(new Account() { AccID = 1280, AccHolderName = "Rajiv", AccHolderAddress = "NLG" });


            ViewData["account"] = account;
            return View();
        }
    }
}
