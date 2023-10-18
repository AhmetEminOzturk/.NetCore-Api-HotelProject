﻿using System;

namespace HotelProject.WebUI.Dtos.SendMessageDto.Responses
{
    public class DisplaySendMessageResponse
    {
        public int SendMessageId { get; set; }
        public string SenderNameSurname { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverNameSurname { get; set; }
        public string ReceiverMail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
