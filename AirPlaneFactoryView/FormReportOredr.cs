using System;
using AirPlaneFactoryBusinessLogic.BindingModels;
using AirPlaneFactoryBusinessLogic.Interfaces;
using System.Windows.Forms;
using Unity;
using AirPlaneFactoryBusinessLogic.ViewModels;
using System.Collections.Generic;
using AirPlaneFactoryBusinessLogic.BusnessLogics;
using AirPlaneFactoryListImplement.Models;
using Microsoft.Reporting.WinForms;


namespace AbstractShopView
{
    public partial class FormReportOredr : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ReportLogic logic;
        public FormReportOredr(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormReportOrders_Load(object sender, EventArgs e)
        {
            try
            {
                var dataSource = logic.GetForgeProductBillet();
                ReportDataSource source = new ReportDataSource("DataSetOrders", dataSource);
                reportViewer.LocalReport.DataSources.Add(source);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        [Obsolete]
        private void buttonToPdf_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        logic.SaveOrdersToPdfFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName,
                        });
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
