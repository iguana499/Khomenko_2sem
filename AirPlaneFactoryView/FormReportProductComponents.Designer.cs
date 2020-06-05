namespace AbstractShopView
{
    partial class FormReportProductComponents
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
            this.components = new System.ComponentModel.Container();
            this.buttonSaveToExcel = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.reportOrdersViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportFurnitureOrdersViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportOrdersViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.reportFurnitureOrdersViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonUpd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportOrdersViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFurnitureOrdersViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportOrdersViewModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFurnitureOrdersViewModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveToExcel
            // 
            this.buttonSaveToExcel.Location = new System.Drawing.Point(15, 19);
            this.buttonSaveToExcel.Name = "buttonSaveToExcel";
            this.buttonSaveToExcel.Size = new System.Drawing.Size(156, 23);
            this.buttonSaveToExcel.TabIndex = 0;
            this.buttonSaveToExcel.Text = "Сохранить в эксель";
            this.buttonSaveToExcel.UseVisualStyleBackColor = true;
            this.buttonSaveToExcel.Click += new System.EventHandler(this.buttonSaveToExcel_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(26, 54);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerFrom.TabIndex = 3;
            this.dateTimePickerFrom.Value = new System.DateTime(2020, 1, 1, 15, 39, 0, 0);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(198, 54);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // reportOrdersViewModelBindingSource
            // 
            this.reportOrdersViewModelBindingSource.DataSource = typeof(AirPlaneFactoryBusinessLogic.ViewModels.ReportOrdersViewModel);
            // 
            // reportFurnitureOrdersViewModelBindingSource
            // 
            this.reportFurnitureOrdersViewModelBindingSource.DataSource = typeof(AirPlaneFactoryBusinessLogic.ViewModels.ReportProductOrdersViewModel);
            // 
            // reportOrdersViewModelBindingSource1
            // 
            this.reportOrdersViewModelBindingSource1.DataSource = typeof(AirPlaneFactoryBusinessLogic.ViewModels.ReportOrdersViewModel);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(2, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(497, 344);
            this.dataGridView.TabIndex = 5;
            // 
            // reportFurnitureOrdersViewModelBindingSource1
            // 
            this.reportFurnitureOrdersViewModelBindingSource1.DataSource = typeof(AirPlaneFactoryBusinessLogic.ViewModels.ReportProductOrdersViewModel);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(226, 19);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(156, 23);
            this.buttonUpd.TabIndex = 6;
            this.buttonUpd.Text = "Обновить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // FormReportProductComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 474);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.buttonSaveToExcel);
            this.Name = "FormReportProductComponents";
            this.Text = "Компоненты по изделиям";
            this.Load += new System.EventHandler(this.FormReportProductComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportOrdersViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFurnitureOrdersViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportOrdersViewModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFurnitureOrdersViewModelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveToExcel;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.BindingSource reportOrdersViewModelBindingSource;
        private System.Windows.Forms.BindingSource reportFurnitureOrdersViewModelBindingSource;
        private System.Windows.Forms.BindingSource reportOrdersViewModelBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource reportFurnitureOrdersViewModelBindingSource1;
        private System.Windows.Forms.Button buttonUpd;
    }
}