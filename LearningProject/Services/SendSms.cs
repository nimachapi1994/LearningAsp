using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningProject.Services
{
    public class SendSms : ISendMessage
    {

        public string sendMessage()
        {
            return "message send by sms";
        }


    }
}
