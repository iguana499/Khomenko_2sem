using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AirPlaneFactoryBusinessLogic.BindingModels;
using AirPlaneFactoryBusinessLogic.Interfaces;
using AirPlaneFactoryBusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShopRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientLogic _logic;
        private readonly IMessageInfoLogic _messageLogic;
        private readonly int _passwordMaxLength = 50;
        private readonly int _passwordMinLength = 10;
        public ClientController(IClientLogic logic, IMessageInfoLogic messageInfo)
        {
            _logic = logic;
            _messageLogic = messageInfo;
        }
        [HttpGet]
        public ClientViewModel Login(string login, string password) => _logic.Read(new ClientBindingModel
        {
            Email = login,
            Password = password
        })?[0];
        [HttpGet]
        public List<MessageInfoViewModel> GetMessages(int clientId) => _messageLogic.Read(new MessageInfoBindingModel { ClientId = clientId });
        [HttpPost]
        public void Register(ClientBindingModel model)
        {
            CheckData(model);
            _logic.CreateOrUpdate(model);
        }
        [HttpPost]
        public void UpdateData(ClientBindingModel model) => _logic.CreateOrUpdate(model);
        private void CheckData(ClientBindingModel model)
        {
            if (!Regex.IsMatch(model.Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                throw new Exception("В качестве логина должна быть указана почта  ");
            }
            if (model.Password.Length > _passwordMaxLength || model.Password.Length <
           _passwordMinLength || !Regex.IsMatch(model.Password, @"^((\w+\d+\W+)|(\w+\W+\d+)|(\d+\w+\W+)|(\d+\W+\w+)|(\W+\w+\d+)|(\W+\d+\w+))[\w\d\W]*$"))
            {
                throw new Exception($"Пароль длиной от {_passwordMinLength} до { _passwordMaxLength } должен быть и из цифр, букв и небуквенных символов должен состоять");
            }
        }
    }
}