using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationChatBasicApp.Models;

namespace WebApplicationChatBasicApp.Hubs
{
    public class ChatHub: Hub
    {
        public async Task SendMessage(Message message) =>
            await Clients.All.SendAsync("receivedMessage", message);
    }
}
