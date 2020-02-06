using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrainTypeBuilder
{
    public partial class NeighboringTiles : Form
    {

        public Dictionary<int, Tuple<int, int>> neighborSprites { get; set; }
        public NeighboringTiles()
        {
            neighborSprites = new Dictionary<int, Tuple<int, int>>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            findMatchingValues();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("new item");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void findMatchingValues()
        {
            if (requireAll.Checked)
            {
                int matchingValue = findFullMatchingValue();
                neighborSprites.Add(matchingValue, new Tuple<int, int>((int)spriteX.Value, (int)spriteY.Value));
                listBox1.Items.Add(new spriteDataHolder(matchingValue,(int)spriteX.Value,(int)spriteY.Value));
            }

            else
            {
                int totalEnabled = countEnabled();
                if (totalEnabled == 2)
                {
                    //Find totalValueFirst
                    int matchingValue = findFullMatchingValue();
                    neighborSprites.Add(matchingValue, new Tuple<int, int>((int)spriteX.Value, (int)spriteY.Value));
                    listBox1.Items.Add(new spriteDataHolder(matchingValue, (int)spriteX.Value, (int)spriteY.Value));
                    //Now the rest (i think it could only ever be direct connections. )
                    if (topMiddle.Checked)
                    {
                        neighborSprites.Add(2, new Tuple<int, int>((int)spriteX.Value, (int)spriteY.Value));
                        listBox1.Items.Add(new spriteDataHolder(2, (int)spriteX.Value, (int)spriteY.Value));
                    }
                    if (midLeft.Checked)
                    {
                        neighborSprites.Add(8, new Tuple<int, int>((int)spriteX.Value, (int)spriteY.Value));
                        listBox1.Items.Add(new spriteDataHolder(8, (int)spriteX.Value, (int)spriteY.Value));
                    }
                    if (midRight.Checked)
                    { 
                        neighborSprites.Add(32, new Tuple<int, int>((int)spriteX.Value, (int)spriteY.Value));
                        listBox1.Items.Add(new spriteDataHolder(32, (int)spriteX.Value, (int)spriteY.Value));
                    }
                    if (bottomMiddle.Checked)
                    {
                        neighborSprites.Add(128, new Tuple<int, int>((int)spriteX.Value, (int)spriteY.Value));
                        listBox1.Items.Add(new spriteDataHolder(128, (int)spriteX.Value, (int)spriteY.Value));
                    }
                }
                else
                {
                        MessageBox.Show("Sorry, must have exactly two neighbors selected", "Error", MessageBoxButtons.OK);
                }

            }
        }

        private int countEnabled()
        {
            int countEnabled = 0;
            {
                if (topLeft.Checked)
                    countEnabled++;
                if (topMiddle.Checked)
                    countEnabled++;
                if (topRight.Checked)
                    countEnabled++;
                if (midLeft.Checked)
                    countEnabled++;
                if (midRight.Checked)
                    countEnabled++;
                if (bottomLeft.Checked)
                    countEnabled++;
                if (bottomMiddle.Checked)
                    countEnabled++;
                if (bottomRight.Checked)
                    countEnabled++;
            }

            return countEnabled;
        }

        private int findFullMatchingValue()
        {
            int matchingValue = 0;
            if (requireAll.Checked)
            {
                if (topLeft.Checked)
                    matchingValue += 1;
                if (topMiddle.Checked)
                    matchingValue += 2;
                if (topRight.Checked)
                    matchingValue += 4;
                if (midLeft.Checked)
                    matchingValue += 8;
                if (midRight.Checked)
                    matchingValue += 32;
                if (bottomLeft.Checked)
                    matchingValue += 64;
                if (bottomMiddle.Checked)
                    matchingValue += 128;
                if (bottomRight.Checked)
                    matchingValue += 256;
            }
            else
            {
                if (topMiddle.Checked)
                    matchingValue += 2;
                if (midLeft.Checked)
                    matchingValue += 8;
                if (midRight.Checked)
                    matchingValue += 32;
                if (bottomMiddle.Checked)
                    matchingValue += 128;
            }
            return matchingValue;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            topLeft.Enabled = !onlyDirectNeighbors.Checked;
                topRight.Enabled = !onlyDirectNeighbors.Checked;
                bottomLeft.Enabled = !onlyDirectNeighbors.Checked;
                bottomRight.Enabled = !onlyDirectNeighbors.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!requireAll.Checked)
            {
                onlyDirectNeighbors.Checked = true;
                onlyDirectNeighbors.Enabled = false;
            }
            else
            {
                onlyDirectNeighbors.Enabled = true;
            }
        }

        private void bottomLeft_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nidLeft_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void spriteY_ValueChanged(object sender, EventArgs e)
        {

        }

        private void spriteX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void setNeighbors(Dictionary<int,Tuple<int,int>> neighbors)
        {
            neighborSprites = new Dictionary<int, Tuple<int, int>>(neighbors);
            
            foreach(KeyValuePair<int,Tuple<int,int>> sdh in neighbors)
            {
                listBox1.Items.Add(new spriteDataHolder(sdh.Key, sdh.Value.Item1, sdh.Value.Item2));

            }
        }

        private class spriteDataHolder
        {
            public int matchValue { get; set; }
            public Tuple<int, int> spriteCoordinates { get; set; }

            public spriteDataHolder(int v, int x, int y)
            {
                this.matchValue = v;
                this.spriteCoordinates = new Tuple<int, int>(x, y);
            }
            public override String ToString()
            {
                return matchValue + ": " + spriteCoordinates.Item1 + "X" + spriteCoordinates.Item2;
            }

        }
    }
}
