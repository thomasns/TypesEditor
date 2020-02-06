namespace TerrainTypeBuilder
{
    partial class NeighboringTiles
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
            if (disposing && (components != null))
            {
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.topLeft = new System.Windows.Forms.CheckBox();
            this.topMiddle = new System.Windows.Forms.CheckBox();
            this.topRight = new System.Windows.Forms.CheckBox();
            this.midRight = new System.Windows.Forms.CheckBox();
            this.midLeft = new System.Windows.Forms.CheckBox();
            this.bottomRight = new System.Windows.Forms.CheckBox();
            this.bottomMiddle = new System.Windows.Forms.CheckBox();
            this.bottomLeft = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spriteX = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.spriteY = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.requireAll = new System.Windows.Forms.CheckBox();
            this.onlyDirectNeighbors = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.spriteX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteY)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 0;
            // 
            // topLeft
            // 
            this.topLeft.AutoSize = true;
            this.topLeft.Location = new System.Drawing.Point(261, 11);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(15, 14);
            this.topLeft.TabIndex = 1;
            this.topLeft.UseVisualStyleBackColor = true;
            // 
            // topMiddle
            // 
            this.topMiddle.AutoSize = true;
            this.topMiddle.Location = new System.Drawing.Point(282, 11);
            this.topMiddle.Name = "topMiddle";
            this.topMiddle.Size = new System.Drawing.Size(15, 14);
            this.topMiddle.TabIndex = 2;
            this.topMiddle.UseVisualStyleBackColor = true;
            // 
            // topRight
            // 
            this.topRight.AutoSize = true;
            this.topRight.Location = new System.Drawing.Point(303, 11);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(15, 14);
            this.topRight.TabIndex = 3;
            this.topRight.UseVisualStyleBackColor = true;
            // 
            // midRight
            // 
            this.midRight.AutoSize = true;
            this.midRight.Location = new System.Drawing.Point(303, 31);
            this.midRight.Name = "midRight";
            this.midRight.Size = new System.Drawing.Size(15, 14);
            this.midRight.TabIndex = 5;
            this.midRight.UseVisualStyleBackColor = true;
            // 
            // midLeft
            // 
            this.midLeft.AutoSize = true;
            this.midLeft.Location = new System.Drawing.Point(261, 31);
            this.midLeft.Name = "midLeft";
            this.midLeft.Size = new System.Drawing.Size(15, 14);
            this.midLeft.TabIndex = 4;
            this.midLeft.UseVisualStyleBackColor = true;
            this.midLeft.CheckedChanged += new System.EventHandler(this.nidLeft_CheckedChanged);
            // 
            // bottomRight
            // 
            this.bottomRight.AutoSize = true;
            this.bottomRight.Location = new System.Drawing.Point(303, 51);
            this.bottomRight.Name = "bottomRight";
            this.bottomRight.Size = new System.Drawing.Size(15, 14);
            this.bottomRight.TabIndex = 8;
            this.bottomRight.UseVisualStyleBackColor = true;
            // 
            // bottomMiddle
            // 
            this.bottomMiddle.AutoSize = true;
            this.bottomMiddle.Location = new System.Drawing.Point(282, 51);
            this.bottomMiddle.Name = "bottomMiddle";
            this.bottomMiddle.Size = new System.Drawing.Size(15, 14);
            this.bottomMiddle.TabIndex = 7;
            this.bottomMiddle.UseVisualStyleBackColor = true;
            // 
            // bottomLeft
            // 
            this.bottomLeft.AutoSize = true;
            this.bottomLeft.Location = new System.Drawing.Point(261, 51);
            this.bottomLeft.Name = "bottomLeft";
            this.bottomLeft.Size = new System.Drawing.Size(15, 14);
            this.bottomLeft.TabIndex = 6;
            this.bottomLeft.UseVisualStyleBackColor = true;
            this.bottomLeft.CheckedChanged += new System.EventHandler(this.bottomLeft_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "SpriteX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SpriteY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // spriteX
            // 
            this.spriteX.Location = new System.Drawing.Point(198, 120);
            this.spriteX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.spriteX.Name = "spriteX";
            this.spriteX.Size = new System.Drawing.Size(120, 20);
            this.spriteX.TabIndex = 11;
            this.spriteX.ValueChanged += new System.EventHandler(this.spriteX_ValueChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(140, 185);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // spriteY
            // 
            this.spriteY.Location = new System.Drawing.Point(198, 147);
            this.spriteY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.spriteY.Name = "spriteY";
            this.spriteY.Size = new System.Drawing.Size(120, 20);
            this.spriteY.TabIndex = 13;
            this.spriteY.ValueChanged += new System.EventHandler(this.spriteY_ValueChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(140, 214);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Remove";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(230, 214);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 15;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // requireAll
            // 
            this.requireAll.AutoSize = true;
            this.requireAll.Checked = true;
            this.requireAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.requireAll.Location = new System.Drawing.Point(138, 72);
            this.requireAll.Name = "requireAll";
            this.requireAll.Size = new System.Drawing.Size(77, 17);
            this.requireAll.TabIndex = 17;
            this.requireAll.Text = "Require All";
            this.requireAll.UseVisualStyleBackColor = true;
            this.requireAll.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // onlyDirectNeighbors
            // 
            this.onlyDirectNeighbors.AutoSize = true;
            this.onlyDirectNeighbors.Location = new System.Drawing.Point(138, 95);
            this.onlyDirectNeighbors.Name = "onlyDirectNeighbors";
            this.onlyDirectNeighbors.Size = new System.Drawing.Size(160, 17);
            this.onlyDirectNeighbors.TabIndex = 18;
            this.onlyDirectNeighbors.Text = "Only Count Direct Neighbors";
            this.onlyDirectNeighbors.UseVisualStyleBackColor = true;
            this.onlyDirectNeighbors.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // NeighboringTiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 251);
            this.Controls.Add(this.onlyDirectNeighbors);
            this.Controls.Add(this.requireAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.spriteY);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.spriteX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bottomRight);
            this.Controls.Add(this.bottomMiddle);
            this.Controls.Add(this.bottomLeft);
            this.Controls.Add(this.midRight);
            this.Controls.Add(this.midLeft);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.topMiddle);
            this.Controls.Add(this.topLeft);
            this.Controls.Add(this.listBox1);
            this.Name = "NeighboringTiles";
            this.Text = "NeighboringTiles";
            ((System.ComponentModel.ISupportInitialize)(this.spriteX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox topLeft;
        private System.Windows.Forms.CheckBox topMiddle;
        private System.Windows.Forms.CheckBox topRight;
        private System.Windows.Forms.CheckBox midRight;
        private System.Windows.Forms.CheckBox midLeft;
        private System.Windows.Forms.CheckBox bottomRight;
        private System.Windows.Forms.CheckBox bottomMiddle;
        private System.Windows.Forms.CheckBox bottomLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spriteX;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown spriteY;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox requireAll;
        private System.Windows.Forms.CheckBox onlyDirectNeighbors;
    }
}