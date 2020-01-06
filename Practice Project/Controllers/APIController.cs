using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_Project.Models;

namespace Practice_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class APIController : ControllerBase
    {
        [HttpPost]
        public void Success(IndexViewModel viewModel)
        {
            string firstName = viewModel.FirstName;
        }
    }
}