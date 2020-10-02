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
    public partial class WorldEdit : Form
    {
        // Varibles
        public CurrentLevelComponets CLC;

        public WorldEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLC.saveLevel("Something");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string oldLevel = CLC.levelSave;
            CLC.levelSave = "";

            // Writing Level Data To String
            for (int i = 0; i < oldLevel.Length; i++)
            {

                if(SpawnTypeValue.Value == 1)
                {
                    // Cube
                    CLC.levelSave += '1';
                }
                if (SpawnTypeValue.Value == 2)
                {
                    // Player
                    CLC.levelSave += '2';
                }
                else
                {
                    CLC.levelSave += '0';
                }
            }


            // Checking Boxes Because Why Not
            int gridIndex = 0, tileIndex = 0;

            for (int x = 0; x < 16; x++)
            {
                if(gridIndex == 0)
                {
                    // First Row
                    Grid_1.SetItemChecked(tileIndex, CLC.levelSave[tileIndex] == '1');
                }
                if (gridIndex == 1)
                {
                    // Second Row
                    Grid_2.SetItemChecked(tileIndex, CLC.levelSave[tileIndex] == '1');
                }
                if (gridIndex == 2)
                {
                    // Third Row
                    Grid_3.SetItemChecked(tileIndex, CLC.levelSave[tileIndex] == '1');
                }
                if (gridIndex == 3)
                {
                    // Fourth Row
                    Grid_4.SetItemChecked(tileIndex, CLC.levelSave[tileIndex] == '1');
                }

                if(tileIndex >= 4)
                {
                    tileIndex = 0;
                    gridIndex++;
                }

                tileIndex++;
            }
        }
    }
}
