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
    public partial class FinishLevel : Form
    {
        public CurrentLevelComponets levelData;

        public FinishLevel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            levelData.compileLevel();

            SaveLevelDialoge.ShowDialog();

            string levelPath = SaveLevelDialoge.FileName;

            string newLevelWithCeiling = "";

            for (int x = 0; x < CeilingHeightValue.Value; x++)
            {
                newLevelWithCeiling += levelData.compiledLevel + "\n";
            }

            System.IO.File.WriteAllText(levelPath, newLevelWithCeiling);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
