using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace TerrainTypeBuilder
{
    public partial class Form1 : Form
    {
        public List<TerrainType> types;
        TerrainType entity;
        bool changed;
        bool valid;
        bool ignoreEvents;
        int index;
        public Form1()
        {
            InitializeComponent();
            types = new List<TerrainType>();
            entity = null;
            changed = false;
            valid = false;
            index = -1;
            ignoreEvents = false;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ignoreEvents)
                return;

            index = typesListBox.SelectedIndex;
            entity = new TerrainType(types[index]);
            setFields();
            changed = false;
            valid = true;

        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (impassableCheckBox.Checked)
                movementCostUpDown.Enabled = false;
            else
                movementCostUpDown.Enabled = true;

            entity.impassable = impassableCheckBox.Checked;
            changed = true;
            saveButton.Enabled = true;
        }

        private void setFields()
        {
            ignoreEvents = true;
            if (entity != null) {
                nameTextBox.Text = entity.Type;
                nameTextBox.Enabled = true;
                if (entity.impassable) {
                    impassableCheckBox.Checked = true;
                    movementCostUpDown.Enabled = false;
                } else {
                    impassableCheckBox.Checked = false;
                    movementCostUpDown.Enabled = true;
                }
                impassableCheckBox.Enabled = true;
                spriteXUpDown.Value = entity.spriteX;
                spriteXUpDown.Enabled = true;
                spriteYUpDown.Value = entity.spriteY;
                spriteYUpDown.Enabled = true;
                spriteSizeUpDown.Value = entity.spriteSize;
                spriteSizeUpDown.Enabled = true;
                if (entity.animaited) {
                    animaitedCheckBox.Checked = true;
                    for (int i = 0; i < entity.animationSequence.Count(); i++) {
                        if (i == entity.animationSequence.Count() - 1)
                            animationOrderTextBox.Text += entity.animationSequence[i];
                        else
                            animationOrderTextBox.Text += entity.animationSequence[i] + ",";
                    }
                } else {
                    animaitedCheckBox.Checked = false;
                    animationOrderTextBox.Text = String.Empty;
                    animationOrderTextBox.Enabled = false;
                }
                animaitedCheckBox.Enabled = true;
            }
            ignoreEvents = false;
        }

        private void animaitedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(animaitedCheckBox.Checked)
            {
                animationOrderTextBox.Enabled = true;   
            }
            else
            {
                animationOrderTextBox.Enabled = false;
                animationOrderTextBox.Text = String.Empty;
            }
            entity.animaited = animaitedCheckBox.Checked;
            changed = true;
            saveButton.Enabled = true; 
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                if (entity != null && MessageBox.Show("Are you sure you want to discard your changes?", "Discard", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    addNewType();
            }
            else
                addNewType();
        }

        private void addNewType()
        {
            entity = new TerrainType();
            types.Add(entity);
            typesListBox.Items.Add(entity.Type);
            typesListBox.SelectedIndex = typesListBox.Items.Count - 1;
            index = typesListBox.Items.Count - 1;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            entity.Type = nameTextBox.Text;
            changed = true;
            saveButton.Enabled = true;

        }

        private void spriteSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            entity.spriteSize = (int)spriteSizeUpDown.Value;
            changed = true;
            saveButton.Enabled = true;
        }

        private void spriteYUpDown_ValueChanged(object sender, EventArgs e)
        {
            entity.spriteY = (int)spriteYUpDown.Value;
            changed = true;
            saveButton.Enabled = true;
        }

        private void movementCostUpDown_ValueChanged(object sender, EventArgs e)
        {
            entity.movementCost = (int)movementCostUpDown.Value;
            changed = true;
            saveButton.Enabled = true;
        }

        private void aimationOrderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ignoreEvents)
                return;
            bool valid = true;
            Regex validator = new Regex("^[0-9]+$");
            string[] parts = animationOrderTextBox.Text.Split(',');
            for(int i = 0; i < parts.Count(); i++) {
                Console.WriteLine(validator.Match(parts[i]).Success);
                if(!validator.Match(parts[i].Trim()).Success) {
                    valid = false;
                    animationOrderTextBox.BackColor = Color.LightPink;
                } 
            }
            this.valid = valid;
            if(valid) {
                String cleanedString = "";
                animationOrderTextBox.BackColor = Color.White;
                entity.animationSequence = new List<int>(parts.Count());
                for (int i = 0; i < parts.Count(); i++) {

                    entity.animationSequence.Add(int.Parse(parts[i].Trim()));

                    if(i == parts.Count() -1) {
                        cleanedString += parts[i].Trim();
                    } else {
                        cleanedString += parts[i].Trim() + ",";
                    }

                    ignoreEvents = true;
                    animationOrderTextBox.Text = cleanedString;
                    animationOrderTextBox.SelectionStart = animationOrderTextBox.Text.Length;
                    animationOrderTextBox.SelectionLength = 0;
                    ignoreEvents = false;
                    
                }
            }
        }

        private void spriteXUpDown_ValueChanged(object sender, EventArgs e)
        {
            entity.spriteX = (int)spriteXUpDown.Value;
            changed = true;
            saveButton.Enabled = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aimationOrderTextBox_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(valid) {
                ignoreEvents = true;
                types[index] = new TerrainType(entity);
                typesListBox.Items[index] = types[index].Type;
                ignoreEvents = false;
                changed = false;
            }
        }

        public void Serialize(String path)
        {
            StreamWriter sw = new StreamWriter(path);
            XmlSerializer serializer = new XmlSerializer(typeof(List<TerrainType>));
            serializer.Serialize(sw, types);
        }

        public void Deserialize(String path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<TerrainType>));
            TextReader reader = new StreamReader(path);
            object obj = deserializer.Deserialize(reader);
            List<TerrainType> loadedTypes = (List<TerrainType>)obj;
            resetTypes(loadedTypes);
            reader.Close();
        }

        public void resetTypes(List<TerrainType> loadedTypes)
        {
            ignoreEvents = true;
            types.Clear();
            typesListBox.Items.Clear();
            foreach(TerrainType t in loadedTypes)
            {
                types.Add(new TerrainType(t));
                typesListBox.Items.Add(new TerrainType(t).Type);
            }
            ignoreEvents = false;
            index = 0;
            typesListBox.SelectedIndex = 0;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();

            if(fd.ShowDialog() == DialogResult.OK)
            {
                Serialize(fd.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                Deserialize(fd.FileName);
                
        }
    }
}
