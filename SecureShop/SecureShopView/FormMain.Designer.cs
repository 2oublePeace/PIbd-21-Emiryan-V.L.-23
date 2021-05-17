﻿
namespace SecureShopView
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.topMenuStrip = new System.Windows.Forms.MenuStrip();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.устройстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.комплектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.исполнителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокУстройствToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.устройстваПоКомплектациямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокЗазказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.запускРаботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.createOrderBtn = new System.Windows.Forms.Button();
			this.orderPayedBtn = new System.Windows.Forms.Button();
			this.updateListBtn = new System.Windows.Forms.Button();
			this.topMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// topMenuStrip
			// 
			this.topMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.topMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.запускРаботToolStripMenuItem});
			this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.topMenuStrip.Name = "topMenuStrip";
			this.topMenuStrip.Size = new System.Drawing.Size(1305, 33);
			this.topMenuStrip.TabIndex = 0;
			this.topMenuStrip.Text = "menuStrip1";
			// 
			// справочникиToolStripMenuItem
			// 
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.устройстваToolStripMenuItem,
            this.комплектыToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.исполнителиToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
			this.справочникиToolStripMenuItem.Text = "Справочники";
			// 
			// устройстваToolStripMenuItem
			// 
			this.устройстваToolStripMenuItem.Name = "устройстваToolStripMenuItem";
			this.устройстваToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
			this.устройстваToolStripMenuItem.Text = "Устройства";
			this.устройстваToolStripMenuItem.Click += new System.EventHandler(this.DevicesToolStripMenuItem_Click);
			// 
			// комплектыToolStripMenuItem
			// 
			this.комплектыToolStripMenuItem.Name = "комплектыToolStripMenuItem";
			this.комплектыToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
			this.комплектыToolStripMenuItem.Text = "Комплекты";
			this.комплектыToolStripMenuItem.Click += new System.EventHandler(this.EquipmentsToolStripMenuItem_Click);
			// 
			// клиентыToolStripMenuItem
			// 
			this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
			this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
			this.клиентыToolStripMenuItem.Text = "Клиенты";
			this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.ClientsToolStripMenuItem_Click);
			// 
			// исполнителиToolStripMenuItem
			// 
			this.исполнителиToolStripMenuItem.Name = "исполнителиToolStripMenuItem";
			this.исполнителиToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
			this.исполнителиToolStripMenuItem.Text = "Исполнители";
			this.исполнителиToolStripMenuItem.Click += new System.EventHandler(this.ImplementersToolStripMenuItem_Click);
			// 
			// отчетыToolStripMenuItem
			// 
			this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокУстройствToolStripMenuItem,
            this.устройстваПоКомплектациямToolStripMenuItem,
            this.списокЗазказовToolStripMenuItem});
			this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
			this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
			this.отчетыToolStripMenuItem.Text = "Отчеты";
			// 
			// списокУстройствToolStripMenuItem
			// 
			this.списокУстройствToolStripMenuItem.Name = "списокУстройствToolStripMenuItem";
			this.списокУстройствToolStripMenuItem.Size = new System.Drawing.Size(365, 34);
			this.списокУстройствToolStripMenuItem.Text = "Список устройств";
			this.списокУстройствToolStripMenuItem.Click += new System.EventHandler(this.DevicesToolStripMenuReportItem_Click);
			// 
			// устройстваПоКомплектациямToolStripMenuItem
			// 
			this.устройстваПоКомплектациямToolStripMenuItem.Name = "устройстваПоКомплектациямToolStripMenuItem";
			this.устройстваПоКомплектациямToolStripMenuItem.Size = new System.Drawing.Size(365, 34);
			this.устройстваПоКомплектациямToolStripMenuItem.Text = "Устройства по комплектациям";
			this.устройстваПоКомплектациямToolStripMenuItem.Click += new System.EventHandler(this.DeviceEquipmentsToolStripMenuItem_Click);
			// 
			// списокЗазказовToolStripMenuItem
			// 
			this.списокЗазказовToolStripMenuItem.Name = "списокЗазказовToolStripMenuItem";
			this.списокЗазказовToolStripMenuItem.Size = new System.Drawing.Size(365, 34);
			this.списокЗазказовToolStripMenuItem.Text = "Список зазказов";
			this.списокЗазказовToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
			// 
			// запускРаботToolStripMenuItem
			// 
			this.запускРаботToolStripMenuItem.Name = "запускРаботToolStripMenuItem";
			this.запускРаботToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
			this.запускРаботToolStripMenuItem.Text = "Запуск работ";
			this.запускРаботToolStripMenuItem.Click += new System.EventHandler(this.StartWorkToolStripMenuItem_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(18, 42);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.Size = new System.Drawing.Size(951, 632);
			this.dataGridView.TabIndex = 1;
			// 
			// createOrderBtn
			// 
			this.createOrderBtn.Location = new System.Drawing.Point(1024, 185);
			this.createOrderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.createOrderBtn.Name = "createOrderBtn";
			this.createOrderBtn.Size = new System.Drawing.Size(222, 35);
			this.createOrderBtn.TabIndex = 2;
			this.createOrderBtn.Text = "Создать заказ";
			this.createOrderBtn.UseVisualStyleBackColor = true;
			this.createOrderBtn.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
			// 
			// orderPayedBtn
			// 
			this.orderPayedBtn.Location = new System.Drawing.Point(1024, 415);
			this.orderPayedBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.orderPayedBtn.Name = "orderPayedBtn";
			this.orderPayedBtn.Size = new System.Drawing.Size(222, 35);
			this.orderPayedBtn.TabIndex = 5;
			this.orderPayedBtn.Text = "Заказ оплачен";
			this.orderPayedBtn.UseVisualStyleBackColor = true;
			this.orderPayedBtn.Click += new System.EventHandler(this.ButtonPayOrder_Click);
			// 
			// updateListBtn
			// 
			this.updateListBtn.Location = new System.Drawing.Point(1024, 492);
			this.updateListBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.updateListBtn.Name = "updateListBtn";
			this.updateListBtn.Size = new System.Drawing.Size(222, 35);
			this.updateListBtn.TabIndex = 6;
			this.updateListBtn.Text = "Обновить список";
			this.updateListBtn.UseVisualStyleBackColor = true;
			this.updateListBtn.Click += new System.EventHandler(this.ButtonRef_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1305, 692);
			this.Controls.Add(this.updateListBtn);
			this.Controls.Add(this.orderPayedBtn);
			this.Controls.Add(this.createOrderBtn);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.topMenuStrip);
			this.MainMenuStrip = this.topMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormMain";
			this.Text = "Магазин охранных систем";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.topMenuStrip.ResumeLayout(false);
			this.topMenuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip topMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem устройстваToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem комплектыToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button createOrderBtn;
		private System.Windows.Forms.Button orderPayedBtn;
		private System.Windows.Forms.Button updateListBtn;
		private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокУстройствToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem устройстваПоКомплектациямToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокЗазказовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem исполнителиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem запускРаботToolStripMenuItem;
	}
}