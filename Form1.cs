using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1530._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gilevavDataSet.ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.gilevavDataSet.ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gilevavDataSet.spectacle". При необходимости она может быть перемещена или удалена.
            this.spectacleTableAdapter.Fill(this.gilevavDataSet.spectacle);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gilevavDataSet.info_tickets". При необходимости она может быть перемещена или удалена.
            this.info_ticketsTableAdapter.Fill(this.gilevavDataSet.info_tickets);

        }
    }
}
