﻿using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.Interfaces;
using SecureShopBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace SecureShopBusinessLogic.BusinessLogics
{
    public class ClientLogic
    {
        private readonly IClientStorage _clientStorage;

        public ClientLogic(IClientStorage clientStorage)
        {
            _clientStorage = clientStorage;
        }

        public List<ClientViewModel> Read(ClientBindingModel model)
        {
            if (model == null)
            {
                return _clientStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ClientViewModel> { _clientStorage.GetElement(model) };
            }
            return _clientStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(ClientBindingModel model)
        {
            var element = _clientStorage.GetElement(new ClientBindingModel
            {
                Email = model.Email
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Этот email уже используется");
            }
            if (model.Id.HasValue)
            {
                _clientStorage.Update(model);
            }
            else
            {
                _clientStorage.Insert(model);
            }
        }

        public void Delete(ClientBindingModel model)
        {
            var element = _clientStorage.GetElement(new ClientBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Клиент не найден");
            }
            _clientStorage.Delete(model);
        }
    }
}