﻿namespace Cyber_Incident_Response
{
    partial class About_Sobre_InfoWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(119, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(561, 120);
            this.label9.TabIndex = 9;
            this.label9.Text = "Open Source Program created for Incident \r\nManagement and Response\r\n\r\nThis progra" +
    "m can be used for events that require\r\nincident management and response between " +
    "teams.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About_Sobre_InfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Name = "About_Sobre_InfoWindow";
            this.Size = new System.Drawing.Size(805, 548);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
    }
}
