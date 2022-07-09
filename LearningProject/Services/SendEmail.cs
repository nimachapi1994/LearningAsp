using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningProject.Services
{
    public class SendEmail : ISendMessage
    {
        public virtual string sendMessage()
        {
            return "message send by email";
        }
    }
}
