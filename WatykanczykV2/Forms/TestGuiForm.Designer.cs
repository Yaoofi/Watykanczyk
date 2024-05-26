namespace WatykanczykV2.Forms
{
    partial class TestGuiForm
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
            this.btnFakeGui = new System.Windows.Forms.Button();
            this.btnPlayMusic = new System.Windows.Forms.Button();
            this.btnExeName = new System.Windows.Forms.Button();
            this.btnCurrentLocation = new System.Windows.Forms.Button();
            this.btnCurrentRime = new System.Windows.Forms.Button();
            this.btnCloneAndRun = new System.Windows.Forms.Button();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnRunPayload = new System.Windows.Forms.Button();
            this.btnRegKeys = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFakeGui
            // 
            this.btnFakeGui.Location = new System.Drawing.Point(16, 16);
            this.btnFakeGui.Name = "btnFakeGui";
            this.btnFakeGui.Size = new System.Drawing.Size(112, 23);
            this.btnFakeGui.TabIndex = 0;
            this.btnFakeGui.Text = "Run fake gui";
            this.btnFakeGui.UseVisualStyleBackColor = true;
            this.btnFakeGui.Click += new System.EventHandler(this.btnFakeGui_Click);
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.Location = new System.Drawing.Point(16, 40);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(112, 23);
            this.btnPlayMusic.TabIndex = 1;
            this.btnPlayMusic.Text = "Play music";
            this.btnPlayMusic.UseVisualStyleBackColor = true;
            this.btnPlayMusic.Click += new System.EventHandler(this.btnPlayMusic_Click);
            // 
            // btnExeName
            // 
            this.btnExeName.Location = new System.Drawing.Point(16, 40);
            this.btnExeName.Name = "btnExeName";
            this.btnExeName.Size = new System.Drawing.Size(112, 23);
            this.btnExeName.TabIndex = 2;
            this.btnExeName.Text = "Exe name";
            this.btnExeName.UseVisualStyleBackColor = true;
            this.btnExeName.Click += new System.EventHandler(this.btnExeName_Click);
            // 
            // btnCurrentLocation
            // 
            this.btnCurrentLocation.Location = new System.Drawing.Point(16, 64);
            this.btnCurrentLocation.Name = "btnCurrentLocation";
            this.btnCurrentLocation.Size = new System.Drawing.Size(112, 23);
            this.btnCurrentLocation.TabIndex = 3;
            this.btnCurrentLocation.Text = "Current loacation";
            this.btnCurrentLocation.UseVisualStyleBackColor = true;
            this.btnCurrentLocation.Click += new System.EventHandler(this.btnCurrentLocation_Click);
            // 
            // btnCurrentRime
            // 
            this.btnCurrentRime.Location = new System.Drawing.Point(16, 16);
            this.btnCurrentRime.Name = "btnCurrentRime";
            this.btnCurrentRime.Size = new System.Drawing.Size(112, 23);
            this.btnCurrentRime.TabIndex = 4;
            this.btnCurrentRime.Text = "Current time";
            this.btnCurrentRime.UseVisualStyleBackColor = true;
            this.btnCurrentRime.Click += new System.EventHandler(this.btnCurrentRime_Click);
            // 
            // btnCloneAndRun
            // 
            this.btnCloneAndRun.Location = new System.Drawing.Point(16, 16);
            this.btnCloneAndRun.Name = "btnCloneAndRun";
            this.btnCloneAndRun.Size = new System.Drawing.Size(112, 23);
            this.btnCloneAndRun.TabIndex = 5;
            this.btnCloneAndRun.Text = "Clone and run";
            this.btnCloneAndRun.UseVisualStyleBackColor = true;
            this.btnCloneAndRun.Click += new System.EventHandler(this.btnCloneAndRun_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(16, 40);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(112, 23);
            this.btnGetInfo.TabIndex = 6;
            this.btnGetInfo.Text = "Info to webhook";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnRunPayload
            // 
            this.btnRunPayload.Location = new System.Drawing.Point(16, 64);
            this.btnRunPayload.Name = "btnRunPayload";
            this.btnRunPayload.Size = new System.Drawing.Size(112, 23);
            this.btnRunPayload.TabIndex = 7;
            this.btnRunPayload.Text = "Run payload";
            this.btnRunPayload.UseVisualStyleBackColor = true;
            this.btnRunPayload.Click += new System.EventHandler(this.btnRunPayload_Click);
            // 
            // btnRegKeys
            // 
            this.btnRegKeys.Location = new System.Drawing.Point(16, 64);
            this.btnRegKeys.Name = "btnRegKeys";
            this.btnRegKeys.Size = new System.Drawing.Size(112, 23);
            this.btnRegKeys.TabIndex = 8;
            this.btnRegKeys.Text = "Set reg keys";
            this.btnRegKeys.UseVisualStyleBackColor = true;
            this.btnRegKeys.Click += new System.EventHandler(this.btnRegKeys_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFakeGui);
            this.groupBox1.Controls.Add(this.btnPlayMusic);
            this.groupBox1.Controls.Add(this.btnRunPayload);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 96);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doesn\'t change anything";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCloneAndRun);
            this.groupBox2.Controls.Add(this.btnGetInfo);
            this.groupBox2.Controls.Add(this.btnRegKeys);
            this.groupBox2.Location = new System.Drawing.Point(160, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 96);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Does change anything";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCurrentRime);
            this.groupBox3.Controls.Add(this.btnExeName);
            this.groupBox3.Controls.Add(this.btnCurrentLocation);
            this.groupBox3.Location = new System.Drawing.Point(8, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 96);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtOutput);
            this.groupBox4.Location = new System.Drawing.Point(312, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 200);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // rtOutput
            // 
            this.rtOutput.BackColor = System.Drawing.SystemColors.Control;
            this.rtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtOutput.Enabled = false;
            this.rtOutput.Location = new System.Drawing.Point(8, 16);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.Size = new System.Drawing.Size(216, 176);
            this.rtOutput.TabIndex = 0;
            this.rtOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(184, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Advanced";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(208, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(208, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "GUI";
            // 
            // TestGuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 212);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestGuiForm";
            this.Text = "TestGuiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFakeGui;
        private System.Windows.Forms.Button btnPlayMusic;
        private System.Windows.Forms.Button btnExeName;
        private System.Windows.Forms.Button btnCurrentLocation;
        private System.Windows.Forms.Button btnCurrentRime;
        private System.Windows.Forms.Button btnCloneAndRun;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Button btnRunPayload;
        private System.Windows.Forms.Button btnRegKeys;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}