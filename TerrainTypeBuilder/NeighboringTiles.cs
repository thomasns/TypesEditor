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

        CheckBox[] required;
        CheckBox[] optional;
        Bitmap bm = new Bitmap(@"C:\Users\thoma\Desktop\normalTiles.png");
        public NeighboringTiles()
        {
            neighborSprites = new Dictionary<int, Tuple<int, int>>();
            InitializeComponent();
            required = new CheckBox[] { TLReq, TMReq, TRReq, MLReq, new CheckBox(), MRReq, BLReq, BMReq, BRReq };
            optional = new CheckBox[] { topLeft, topMiddle, topRight, midLeft, new CheckBox(), midRight, bottomLeft, bottomMiddle, bottomRight };
        }

        private void button1_Click(object sender, EventArgs e)
        {
             List<int> matchingValues = findMatchingValues();
            foreach (int match in matchingValues)
            {
                Console.WriteLine(match);
                if (neighborSprites.ContainsKey(match))
                {
                    //find pattern
                    int val = match;
                    bool[,] sets = new bool[3, 3];
                    if (val >= 256)
                    {
                        sets[2, 2] = true;
                        val -= 256;
                    }
                    if (val >= 128)
                    {
                        sets[2, 1] = true;
                        val -= 128;
                    }
                    if (val >= 64)
                    {
                        sets[2, 0] = true;
                        val -= 64;
                    }
                    if (val >= 32)
                    {
                        sets[1, 2] = true;
                        val -= 32;
                    }
                    if (val >= 8)
                    {
                        sets[1, 0] = true;
                        val -= 8;
                    }
                    if (val >= 4)
                    {
                        sets[0, 2] = true;
                        val -= 4;
                    }
                    if (val >= 2)
                    {
                        sets[0, 1] = true;
                        val -= 2;
                    }
                    if (val >= 1)
                    {
                        sets[0, 0] = true;
                        val -= 1;
                    }
                    String pattern = "";
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (i == 1 && j == 1)
                            {
                                pattern += "0";
                            }
                            if (sets[i, j] == true)
                                pattern += "X";
                            else pattern += '-';
                        }
                        pattern += "\n";
                    }




                    if (neighborSprites.ContainsKey(match))
                    {
                        ConflictForm cf = new ConflictForm();
                        Rectangle grassRect = new Rectangle(3, 14, 16, 16);
                        Rectangle waterRect = new Rectangle(20, 129, 16, 16);
                        if (sets[0, 0])
                        {
                            cf.pictureBox1.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox10.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        else
                        {
                            cf.pictureBox1.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox10.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        if (sets[0, 1])
                        {
                            cf.pictureBox2.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox11.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        else
                        {
                            cf.pictureBox2.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox11.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        if (sets[0, 2])
                        {
                            cf.pictureBox3.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox12.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        else
                        {
                            cf.pictureBox3.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox12.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        if (sets[1, 0])
                        {
                            cf.pictureBox4.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox13.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        else
                        {
                            cf.pictureBox4.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox13.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        if (sets[1, 2])
                        {
                            cf.pictureBox6.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox15.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        else
                        {
                            cf.pictureBox6.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox15.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        if (sets[2, 0])
                        {
                            cf.pictureBox7.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox16.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        else
                        {
                            cf.pictureBox7.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox16.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        if (sets[2, 1])
                        {
                            cf.pictureBox8.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox17.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        else
                        {
                            cf.pictureBox8.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox17.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        if (sets[2, 2])
                        {
                            cf.pictureBox9.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox18.Image = bm.Clone(waterRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        else
                        {
                            cf.pictureBox9.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                            cf.pictureBox18.Image = bm.Clone(grassRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        }
                        Rectangle replacmentRect = new Rectangle((int)spriteX.Value, (int)spriteY.Value, 16, 16);
                        Rectangle existingRect = new Rectangle((int)neighborSprites[match].Item1, (int)neighborSprites[match].Item2, 16, 16);
                        cf.pictureBox5.Image = bm.Clone(existingRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        cf.pictureBox14.Image = bm.Clone(replacmentRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                        if(cf.ShowDialog() == DialogResult.OK)
                        {
                            neighborSprites[match] = new Tuple<int, int>((int)spriteX.Value, (int)spriteY.Value);
                        }
                        continue;
                    }
                }

                neighborSprites.Add(match, new Tuple<int, int>((int)spriteX.Value, (int)spriteY.Value));
                listBox1.Items.Add(new spriteDataHolder(match, (int)spriteX.Value, (int)spriteY.Value));
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            spriteY.Value += 17;
        }



        private List<int> findMatchingValues()
        {
            List<int> matchingValues = new List<int>();
            int baseValue = 0;

            for (int i = 0; i < 9; i++)
            {
                if (i == 4)
                    continue;
                if (required[i].Checked)
                    baseValue += (int)Math.Pow(2, i);
            }
            if (baseValue > 0)
                matchingValues.Add(baseValue);
            //Find all possible sums of different values in the list. 
            List<int> optionalValues = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (i == 4)
                    continue;
                if (optional[i].Checked)
                    optionalValues.Add((int)Math.Pow(2, i));
            }
            bool[] use = new bool[optionalValues.Count];
            for (int i = 0; i < use.Count() - 1; i++)
                use[i] = false;
            if(use.Count() > 0)
                use[use.Count() - 1] = true;
            while(true)
            {
                bool done = true;
                for(int j = 0; j < use.Count(); j++)
                {
                    if (use[j] == false)
                        done = false;
                }
                int addedValue = baseValue;
                for (int j = 0; j < use.Count(); j++)
                {
                    Console.Write((use[j]) ? "1" : "0");
                    if (use[j])
                        addedValue += optionalValues[j];
                }
                Console.WriteLine();
                matchingValues.Add(addedValue);
                
                for(int j = use.Count() -1; j >= 0; j--)
                {
                    if(j == use.Count() -1) 
                        use[j] = !use[j];
                    else
                    {
                        if (use[j + 1] == false)
                        {
                            use[j] = !use[j];
                        }
                        else
                            break;
                    }
                }
                if (done)
                    break;
            }
            return matchingValues;

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
            updateImage();
        }

        private void spriteX_ValueChanged(object sender, EventArgs e)
        {
            updateImage();
        }

        private void updateImage()
        {
            Rectangle currentRect = new Rectangle((int)spriteX.Value, (int)spriteY.Value, 16, 16);
            pictureBox1.Image = bm.Clone(currentRect, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TLReq_CheckedChanged(object sender, EventArgs e)
        {
            if(TLReq.Checked)
            {
                topLeft.Checked = false;
                topLeft.Enabled = false;
            }
            else
                topLeft.Enabled = true;
        }

        private void TMReq_CheckedChanged(object sender, EventArgs e)
        {
            if (TMReq.Checked)
            {
                topMiddle.Checked = false;
                topMiddle.Enabled = false;
            }
            else
                topMiddle.Enabled = true;
        }

        private void TRReq_CheckedChanged(object sender, EventArgs e)
        {
            if (TRReq.Checked)
            {
                topRight.Checked = false;
                topRight.Enabled = false;
            }
            else
                topRight.Enabled = true;
        }

        private void MLReq_CheckedChanged(object sender, EventArgs e)
        {
            if (MLReq.Checked)
            {
                midLeft.Checked = false;
                midLeft.Enabled = false;
            }
            else
                midLeft.Enabled = true;
        }

        private void MRReq_CheckedChanged(object sender, EventArgs e)
        {
            if (MRReq.Checked)
            {
                midRight.Checked = false;
                midRight.Enabled = false;
            }
            else
                midRight.Enabled = true;

        }

        private void BLReq_CheckedChanged(object sender, EventArgs e)
        {
            if (BLReq.Checked)
            {
                bottomLeft.Checked = false;
                bottomLeft.Enabled = false;
            }
            else
                bottomLeft.Enabled = true;
        }

        private void BMReq_CheckedChanged(object sender, EventArgs e)
        {
            if (BMReq.Checked)
            {
                bottomMiddle.Checked = false;
                bottomMiddle.Enabled = false;
            }
            else
                bottomMiddle.Enabled = true;

        }

        private void BRReq_CheckedChanged(object sender, EventArgs e)
        {
            if (BRReq.Checked)
            {
                bottomRight.Checked = false;
                bottomRight.Enabled = false;
            }
            else
                bottomRight.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (spriteX.Value >= 17 && spriteY.Value >= 17)
            {
                spriteX.Value -= 17;
                spriteY.Value -= 17;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (spriteY.Value >= 17)
            {
                spriteY.Value -= 17;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (spriteX.Value < bm.Width-17 && spriteY.Value >= 17)
            {
                spriteX.Value += 17;
                spriteY.Value -= 17;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (spriteX.Value >= 17)
            {
                spriteX.Value -= 17;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (spriteX.Value >= 17 && spriteY.Value < bm.Height - 17)
            {
                spriteX.Value -= 17;
                spriteY.Value += 17;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (spriteY.Value < bm.Height - 17)
            {
                spriteY.Value += 17;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (spriteX.Value < bm.Height - 17 && spriteY.Value < bm.Height - 17)
            {
                spriteX.Value += 17;
                spriteY.Value += 17;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (spriteX.Value < bm.Width - 17)
            {
                spriteX.Value += 17;
            }
        }
    }
}
