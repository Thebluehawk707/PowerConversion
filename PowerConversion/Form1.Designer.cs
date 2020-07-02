namespace PowerConversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_mW2dBm = new System.Windows.Forms.Button();
            this.btn_dBm2mW = new System.Windows.Forms.Button();
            this.lbl_mW2dBm = new System.Windows.Forms.Label();
            this.ud_mW2dBm = new System.Windows.Forms.NumericUpDown();
            this.ud_dBm2mW = new System.Windows.Forms.NumericUpDown();
            this.lbl_dBm2mW = new System.Windows.Forms.Label();
            this.BoxOfConversions = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ud_mW2dBm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_dBm2mW)).BeginInit();
            this.BoxOfConversions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mW2dBm
            // 
            this.btn_mW2dBm.Location = new System.Drawing.Point(6, 21);
            this.btn_mW2dBm.Name = "btn_mW2dBm";
            this.btn_mW2dBm.Size = new System.Drawing.Size(97, 38);
            this.btn_mW2dBm.TabIndex = 0;
            this.btn_mW2dBm.Text = "mW -> dBm";
            this.btn_mW2dBm.UseVisualStyleBackColor = true;
            this.btn_mW2dBm.Click += new System.EventHandler(this.btn_mW2dBm_Click);
            // 
            // btn_dBm2mW
            // 
            this.btn_dBm2mW.Location = new System.Drawing.Point(6, 65);
            this.btn_dBm2mW.Name = "btn_dBm2mW";
            this.btn_dBm2mW.Size = new System.Drawing.Size(97, 38);
            this.btn_dBm2mW.TabIndex = 1;
            this.btn_dBm2mW.Text = "dBm -> mW";
            this.btn_dBm2mW.UseVisualStyleBackColor = true;
            this.btn_dBm2mW.Click += new System.EventHandler(this.btn_dBm2mW_Click);
            // 
            // lbl_mW2dBm
            // 
            this.lbl_mW2dBm.AutoSize = true;
            this.lbl_mW2dBm.Location = new System.Drawing.Point(235, 32);
            this.lbl_mW2dBm.Name = "lbl_mW2dBm";
            this.lbl_mW2dBm.Size = new System.Drawing.Size(16, 17);
            this.lbl_mW2dBm.TabIndex = 2;
            this.lbl_mW2dBm.Text = "0";
            // 
            // ud_mW2dBm
            // 
            this.ud_mW2dBm.DecimalPlaces = 6;
            this.ud_mW2dBm.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.ud_mW2dBm.Location = new System.Drawing.Point(109, 30);
            this.ud_mW2dBm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ud_mW2dBm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.ud_mW2dBm.Name = "ud_mW2dBm";
            this.ud_mW2dBm.Size = new System.Drawing.Size(120, 22);
            this.ud_mW2dBm.TabIndex = 3;
            this.ud_mW2dBm.Value = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.ud_mW2dBm.ValueChanged += new System.EventHandler(this.ud_mW2dBm_ValueChanged);
            // 
            // ud_dBm2mW
            // 
            this.ud_dBm2mW.DecimalPlaces = 2;
            this.ud_dBm2mW.Location = new System.Drawing.Point(109, 74);
            this.ud_dBm2mW.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.ud_dBm2mW.Name = "ud_dBm2mW";
            this.ud_dBm2mW.Size = new System.Drawing.Size(120, 22);
            this.ud_dBm2mW.TabIndex = 4;
            this.ud_dBm2mW.ValueChanged += new System.EventHandler(this.ud_dBm2mW_ValueChanged);
            // 
            // lbl_dBm2mW
            // 
            this.lbl_dBm2mW.AutoSize = true;
            this.lbl_dBm2mW.Location = new System.Drawing.Point(235, 76);
            this.lbl_dBm2mW.Name = "lbl_dBm2mW";
            this.lbl_dBm2mW.Size = new System.Drawing.Size(16, 17);
            this.lbl_dBm2mW.TabIndex = 5;
            this.lbl_dBm2mW.Text = "0";
            // 
            // BoxOfConversions
            // 
            this.BoxOfConversions.Controls.Add(this.btn_mW2dBm);
            this.BoxOfConversions.Controls.Add(this.lbl_dBm2mW);
            this.BoxOfConversions.Controls.Add(this.ud_mW2dBm);
            this.BoxOfConversions.Controls.Add(this.ud_dBm2mW);
            this.BoxOfConversions.Controls.Add(this.lbl_mW2dBm);
            this.BoxOfConversions.Controls.Add(this.btn_dBm2mW);
            this.BoxOfConversions.Location = new System.Drawing.Point(396, 132);
            this.BoxOfConversions.MinimumSize = new System.Drawing.Size(360, 116);
            this.BoxOfConversions.Name = "BoxOfConversions";
            this.BoxOfConversions.Size = new System.Drawing.Size(360, 116);
            this.BoxOfConversions.TabIndex = 6;
            this.BoxOfConversions.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 448);
            this.Controls.Add(this.BoxOfConversions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(385, 230);
            this.Name = "Form1";
            this.Text = "Power Conversion";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ud_mW2dBm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_dBm2mW)).EndInit();
            this.BoxOfConversions.ResumeLayout(false);
            this.BoxOfConversions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mW2dBm;
        private System.Windows.Forms.Button btn_dBm2mW;
        private System.Windows.Forms.Label lbl_mW2dBm;
        private System.Windows.Forms.NumericUpDown ud_mW2dBm;
        private System.Windows.Forms.NumericUpDown ud_dBm2mW;
        private System.Windows.Forms.Label lbl_dBm2mW;
        private System.Windows.Forms.GroupBox BoxOfConversions;
    }
}

