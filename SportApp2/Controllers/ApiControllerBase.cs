﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace SportApp2.Controllers
{
    [Route("[controller]")]
    public class ApiControllerBase : Controller
    {
        //protected Guid UserId => User?.Identity?.IsAuthenticated == true ?
        //    Guid.Parse(User.Identity.Name) :
        //    Guid.Empty;
    }
}