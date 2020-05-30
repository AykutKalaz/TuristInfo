namespace TuristInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtnOrman = new System.Windows.Forms.RadioButton();
            this.rdBtnDogal = new System.Windows.Forms.RadioButton();
            this.rdnBtnTarihi = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdnBtn1 = new System.Windows.Forms.RadioButton();
            this.rdnBtn2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nasıl yerler görmek istersiniz? (Orman, doğal, tarihi)";
            // 
            // rdBtnOrman
            // 
            this.rdBtnOrman.AutoSize = true;
            this.rdBtnOrman.Location = new System.Drawing.Point(52, 69);
            this.rdBtnOrman.Name = "rdBtnOrman";
            this.rdBtnOrman.Size = new System.Drawing.Size(56, 17);
            this.rdBtnOrman.TabIndex = 2;
            this.rdBtnOrman.TabStop = true;
            this.rdBtnOrman.Text = "Orman";
            this.rdBtnOrman.UseVisualStyleBackColor = true;
            this.rdBtnOrman.CheckedChanged += new System.EventHandler(this.rdBtnOrman_CheckedChanged);
            // 
            // rdBtnDogal
            // 
            this.rdBtnDogal.AutoSize = true;
            this.rdBtnDogal.Location = new System.Drawing.Point(218, 69);
            this.rdBtnDogal.Name = "rdBtnDogal";
            this.rdBtnDogal.Size = new System.Drawing.Size(53, 17);
            this.rdBtnDogal.TabIndex = 3;
            this.rdBtnDogal.TabStop = true;
            this.rdBtnDogal.Text = "Doğal";
            this.rdBtnDogal.UseVisualStyleBackColor = true;
            this.rdBtnDogal.CheckedChanged += new System.EventHandler(this.rdBtnDogal_CheckedChanged);
            // 
            // rdnBtnTarihi
            // 
            this.rdnBtnTarihi.AutoSize = true;
            this.rdnBtnTarihi.Location = new System.Drawing.Point(377, 69);
            this.rdnBtnTarihi.Name = "rdnBtnTarihi";
            this.rdnBtnTarihi.Size = new System.Drawing.Size(81, 17);
            this.rdnBtnTarihi.TabIndex = 4;
            this.rdnBtnTarihi.TabStop = true;
            this.rdnBtnTarihi.Text = "Tarihi Yerler";
            this.rdnBtnTarihi.UseVisualStyleBackColor = true;
            this.rdnBtnTarihi.CheckedChanged += new System.EventHandler(this.rdnBtnTarihi_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 5;
            // 
            // rdnBtn1
            // 
            this.rdnBtn1.AutoSize = true;
            this.rdnBtn1.Location = new System.Drawing.Point(29, 79);
            this.rdnBtn1.Name = "rdnBtn1";
            this.rdnBtn1.Size = new System.Drawing.Size(14, 13);
            this.rdnBtn1.TabIndex = 6;
            this.rdnBtn1.TabStop = true;
            this.rdnBtn1.UseVisualStyleBackColor = true;
            // 
            // rdnBtn2
            // 
            this.rdnBtn2.AutoSize = true;
            this.rdnBtn2.Location = new System.Drawing.Point(234, 79);
            this.rdnBtn2.Name = "rdnBtn2";
            this.rdnBtn2.Size = new System.Drawing.Size(14, 13);
            this.rdnBtn2.TabIndex = 7;
            this.rdnBtn2.TabStop = true;
            this.rdnBtn2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnBtn2);
            this.groupBox1.Controls.Add(this.rdnBtn1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(403, 247);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 9;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 282);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdnBtnTarihi);
            this.Controls.Add(this.rdBtnDogal);
            this.Controls.Add(this.rdBtnOrman);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtnOrman;
        private System.Windows.Forms.RadioButton rdBtnDogal;
        private System.Windows.Forms.RadioButton rdnBtnTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdnBtn1;
        private System.Windows.Forms.RadioButton rdnBtn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGoster;
    }
}

