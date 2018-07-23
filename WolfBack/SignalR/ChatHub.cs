﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WolfBack.SignalR
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string message)
        {
            return Clients.All.SendAsync("Send", message);
        }
    }
}
