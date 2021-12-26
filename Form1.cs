using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace SFA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SQLiteConnection SQLiteConn;
        private DataTable dTable;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "subDataSet.Sub". При необходимости она может быть перемещена или удалена.
            this.subTableAdapter.Fill(this.subDataSet.Sub);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pyatDataSet.Pyat". При необходимости она может быть перемещена или удалена.
            this.pyatTableAdapter.Fill(this.pyatDataSet.Pyat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chetDataSet.Chet". При необходимости она может быть перемещена или удалена.
            this.chetTableAdapter.Fill(this.chetDataSet.Chet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sredaDataSet.Sreda". При необходимости она может быть перемещена или удалена.
            this.sredaTableAdapter.Fill(this.sredaDataSet.Sreda);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vtornikDataSet.Vtornik". При необходимости она может быть перемещена или удалена.
            this.vtornikTableAdapter.Fill(this.vtornikDataSet.Vtornik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ponDataSet.Pon". При необходимости она может быть перемещена или удалена.
            this.ponTableAdapter.Fill(this.ponDataSet.Pon);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "coachDataSet.Trener". При необходимости она может быть перемещена или удалена.
            this.trenerTableAdapter.Fill(this.coachDataSet.Trener);
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g;
            string sText;
            int iX;
            float iY;

            SizeF sizeText;
            TabControl ctlTab;

            ctlTab = (TabControl)sender;

            g = e.Graphics;

            sText = ctlTab.TabPages[e.Index].Text;
            sizeText = g.MeasureString(sText, ctlTab.Font);
            iX = e.Bounds.Left + 6;
            iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;
            g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY);
        }
    }
}

