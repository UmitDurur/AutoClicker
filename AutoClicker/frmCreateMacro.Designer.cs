﻿namespace AutoClicker
{
    partial class frmCreateMacro
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
            this.lstMacro = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlClick = new System.Windows.Forms.Panel();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtMiliseconds = new System.Windows.Forms.TextBox();
            this.Miliseconds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocationX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocationY = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMacroName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlClick.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMacro
            // 
            this.lstMacro.FormattingEnabled = true;
            this.lstMacro.Location = new System.Drawing.Point(12, 12);
            this.lstMacro.Name = "lstMacro";
            this.lstMacro.Size = new System.Drawing.Size(222, 238);
            this.lstMacro.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(240, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlClick
            // 
            this.pnlClick.Controls.Add(this.label2);
            this.pnlClick.Controls.Add(this.txtLocationY);
            this.pnlClick.Controls.Add(this.label1);
            this.pnlClick.Controls.Add(this.txtLocationX);
            this.pnlClick.Location = new System.Drawing.Point(240, 39);
            this.pnlClick.Name = "pnlClick";
            this.pnlClick.Size = new System.Drawing.Size(130, 66);
            this.pnlClick.TabIndex = 2;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.Miliseconds);
            this.pnlTime.Controls.Add(this.txtMiliseconds);
            this.pnlTime.Location = new System.Drawing.Point(241, 39);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(130, 66);
            this.pnlTime.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Click",
            "Time"});
            this.comboBox1.Location = new System.Drawing.Point(240, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMiliseconds
            // 
            this.txtMiliseconds.Location = new System.Drawing.Point(71, 3);
            this.txtMiliseconds.Name = "txtMiliseconds";
            this.txtMiliseconds.Size = new System.Drawing.Size(56, 20);
            this.txtMiliseconds.TabIndex = 0;
            // 
            // Miliseconds
            // 
            this.Miliseconds.AutoSize = true;
            this.Miliseconds.Location = new System.Drawing.Point(3, 6);
            this.Miliseconds.Name = "Miliseconds";
            this.Miliseconds.Size = new System.Drawing.Size(62, 13);
            this.Miliseconds.TabIndex = 1;
            this.Miliseconds.Text = "Miliseconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // txtLocationX
            // 
            this.txtLocationX.Location = new System.Drawing.Point(25, 6);
            this.txtLocationX.Name = "txtLocationX";
            this.txtLocationX.Size = new System.Drawing.Size(92, 20);
            this.txtLocationX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // txtLocationY
            // 
            this.txtLocationY.Location = new System.Drawing.Point(25, 32);
            this.txtLocationY.Name = "txtLocationY";
            this.txtLocationY.Size = new System.Drawing.Size(92, 20);
            this.txtLocationY.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(241, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Macro";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMacroName
            // 
            this.txtMacroName.Location = new System.Drawing.Point(242, 201);
            this.txtMacroName.Name = "txtMacroName";
            this.txtMacroName.Size = new System.Drawing.Size(129, 20);
            this.txtMacroName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // frmCreateMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMacroName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstMacro);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.pnlClick);
            this.Name = "frmCreateMacro";
            this.Text = "frmCreateMacro";
            this.Shown += new System.EventHandler(this.frmCreateMacro_Shown);
            this.pnlClick.ResumeLayout(false);
            this.pnlClick.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMacro;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlClick;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label Miliseconds;
        private System.Windows.Forms.TextBox txtMiliseconds;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocationY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocationX;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMacroName;
        private System.Windows.Forms.Label label3;
    }
}