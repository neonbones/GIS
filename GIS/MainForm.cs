using GIS.Finder;
using GIS.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GIS
{
    public partial class MainForm : Form
    {
        public double xScope = 1;
        public double yScope = 1;
        private ConstructionsRepository _repository = new ConstructionsRepository();
        public MainForm()
        {
            InitializeComponent();
            
        }

        public void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void MapBox_Click(object sender, EventArgs e)
        {

            MouseEventArgs m = (MouseEventArgs)e;
            if (m.Button == MouseButtons.Left)
            {
                MousePoint clickPoint = new MousePoint(m.X, m.Y);

                // Warthmith
                if (Geometry.IsInside(clickPoint, _repository.GetWarthmith()))
                    MessageBox.Show(_repository.GetWarthmithDescription(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // FaendalsHouse
                if (Geometry.IsInside(clickPoint, _repository.GetFaendalsHouse()))
                    MessageBox.Show(_repository.GetFaendalsHouseDescription(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // GerdursHouse 
                if (Geometry.IsInside(clickPoint, _repository.GetGerdursHouse()))
                    MessageBox.Show(_repository.GetGerdursHouseDescription(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // RiverwoodTrader 
                if (Geometry.IsInside(clickPoint, _repository.GetRiverwoodTrader()))
                    MessageBox.Show(_repository.GetRiverwoodTraderDescription(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // SleepingGiantInn 
                if (Geometry.IsInside(clickPoint, _repository.GetSleepingGiantInn()))
                    MessageBox.Show(_repository.GetSleepingGiantInnDescription(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // SvensHouse
                if (Geometry.IsInside(clickPoint, _repository.GetSvensHouse()))
                    MessageBox.Show(_repository.GetSvensHouseDescription(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //MessageBox.Show("X: " + m.X + " " + "Y: " + m.Y);
            }

        }

        private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Show();
        }
    }
}
