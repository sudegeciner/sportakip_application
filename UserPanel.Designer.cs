namespace sportakip_application
{
    partial class UserPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSaveWorkout = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deletePic2 = new System.Windows.Forms.Button();
            this.addPic2 = new System.Windows.Forms.Button();
            this.deletePic1 = new System.Windows.Forms.Button();
            this.addPic1 = new System.Windows.Forms.Button();
            this.pbAfter = new System.Windows.Forms.PictureBox();
            this.pbBefore = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBefore)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btnSaveWorkout);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Exercises";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // btnSaveWorkout
            // 
            this.btnSaveWorkout.Location = new System.Drawing.Point(341, 38);
            this.btnSaveWorkout.Name = "btnSaveWorkout";
            this.btnSaveWorkout.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWorkout.TabIndex = 0;
            this.btnSaveWorkout.Text = "Save";
            this.btnSaveWorkout.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deletePic2);
            this.tabPage2.Controls.Add(this.addPic2);
            this.tabPage2.Controls.Add(this.deletePic1);
            this.tabPage2.Controls.Add(this.addPic1);
            this.tabPage2.Controls.Add(this.pbAfter);
            this.tabPage2.Controls.Add(this.pbBefore);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Progress";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deletePic2
            // 
            this.deletePic2.Location = new System.Drawing.Point(516, 317);
            this.deletePic2.Name = "deletePic2";
            this.deletePic2.Size = new System.Drawing.Size(75, 23);
            this.deletePic2.TabIndex = 5;
            this.deletePic2.Text = "Remove";
            this.deletePic2.UseVisualStyleBackColor = true;
            this.deletePic2.Click += new System.EventHandler(this.deletePic2_Click);
            // 
            // addPic2
            // 
            this.addPic2.Location = new System.Drawing.Point(417, 317);
            this.addPic2.Name = "addPic2";
            this.addPic2.Size = new System.Drawing.Size(75, 23);
            this.addPic2.TabIndex = 4;
            this.addPic2.Text = "Upload";
            this.addPic2.UseVisualStyleBackColor = true;
            this.addPic2.Click += new System.EventHandler(this.button3_Click);
            // 
            // deletePic1
            // 
            this.deletePic1.Location = new System.Drawing.Point(336, 317);
            this.deletePic1.Name = "deletePic1";
            this.deletePic1.Size = new System.Drawing.Size(75, 23);
            this.deletePic1.TabIndex = 3;
            this.deletePic1.Text = "Remove";
            this.deletePic1.UseVisualStyleBackColor = true;
            this.deletePic1.Click += new System.EventHandler(this.deletePic1_Click);
            // 
            // addPic1
            // 
            this.addPic1.Location = new System.Drawing.Point(237, 317);
            this.addPic1.Name = "addPic1";
            this.addPic1.Size = new System.Drawing.Size(75, 23);
            this.addPic1.TabIndex = 2;
            this.addPic1.Text = "Upload";
            this.addPic1.UseVisualStyleBackColor = true;
            this.addPic1.Click += new System.EventHandler(this.addPic1_Click);
            // 
            // pbAfter
            // 
            this.pbAfter.Location = new System.Drawing.Point(417, 67);
            this.pbAfter.Name = "pbAfter";
            this.pbAfter.Size = new System.Drawing.Size(174, 244);
            this.pbAfter.TabIndex = 1;
            this.pbAfter.TabStop = false;
            // 
            // pbBefore
            // 
            this.pbBefore.Location = new System.Drawing.Point(237, 67);
            this.pbBefore.Name = "pbBefore";
            this.pbBefore.Size = new System.Drawing.Size(174, 244);
            this.pbBefore.TabIndex = 0;
            this.pbBefore.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBefore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSaveWorkout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbAfter;
        private System.Windows.Forms.PictureBox pbBefore;
        private System.Windows.Forms.Button deletePic2;
        private System.Windows.Forms.Button addPic2;
        private System.Windows.Forms.Button deletePic1;
        private System.Windows.Forms.Button addPic1;
    }
}