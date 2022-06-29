using System;

namespace WebApplicationChatBasicApp.Models
{
    //Error model
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
