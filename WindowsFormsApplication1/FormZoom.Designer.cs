namespace WindowsFormsApplication1
{
    partial class FormZoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZoom));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSketch = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.thickness = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLoad = new System.Windows.Forms.Button();
            this.lblIndicator = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 93);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(654, 347);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(654, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 347);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btSketch
            // 
            this.btSketch.Image = ((System.Drawing.Image)(resources.GetObject("btSketch.Image")));
            this.btSketch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSketch.Location = new System.Drawing.Point(12, 23);
            this.btSketch.Name = "btSketch";
            this.btSketch.Size = new System.Drawing.Size(47, 45);
            this.btSketch.TabIndex = 28;
            this.btSketch.UseVisualStyleBackColor = true;
            this.btSketch.Click += new System.EventHandler(this.btSketch_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(528, 453);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(118, 55);
            this.btSave.TabIndex = 29;
            this.btSave.Text = "Save Image";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(441, 514);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 25);
            this.textBox3.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "File Name";
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(585, 514);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(61, 25);
            this.btClear.TabIndex = 32;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // thickness
            // 
            this.thickness.Location = new System.Drawing.Point(65, 23);
            this.thickness.Maximum = 20;
            this.thickness.Minimum = 1;
            this.thickness.Name = "thickness";
            this.thickness.Size = new System.Drawing.Size(104, 45);
            this.thickness.TabIndex = 36;
            this.thickness.Value = 1;
            this.thickness.Scroll += new System.EventHandler(this.tbthickness_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Thickness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "20";
            // 
            // btLoad
            // 
            this.btLoad.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.btLoad.Location = new System.Drawing.Point(12, 453);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(137, 49);
            this.btLoad.TabIndex = 40;
            this.btLoad.Text = "Load Image";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.Location = new System.Drawing.Point(219, 34);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(13, 13);
            this.lblIndicator.TabIndex = 41;
            this.lblIndicator.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label4.Location = new System.Drawing.Point(374, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 54);
            this.label4.TabIndex = 42;
            this.label4.Text = "SnapSketch Tool";
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.bt_clear.Location = new System.Drawing.Point(166, 453);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(137, 49);
            this.bt_clear.TabIndex = 43;
            this.bt_clear.Text = "Clear Image";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // FormZoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 551);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIndicator);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thickness);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btSketch);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormZoom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SnapSketch Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSketch;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar thickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Label lblIndicator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_clear;
    }
}

