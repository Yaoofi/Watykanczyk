namespace Watykanczyk
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
            this.BtnRunPayload = new System.Windows.Forms.Button();
            this.BtnGetInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRunPayload
            // 
            this.BtnRunPayload.Location = new System.Drawing.Point(8, 56);
            this.BtnRunPayload.Name = "BtnRunPayload";
            this.BtnRunPayload.Size = new System.Drawing.Size(136, 23);
            this.BtnRunPayload.TabIndex = 0;
            this.BtnRunPayload.Text = "Run Payload";
            this.BtnRunPayload.UseVisualStyleBackColor = true;
            this.BtnRunPayload.Click += new System.EventHandler(this.BtnRunPayload_Click);
            // 
            // BtnGetInfo
            // 
            this.BtnGetInfo.Location = new System.Drawing.Point(8, 88);
            this.BtnGetInfo.Name = "BtnGetInfo";
            this.BtnGetInfo.Size = new System.Drawing.Size(136, 23);
            this.BtnGetInfo.TabIndex = 1;
            this.BtnGetInfo.Text = "Get Info";
            this.BtnGetInfo.UseVisualStyleBackColor = true;
            this.BtnGetInfo.Click += new System.EventHandler(this.BtnGetInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Advanced Test Gui ®";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGetInfo);
            this.Controls.Add(this.BtnRunPayload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRunPayload;
        private System.Windows.Forms.Button BtnGetInfo;
        private System.Windows.Forms.Label label1;
    }
}