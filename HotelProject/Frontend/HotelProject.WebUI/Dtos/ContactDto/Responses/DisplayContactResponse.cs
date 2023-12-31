﻿using System;

namespace HotelProject.WebUI.Dtos.ContactDto.Responses
{
    public class DisplayContactResponse
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
