﻿namespace COMP329_Milestone3
{
    partial class Company
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
            this.lb_CName = new System.Windows.Forms.Label();
            this.pn_Container = new System.Windows.Forms.Panel();
            this.btn_NewAccommodation = new System.Windows.Forms.Button();
            this.btn_EditAccommodation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_CName
            // 
            this.lb_CName.AutoSize = true;
            this.lb_CName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CName.Location = new System.Drawing.Point(23, 43);
            this.lb_CName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CName.Name = "lb_CName";
            this.lb_CName.Size = new System.Drawing.Size(237, 41);
            this.lb_CName.TabIndex = 23;
            this.lb_CName.Text = "Company Name";
            // 
            // pn_Container
            // 
            this.pn_Container.AutoScroll = true;
            this.pn_Container.Location = new System.Drawing.Point(31, 100);
            this.pn_Container.Margin = new System.Windows.Forms.Padding(4);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(836, 384);
            this.pn_Container.TabIndex = 24;
            // 
            // btn_NewAccommodation
            // 
            this.btn_NewAccommodation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewAccommodation.Location = new System.Drawing.Point(645, 491);
            this.btn_NewAccommodation.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NewAccommodation.Name = "btn_NewAccommodation";
            this.btn_NewAccommodation.Size = new System.Drawing.Size(221, 46);
            this.btn_NewAccommodation.TabIndex = 25;
            this.btn_NewAccommodation.Text = "New Accommodation";
            this.btn_NewAccommodation.UseVisualStyleBackColor = true;
            this.btn_NewAccommodation.Click += new System.EventHandler(this.btn_NewAccommodation_Click);
            // 
            // btn_EditAccommodation
            // 
            this.btn_EditAccommodation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditAccommodation.Location = new System.Drawing.Point(416, 492);
            this.btn_EditAccommodation.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EditAccommodation.Name = "btn_EditAccommodation";
            this.btn_EditAccommodation.Size = new System.Drawing.Size(221, 46);
            this.btn_EditAccommodation.TabIndex = 26;
            this.btn_EditAccommodation.Text = "Edit Accommodation";
            this.btn_EditAccommodation.UseVisualStyleBackColor = true;
            this.btn_EditAccommodation.Click += new System.EventHandler(this.btn_EditAccommodation_Click);
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(899, 551);
            this.Controls.Add(this.btn_EditAccommodation);
            this.Controls.Add(this.btn_NewAccommodation);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.lb_CName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Company";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CName;
        private System.Windows.Forms.Panel pn_Container;
        private System.Windows.Forms.Button btn_NewAccommodation;
        private System.Windows.Forms.Button btn_EditAccommodation;
    }
}