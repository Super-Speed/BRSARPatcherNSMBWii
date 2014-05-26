namespace BRSARFilePatcher
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BRSARGroupBox = new System.Windows.Forms.GroupBox();
            this.BRSAROpenButton = new System.Windows.Forms.Button();
            this.BRSAROpenTextbox = new System.Windows.Forms.TextBox();
            this.MusicGroupBox = new System.Windows.Forms.GroupBox();
            this.MusicComboBox = new System.Windows.Forms.ComboBox();
            this.BRSTMGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BRSTMOpenButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BRSARSaveButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.brstmfileloaded = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HexTextbox = new System.Windows.Forms.TextBox();
            this.BytesTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BRSARGroupBox.SuspendLayout();
            this.MusicGroupBox.SuspendLayout();
            this.BRSTMGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BRSARGroupBox
            // 
            this.BRSARGroupBox.Controls.Add(this.BRSAROpenButton);
            this.BRSARGroupBox.Controls.Add(this.BRSAROpenTextbox);
            this.BRSARGroupBox.Location = new System.Drawing.Point(6, 7);
            this.BRSARGroupBox.Name = "BRSARGroupBox";
            this.BRSARGroupBox.Size = new System.Drawing.Size(326, 50);
            this.BRSARGroupBox.TabIndex = 0;
            this.BRSARGroupBox.TabStop = false;
            this.BRSARGroupBox.Text = "BRSAR";
            // 
            // BRSAROpenButton
            // 
            this.BRSAROpenButton.Location = new System.Drawing.Point(245, 18);
            this.BRSAROpenButton.Name = "BRSAROpenButton";
            this.BRSAROpenButton.Size = new System.Drawing.Size(75, 23);
            this.BRSAROpenButton.TabIndex = 1;
            this.BRSAROpenButton.Text = "Open...";
            this.BRSAROpenButton.UseVisualStyleBackColor = true;
            this.BRSAROpenButton.Click += new System.EventHandler(this.BRSAROpenButton_Click);
            // 
            // BRSAROpenTextbox
            // 
            this.BRSAROpenTextbox.Location = new System.Drawing.Point(7, 20);
            this.BRSAROpenTextbox.Name = "BRSAROpenTextbox";
            this.BRSAROpenTextbox.ReadOnly = true;
            this.BRSAROpenTextbox.Size = new System.Drawing.Size(232, 20);
            this.BRSAROpenTextbox.TabIndex = 0;
            // 
            // MusicGroupBox
            // 
            this.MusicGroupBox.Controls.Add(this.MusicComboBox);
            this.MusicGroupBox.Enabled = false;
            this.MusicGroupBox.Location = new System.Drawing.Point(6, 63);
            this.MusicGroupBox.Name = "MusicGroupBox";
            this.MusicGroupBox.Size = new System.Drawing.Size(332, 54);
            this.MusicGroupBox.TabIndex = 1;
            this.MusicGroupBox.TabStop = false;
            this.MusicGroupBox.Text = "Music Track";
            // 
            // MusicComboBox
            // 
            this.MusicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MusicComboBox.FormattingEnabled = true;
            this.MusicComboBox.Location = new System.Drawing.Point(6, 19);
            this.MusicComboBox.Name = "MusicComboBox";
            this.MusicComboBox.Size = new System.Drawing.Size(314, 21);
            this.MusicComboBox.TabIndex = 0;
            // 
            // BRSTMGroupBox
            // 
            this.BRSTMGroupBox.Controls.Add(this.label5);
            this.BRSTMGroupBox.Controls.Add(this.BRSTMOpenButton);
            this.BRSTMGroupBox.Controls.Add(this.label4);
            this.BRSTMGroupBox.Controls.Add(this.label3);
            this.BRSTMGroupBox.Controls.Add(this.BRSARSaveButton);
            this.BRSTMGroupBox.Controls.Add(this.groupBox4);
            this.BRSTMGroupBox.Enabled = false;
            this.BRSTMGroupBox.Location = new System.Drawing.Point(12, 123);
            this.BRSTMGroupBox.Name = "BRSTMGroupBox";
            this.BRSTMGroupBox.Size = new System.Drawing.Size(326, 181);
            this.BRSTMGroupBox.TabIndex = 2;
            this.BRSTMGroupBox.TabStop = false;
            this.BRSTMGroupBox.Text = "BRSTM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Code Modified by Young Xemnas";
            // 
            // BRSTMOpenButton
            // 
            this.BRSTMOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("BRSTMOpenButton.Image")));
            this.BRSTMOpenButton.Location = new System.Drawing.Point(217, 122);
            this.BRSTMOpenButton.Name = "BRSTMOpenButton";
            this.BRSTMOpenButton.Size = new System.Drawing.Size(50, 50);
            this.BRSTMOpenButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.BRSTMOpenButton, "Open Brstm File");
            this.BRSTMOpenButton.UseVisualStyleBackColor = true;
            this.BRSTMOpenButton.Click += new System.EventHandler(this.BRSTMOpenButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Programmed by hamradio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Version 1.1";
            // 
            // BRSARSaveButton
            // 
            this.BRSARSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("BRSARSaveButton.Image")));
            this.BRSARSaveButton.Location = new System.Drawing.Point(273, 122);
            this.BRSARSaveButton.Name = "BRSARSaveButton";
            this.BRSARSaveButton.Size = new System.Drawing.Size(50, 50);
            this.BRSARSaveButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.BRSARSaveButton, "Save Brsar File");
            this.BRSARSaveButton.UseVisualStyleBackColor = true;
            this.BRSARSaveButton.Click += new System.EventHandler(this.BRSARSaveButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.brstmfileloaded);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.HexTextbox);
            this.groupBox4.Controls.Add(this.BytesTextbox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info";
            // 
            // brstmfileloaded
            // 
            this.brstmfileloaded.Location = new System.Drawing.Point(81, 65);
            this.brstmfileloaded.Name = "brstmfileloaded";
            this.brstmfileloaded.ReadOnly = true;
            this.brstmfileloaded.Size = new System.Drawing.Size(227, 20);
            this.brstmfileloaded.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "File Loaded";
            // 
            // HexTextbox
            // 
            this.HexTextbox.Location = new System.Drawing.Point(53, 39);
            this.HexTextbox.Name = "HexTextbox";
            this.HexTextbox.ReadOnly = true;
            this.HexTextbox.Size = new System.Drawing.Size(126, 20);
            this.HexTextbox.TabIndex = 3;
            // 
            // BytesTextbox
            // 
            this.BytesTextbox.Location = new System.Drawing.Point(52, 17);
            this.BytesTextbox.Name = "BytesTextbox";
            this.BytesTextbox.ReadOnly = true;
            this.BytesTextbox.Size = new System.Drawing.Size(126, 20);
            this.BytesTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bytes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 312);
            this.Controls.Add(this.BRSTMGroupBox);
            this.Controls.Add(this.MusicGroupBox);
            this.Controls.Add(this.BRSARGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BRSAR File Patcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BRSARGroupBox.ResumeLayout(false);
            this.BRSARGroupBox.PerformLayout();
            this.MusicGroupBox.ResumeLayout(false);
            this.BRSTMGroupBox.ResumeLayout(false);
            this.BRSTMGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BRSARGroupBox;
        private System.Windows.Forms.Button BRSAROpenButton;
        private System.Windows.Forms.TextBox BRSAROpenTextbox;
        private System.Windows.Forms.GroupBox MusicGroupBox;
        private System.Windows.Forms.ComboBox MusicComboBox;
        private System.Windows.Forms.GroupBox BRSTMGroupBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox HexTextbox;
        private System.Windows.Forms.TextBox BytesTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BRSTMOpenButton;
        private System.Windows.Forms.Button BRSARSaveButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox brstmfileloaded;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

