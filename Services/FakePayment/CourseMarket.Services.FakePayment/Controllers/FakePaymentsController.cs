﻿using CourseMarket.Shared.ControllerBases;
using CourseMarket.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMarket.Services.FakePayment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakePaymentsController : CustomBaseController
    {

        [HttpPost]
        public IActionResult ReceviePayment()
        {
            return CreateActionResultInstance(Response<NoContent>.Success(200));
        }
    }
}
