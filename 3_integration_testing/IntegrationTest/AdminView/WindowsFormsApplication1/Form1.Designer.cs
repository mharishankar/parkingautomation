namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label26 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonGenerateGC = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericFloors = new System.Windows.Forms.NumericUpDown();
            this.buttonPopulateGrid = new System.Windows.Forms.Button();
            this.numericSpots = new System.Windows.Forms.NumericUpDown();
            this.buttonClearGF = new System.Windows.Forms.Button();
            this.buttonDestroyGF = new System.Windows.Forms.Button();
            this.buttonSaveGF = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpots)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(16, 13);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(425, 29);
            this.label26.TabIndex = 7;
            this.label26.Text = "AutoMatedPark Administrator Panel";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonSaveGF);
            this.tabPage5.Controls.Add(this.buttonDestroyGF);
            this.tabPage5.Controls.Add(this.buttonClearGF);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.buttonGenerateGC);
            this.tabPage5.Controls.Add(this.listBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(895, 473);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Garage Configuration";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(483, 342);
            this.listBox1.TabIndex = 6;
            // 
            // buttonGenerateGC
            // 
            this.buttonGenerateGC.Location = new System.Drawing.Point(537, 440);
            this.buttonGenerateGC.Name = "buttonGenerateGC";
            this.buttonGenerateGC.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateGC.TabIndex = 7;
            this.buttonGenerateGC.Text = "Run Test";
            this.buttonGenerateGC.UseVisualStyleBackColor = true;
            this.buttonGenerateGC.Click += new System.EventHandler(this.buttonGenerateGC_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericSpots);
            this.groupBox4.Controls.Add(this.buttonPopulateGrid);
            this.groupBox4.Controls.Add(this.numericFloors);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(524, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 342);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "# of Floors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "# of Spots";
            // 
            // numericFloors
            // 
            this.numericFloors.Location = new System.Drawing.Point(73, 31);
            this.numericFloors.Name = "numericFloors";
            this.numericFloors.Size = new System.Drawing.Size(63, 20);
            this.numericFloors.TabIndex = 4;
            // 
            // buttonPopulateGrid
            // 
            this.buttonPopulateGrid.Location = new System.Drawing.Point(13, 303);
            this.buttonPopulateGrid.Name = "buttonPopulateGrid";
            this.buttonPopulateGrid.Size = new System.Drawing.Size(92, 23);
            this.buttonPopulateGrid.TabIndex = 6;
            this.buttonPopulateGrid.Text = "PopulateGrid";
            this.buttonPopulateGrid.UseVisualStyleBackColor = true;
 //           this.buttonPopulateGrid.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericSpots
            // 
            this.numericSpots.Location = new System.Drawing.Point(73, 68);
            this.numericSpots.Name = "numericSpots";
            this.numericSpots.Size = new System.Drawing.Size(63, 20);
            this.numericSpots.TabIndex = 5;
            // 
            // buttonClearGF
            // 
            this.buttonClearGF.Location = new System.Drawing.Point(618, 440);
            this.buttonClearGF.Name = "buttonClearGF";
            this.buttonClearGF.Size = new System.Drawing.Size(75, 23);
            this.buttonClearGF.TabIndex = 9;
            this.buttonClearGF.Text = "Clear";
            this.buttonClearGF.UseVisualStyleBackColor = true;
            this.buttonClearGF.Click += new System.EventHandler(this.buttonClearGF_Click);
            // 
            // buttonDestroyGF
            // 
            this.buttonDestroyGF.Location = new System.Drawing.Point(700, 440);
            this.buttonDestroyGF.Name = "buttonDestroyGF";
            this.buttonDestroyGF.Size = new System.Drawing.Size(75, 23);
            this.buttonDestroyGF.TabIndex = 10;
            this.buttonDestroyGF.Text = "Destory";
            this.buttonDestroyGF.UseVisualStyleBackColor = true;
            this.buttonDestroyGF.Click += new System.EventHandler(this.buttonDestroyGF_Click);
            // 
            // buttonSaveGF
            // 
            this.buttonSaveGF.Location = new System.Drawing.Point(781, 440);
            this.buttonSaveGF.Name = "buttonSaveGF";
            this.buttonSaveGF.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveGF.TabIndex = 11;
            this.buttonSaveGF.Text = "Save";
            this.buttonSaveGF.UseVisualStyleBackColor = true;
   //         this.buttonSaveGF.Click += new System.EventHandler(this.buttonSaveGF_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(895, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hardware Status";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter and Exit Cameras";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(460, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enterance camera status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Exit camera status : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Last diagnostic :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Run diagnostic now";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(249, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Operational";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(249, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Operational";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(252, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "4/20/12";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spot Sensors Array";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(460, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 125);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Spot sensor array status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Last diagnostic : ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Run diagnostic now";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(249, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Operational";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(252, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "4/20/12";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 150);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elevator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Elevator status :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Last diagnostic :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Run diagnostic now";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(249, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Operational";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(249, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 17);
            this.label18.TabIndex = 10;
            this.label18.Text = "4/20/12";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 499);
            this.tabControl1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 569);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.tabPage5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpots)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonSaveGF;
        private System.Windows.Forms.Button buttonDestroyGF;
        private System.Windows.Forms.Button buttonClearGF;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericSpots;
        private System.Windows.Forms.Button buttonPopulateGrid;
        private System.Windows.Forms.NumericUpDown numericFloors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerateGC;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

