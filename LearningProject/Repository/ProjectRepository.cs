using LearningProject.Services;
using LearningProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningProject.Repository
{
    public class ProjectRepository
    {
        //private SendEmail SendEmail;
        //public ISendMessage Message { set { value = SendEmail; } }

        private readonly ISendMessage message;
        public ProjectRepository(ISendMessage sendMessage)
        {
            message = sendMessage;
        }

        public void Message(ISendMessage sendMessage)
        {
            sendMessage = new SendEmail();
        }
        public string InsertProduct(VM_Product product)
        {
            VM_Product vM_Product = new VM_Product()
            {
                Title = product.Title,
                description = product.description,
                price = product.price
            };

            //  SendEmail.sendMessage();


            // message.sendMessage();

            message.sendMessage();


            return "ok";

        }
    }
}
