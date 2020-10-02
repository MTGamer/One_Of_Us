using One_Of_Us_Editor.LevelComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Of_Us_Editor
{
    public partial class HUB : Form
    {
        public CurrentLevelComponets levelData;

        public HUB()
        {
            levelData = new CurrentLevelComponets();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinishLevel fn = new FinishLevel();
            fn.Show();
            fn.levelData = levelData;
        }

        private void Grid_4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModeSelect MS = new ModeSelect();
            MS.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            WorldEdit WE = new WorldEdit();
            WE.Show();
            WE.CLC = levelData;
        }
    }
}
