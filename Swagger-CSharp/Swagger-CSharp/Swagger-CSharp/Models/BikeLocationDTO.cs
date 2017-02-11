using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Swagger_CSharp.Models
{
    public class BikeLocationDTO
    {
        public int BikeId { get; set;}
        public double BikeLatitude { get; set; }
        public double BikeLongitude { get; set; }
    }
}