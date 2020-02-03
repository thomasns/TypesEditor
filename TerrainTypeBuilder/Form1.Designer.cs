namespace TerrainTypeBuilder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typesListBox = new System.Windows.Forms.ListBox();
            this.animaitedCheckBox = new System.Windows.Forms.CheckBox();
            this.impassableCheckBox = new System.Windows.Forms.CheckBox();
            this.spriteXUpDown = new System.Windows.Forms.NumericUpDown();
            this.animationOrderLabel = new System.Windows.Forms.Label();
            this.aimationOrderTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spriteYUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.spriteSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.movementCostUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.spriteXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementCostUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typesListBox
            // 
            this.typesListBox.FormattingEnabled = true;
            this.typesListBox.Location = new System.Drawing.Point(12, 27);
            this.typesListBox.Name = "typesListBox";
            this.typesListBox.Size = new System.Drawing.Size(120, 277);
            this.typesListBox.TabIndex = 0;
            this.typesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // animaitedCheckBox
            // 
            this.animaitedCheckBox.AutoSize = true;
            this.animaitedCheckBox.Enabled = false;
            this.animaitedCheckBox.Location = new System.Drawing.Point(179, 200);
            this.animaitedCheckBox.Name = "animaitedCheckBox";
            this.animaitedCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.animaitedCheckBox.Size = new System.Drawing.Size(66, 17);
            this.animaitedCheckBox.TabIndex = 7;
            this.animaitedCheckBox.Text = "Aimaited";
            this.animaitedCheckBox.UseVisualStyleBackColor = true;
            this.animaitedCheckBox.CheckedChanged += new System.EventHandler(this.animaitedCheckBox_CheckedChanged);
            // 
            // impassableCheckBox
            // 
            this.impassableCheckBox.AutoSize = true;
            this.impassableCheckBox.Enabled = false;
            this.impassableCheckBox.Location = new System.Drawing.Point(179, 63);
            this.impassableCheckBox.Name = "impassableCheckBox";
            this.impassableCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.impassableCheckBox.Size = new System.Drawing.Size(79, 17);
            this.impassableCheckBox.TabIndex = 2;
            this.impassableCheckBox.Text = "Impassable";
            this.impassableCheckBox.UseVisualStyleBackColor = true;
            this.impassableCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // spriteXUpDown
            // 
            this.spriteXUpDown.Enabled = false;
            this.spriteXUpDown.Location = new System.Drawing.Point(179, 116);
            this.spriteXUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.spriteXUpDown.Name = "spriteXUpDown";
            this.spriteXUpDown.Size = new System.Drawing.Size(120, 20);
            this.spriteXUpDown.TabIndex = 4;
            this.spriteXUpDown.ValueChanged += new System.EventHandler(this.spriteXUpDown_ValueChanged);
            // 
            // animationOrderLabel
            // 
            this.animationOrderLabel.AutoSize = true;
            this.animationOrderLabel.Enabled = false;
            this.animationOrderLabel.Location = new System.Drawing.Point(305, 229);
            this.animationOrderLabel.Name = "animationOrderLabel";
            this.animationOrderLabel.Size = new System.Drawing.Size(82, 13);
            this.animationOrderLabel.TabIndex = 6;
            this.animationOrderLabel.Text = "Animation Order";
            // 
            // aimationOrderTextBox
            // 
            this.aimationOrderTextBox.Enabled = false;
            this.aimationOrderTextBox.Location = new System.Drawing.Point(179, 225);
            this.aimationOrderTextBox.Name = "aimationOrderTextBox";
            this.aimationOrderTextBox.Size = new System.Drawing.Size(120, 20);
            this.aimationOrderTextBox.TabIndex = 8;
            this.aimationOrderTextBox.TextChanged += new System.EventHandler(this.aimationOrderTextBox_TextChanged);
            this.aimationOrderTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aimationOrderTextBox_KeyDown);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 309);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 338);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 367);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(120, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(179, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(305, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "SpriteX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sprite Y";
            // 
            // spriteYUpDown
            // 
            this.spriteYUpDown.Enabled = false;
            this.spriteYUpDown.Location = new System.Drawing.Point(179, 144);
            this.spriteYUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.spriteYUpDown.Name = "spriteYUpDown";
            this.spriteYUpDown.Size = new System.Drawing.Size(120, 20);
            this.spriteYUpDown.TabIndex = 5;
            this.spriteYUpDown.ValueChanged += new System.EventHandler(this.spriteYUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sprite Size";
            // 
            // spriteSizeUpDown
            // 
            this.spriteSizeUpDown.Enabled = false;
            this.spriteSizeUpDown.Location = new System.Drawing.Point(179, 172);
            this.spriteSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spriteSizeUpDown.Name = "spriteSizeUpDown";
            this.spriteSizeUpDown.Size = new System.Drawing.Size(120, 20);
            this.spriteSizeUpDown.TabIndex = 6;
            this.spriteSizeUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spriteSizeUpDown.ValueChanged += new System.EventHandler(this.spriteSizeUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Movement Cost";
            // 
            // movementCostUpDown
            // 
            this.movementCostUpDown.Enabled = false;
            this.movementCostUpDown.Location = new System.Drawing.Point(179, 88);
            this.movementCostUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.movementCostUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.movementCostUpDown.Name = "movementCostUpDown";
            this.movementCostUpDown.Size = new System.Drawing.Size(120, 20);
            this.movementCostUpDown.TabIndex = 3;
            this.movementCostUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.movementCostUpDown.ValueChanged += new System.EventHandler(this.movementCostUpDown_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStrip
            // 
            this.menuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(37, 20);
            this.menuStrip.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 413);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.movementCostUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spriteSizeUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.spriteYUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.aimationOrderTextBox);
            this.Controls.Add(this.animationOrderLabel);
            this.Controls.Add(this.spriteXUpDown);
            this.Controls.Add(this.impassableCheckBox);
            this.Controls.Add(this.animaitedCheckBox);
            this.Controls.Add(this.typesListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.spriteXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementCostUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox typesListBox;
        private System.Windows.Forms.CheckBox animaitedCheckBox;
        private System.Windows.Forms.CheckBox impassableCheckBox;
        private System.Windows.Forms.NumericUpDown spriteXUpDown;
        private System.Windows.Forms.Label animationOrderLabel;
        private System.Windows.Forms.TextBox aimationOrderTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spriteYUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown spriteSizeUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown movementCostUpDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

