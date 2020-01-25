using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_Project.Models;
using Practice_Project.Interfaces;

namespace Practice_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class APIController : ControllerBase
    {
        private readonly IModelTransformation _modelTransform;
        private readonly ILogger<APIController> _logger;

        public APIController(IModelTransformation modelTransform, ILogger<APIController> logger)
        {
            _modelTransform = modelTransform;
            _logger = logger;
        }

        [HttpPost("Success")]
        public void Success(IndexViewModel viewModel)
        {
            //save to db...
        }

        [HttpGet("GetInfo")]
        public ActionResult<IndexViewModel> GetViewModel()
        {
            //get from db...

            IndexViewModel model = new IndexViewModel
            {
                Age = 25,
                FirstName = "Mike",
                LastName = "D."
            };

            _modelTransform.Transform(model);

            return model;
        }

        [HttpGet("GetInfoAsync")]
        public async Task<ActionResult<IndexViewModel>> GetAsyncViewModel()
        {
            //get from db...

            IndexViewModel model = new IndexViewModel
            {
                Age = 25,
                FirstName = "Mike",
                LastName = "D."
            };

            await _modelTransform.TransformAsync(model);

            return model;
        }
    }
}