using System;
namespace PersonalWeb.Services
{
    public class HardcodedMessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hardcoded message from a service ";
        }
    }
}
