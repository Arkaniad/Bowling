﻿namespace Bowling {
    partial class InstructionsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionsForm));
            this.HelpText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelpText
            // 
            this.HelpText.AutoSize = true;
            this.HelpText.Location = new System.Drawing.Point(13, 13);
            this.HelpText.MaximumSize = new System.Drawing.Size(300, 0);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(300, 78);
            this.HelpText.TabIndex = 0;
            this.HelpText.Text = resources.GetString("HelpText.Text");
            this.HelpText.Click += new System.EventHandler(this.label1_Click);
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 111);
            this.Controls.Add(this.HelpText);
            this.Name = "InstructionsForm";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelpText;
    }
}