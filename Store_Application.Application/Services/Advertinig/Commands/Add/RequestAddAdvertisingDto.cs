﻿using Microsoft.AspNetCore.Http;
using Store_Application.Domain.Enums;
using System;

namespace Store_Application.Application.Services.Advertinig.Commands.Add
{
    public class RequestAddAdvertisingDto
    {
       
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public AdvertisingPlaces Place { get; set; }
        public IFormFile Image { get; set; }
        public string LinkTo { get; set; }
    }
}
