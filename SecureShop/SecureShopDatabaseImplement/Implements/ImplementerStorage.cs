﻿using SecureShopBusinessLogic.BindingModels;
using SecureShopBusinessLogic.Interfaces;
using SecureShopBusinessLogic.ViewModels;
using SecureShopDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecureShopDatabaseImplement.Implements
{
    public class ImplementerStorage : IImplementerStorage
    {
        public List<ImplementerViewModel> GetFullList()
        {
            using (var context = new SecureShopDatabase())
            {
                return context.Implementers
                .Select(CreateModel).ToList();
            }
        }

        public List<ImplementerViewModel> GetFilteredList(ImplementerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new SecureShopDatabase())
            {
                return context.Implementers
                    .Where(rec =>
                    rec.Name.Contains(model.Name))
                    .Select(CreateModel).ToList();
            }
        }

        public ImplementerViewModel GetElement(ImplementerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new SecureShopDatabase())
            {
                var implementer = context.Implementers
                .FirstOrDefault(rec => rec.Id == model.Id || rec.Name == model.Name);
                return implementer != null ?
                CreateModel(implementer) : null;
            }
        }

        public void Insert(ImplementerBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                context.Implementers.Add(CreateModel(model, new Implementer()));
                context.SaveChanges();
            }
        }

        public void Update(ImplementerBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                var element = context.Implementers.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Исполнитель не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ImplementerBindingModel model)
        {
            using (var context = new SecureShopDatabase())
            {
                Implementer element = context.Implementers.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Implementers.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Исполнитель не найден");
                }
            }
        }

        private Implementer CreateModel(ImplementerBindingModel model, Implementer implementer)
        {
            implementer.Name = model.Name;
            implementer.WorkingTime = model.WorkingTime;
            implementer.PauseTime = model.PauseTime;
            return implementer;
        }

        private ImplementerViewModel CreateModel(Implementer implementer)
        {
            return new ImplementerViewModel
            {
                Id = implementer.Id,
                Name = implementer.Name,
                WorkingTime = implementer.WorkingTime,
                PauseTime = implementer.PauseTime
            };
        }
    }
}