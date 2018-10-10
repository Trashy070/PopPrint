namespace PopPrint
{
    partial class frmSysProfile
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogLocation = new System.Windows.Forms.TextBox();
            this.btnLogLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radMonthly = new System.Windows.Forms.RadioButton();
            this.radWeekly = new System.Windows.Forms.RadioButton();
            this.radDaily = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfileLocation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbArchiveFreq = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAttLocation = new System.Windows.Forms.TextBox();
            this.btnAttLocation = new System.Windows.Forms.Button();
            this.gbArchiveFreq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(559, 317);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logging Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logging Location";
            // 
            // txtLogLocation
            // 
            this.txtLogLocation.Location = new System.Drawing.Point(157, 52);
            this.txtLogLocation.Name = "txtLogLocation";
            this.txtLogLocation.Size = new System.Drawing.Size(288, 20);
            this.txtLogLocation.TabIndex = 3;
            // 
            // btnLogLocation
            // 
            this.btnLogLocation.Location = new System.Drawing.Point(443, 52);
            this.btnLogLocation.Name = "btnLogLocation";
            this.btnLogLocation.Size = new System.Drawing.Size(25, 20);
            this.btnLogLocation.TabIndex = 4;
            this.btnLogLocation.Text = "...";
            this.btnLogLocation.UseVisualStyleBackColor = true;
            this.btnLogLocation.Click += new System.EventHandler(this.btnLogLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Archiving Options";
            // 
            // radMonthly
            // 
            this.radMonthly.AutoSize = true;
            this.radMonthly.Location = new System.Drawing.Point(11, 19);
            this.radMonthly.Name = "radMonthly";
            this.radMonthly.Size = new System.Drawing.Size(62, 17);
            this.radMonthly.TabIndex = 7;
            this.radMonthly.TabStop = true;
            this.radMonthly.Tag = "ArcFreq";
            this.radMonthly.Text = "Monthly";
            this.radMonthly.UseVisualStyleBackColor = true;
            // 
            // radWeekly
            // 
            this.radWeekly.AutoSize = true;
            this.radWeekly.Location = new System.Drawing.Point(79, 19);
            this.radWeekly.Name = "radWeekly";
            this.radWeekly.Size = new System.Drawing.Size(61, 17);
            this.radWeekly.TabIndex = 8;
            this.radWeekly.TabStop = true;
            this.radWeekly.Tag = "ArcFreq";
            this.radWeekly.Text = "Weekly";
            this.radWeekly.UseVisualStyleBackColor = true;
            // 
            // radDaily
            // 
            this.radDaily.AutoSize = true;
            this.radDaily.Location = new System.Drawing.Point(146, 19);
            this.radDaily.Name = "radDaily";
            this.radDaily.Size = new System.Drawing.Size(48, 17);
            this.radDaily.TabIndex = 9;
            this.radDaily.TabStop = true;
            this.radDaily.Tag = "ArcFreq";
            this.radDaily.Text = "Daily";
            this.radDaily.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "System Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Default Profile Location";
            // 
            // txtProfileLocation
            // 
            this.txtProfileLocation.Location = new System.Drawing.Point(157, 172);
            this.txtProfileLocation.Name = "txtProfileLocation";
            this.txtProfileLocation.ReadOnly = true;
            this.txtProfileLocation.Size = new System.Drawing.Size(288, 20);
            this.txtProfileLocation.TabIndex = 12;
            this.txtProfileLocation.TextChanged += new System.EventHandler(this.txtProfileLocation_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(559, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbArchiveFreq
            // 
            this.gbArchiveFreq.Controls.Add(this.radDaily);
            this.gbArchiveFreq.Controls.Add(this.radMonthly);
            this.gbArchiveFreq.Controls.Add(this.radWeekly);
            this.gbArchiveFreq.Location = new System.Drawing.Point(34, 102);
            this.gbArchiveFreq.Name = "gbArchiveFreq";
            this.gbArchiveFreq.Size = new System.Drawing.Size(202, 47);
            this.gbArchiveFreq.TabIndex = 15;
            this.gbArchiveFreq.TabStop = false;
            this.gbArchiveFreq.Text = "Archive Frequency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Timer in Minutes";
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(157, 205);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(46, 20);
            this.txtTimer.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Temporary Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "(Temporary location where Attachments are stored)";
            // 
            // txtAttLocation
            // 
            this.txtAttLocation.Location = new System.Drawing.Point(157, 234);
            this.txtAttLocation.Name = "txtAttLocation";
            this.txtAttLocation.Size = new System.Drawing.Size(288, 20);
            this.txtAttLocation.TabIndex = 20;
            // 
            // btnAttLocation
            // 
            this.btnAttLocation.Location = new System.Drawing.Point(443, 234);
            this.btnAttLocation.Name = "btnAttLocation";
            this.btnAttLocation.Size = new System.Drawing.Size(25, 20);
            this.btnAttLocation.TabIndex = 21;
            this.btnAttLocation.Text = "...";
            this.btnAttLocation.UseVisualStyleBackColor = true;
            this.btnAttLocation.Click += new System.EventHandler(this.btnAttLocation_Click);
            // 
            // frmSysProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 352);
            this.Controls.Add(this.btnAttLocation);
            this.Controls.Add(this.txtAttLocation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbArchiveFreq);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProfileLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogLocation);
            this.Controls.Add(this.txtLogLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmSysProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Profile";
            this.Load += new System.EventHandler(this.frmSysProfile_Load);
            this.gbArchiveFreq.ResumeLayout(false);
            this.gbArchiveFreq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogLocation;
        private System.Windows.Forms.Button btnLogLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radMonthly;
        private System.Windows.Forms.RadioButton radWeekly;
        private System.Windows.Forms.RadioButton radDaily;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfileLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbArchiveFreq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAttLocation;
        private System.Windows.Forms.Button btnAttLocation;
    }
}