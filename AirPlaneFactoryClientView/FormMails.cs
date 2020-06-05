using AirPlaneFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirPlaneFactoryClientView
{
    public partial class FormMails : Form
    {
        public FormMails()
        {
            InitializeComponent();
        }
        private void FormMails_Load(object sender, EventArgs e)
        {
            try
            {
                List<MessageInfoViewModel> dataSourse = APIClient.GetRequest<List<MessageInfoViewModel>>($"api/client/getmessages?clientId={Program.Client.Id}");
                dataGridView.DataSource = dataSourse;
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}