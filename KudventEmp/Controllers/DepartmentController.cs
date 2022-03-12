using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KudventEmp.Controllers
{
    public class DepartmentController : Controller
    {
        public string List()
        {
            return "THis is the list view";
        }
        public string Detailss()
        {
            return "THis is the Deatils view";
        }
    }
}
