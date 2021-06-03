﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SecureShopBusinessLogic.BindingModels
{
	/// <summary>
	/// Исполнитель, выполняющий заказы
	/// </summary>
	public class ImplementerBindingModel
	{
		public int? Id { get; set; }
		public string Name { get; set; }
		public int WorkingTime { get; set; }
		public int PauseTime { get; set; }
	}
}
