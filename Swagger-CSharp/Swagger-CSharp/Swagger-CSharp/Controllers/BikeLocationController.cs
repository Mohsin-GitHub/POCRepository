using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Swagger_CSharp.Models;
using Swagger_CSharp.Providers;
using Swagger_CSharp.Results;

namespace Swagger_CSharp.Controllers
{
    public class BikeLocationController:ApiController
    {
        [HttpGet]
        [ActionName("bikeLocation")]
        public BikeLocationDTO GetBikeLocation(int bikeId)
        {
            return new BikeLocationDTO() { BikeId = bikeId, BikeLatitude = 20.5, BikeLongitude = 25.4 };
        }
    }
}