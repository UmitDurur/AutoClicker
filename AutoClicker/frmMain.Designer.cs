namespace AutoClicker
{
    partial class frmMain
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
            this.radioOnlyClick = new System.Windows.Forms.RadioButton();
            this.radioSetCursorandClick = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCursorLocation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocationY = new System.Windows.Forms.TextBox();
            this.txtLocationX = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chcGamesCompatibility = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClickTimer = new System.Windows.Forms.TextBox();
            this.radioMacro = new System.Windows.Forms.RadioButton();
            this.btnMacro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioOnlyClick
            // 
            this.radioOnlyClick.AutoSize = true;
            this.radioOnlyClick.Location = new System.Drawing.Point(3, 15);
            this.radioOnlyClick.Name = "radioOnlyClick";
            this.radioOnlyClick.Size = new System.Drawing.Size(71, 17);
            this.radioOnlyClick.TabIndex = 0;
            this.radioOnlyClick.TabStop = true;
            this.radioOnlyClick.Text = "Only click";
            this.radioOnlyClick.UseVisualStyleBackColor = true;
            // 
            // radioSetCursorandClick
            // 
            this.radioSetCursorandClick.AutoSize = true;
            this.radioSetCursorandClick.Location = new System.Drawing.Point(3, 46);
            this.radioSetCursorandClick.Name = "radioSetCursorandClick";
            this.radioSetCursorandClick.Size = new System.Drawing.Size(119, 17);
            this.radioSetCursorandClick.TabIndex = 1;
            this.radioSetCursorandClick.TabStop = true;
            this.radioSetCursorandClick.Text = "Set cursor and click";
            this.radioSetCursorandClick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current cursor location:";
            // 
            // lblCursorLocation
            // 
            this.lblCursorLocation.AutoSize = true;
            this.lblCursorLocation.Location = new System.Drawing.Point(125, 11);
            this.lblCursorLocation.Name = "lblCursorLocation";
            this.lblCursorLocation.Size = new System.Drawing.Size(14, 13);
            this.lblCursorLocation.TabIndex = 3;
            this.lblCursorLocation.Text = "X";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLocationY);
            this.panel1.Controls.Add(this.txtLocationX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCursorLocation);
            this.panel1.Location = new System.Drawing.Point(128, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 47);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Set clicking location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X:";
            // 
            // txtLocationY
            // 
            this.txtLocationY.Location = new System.Drawing.Point(439, 9);
            this.txtLocationY.Name = "txtLocationY";
            this.txtLocationY.Size = new System.Drawing.Size(40, 20);
            this.txtLocationY.TabIndex = 4;
            this.txtLocationY.Text = "0";
            // 
            // txtLocationX
            // 
            this.txtLocationX.Location = new System.Drawing.Point(373, 9);
            this.txtLocationX.Name = "txtLocationX";
            this.txtLocationX.Size = new System.Drawing.Size(40, 20);
            this.txtLocationX.TabIndex = 3;
            this.txtLocationX.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMacro);
            this.panel2.Controls.Add(this.radioMacro);
            this.panel2.Controls.Add(this.radioOnlyClick);
            this.panel2.Controls.Add(this.radioSetCursorandClick);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 128);
            this.panel2.TabIndex = 5;
            // 
            // chcGamesCompatibility
            // 
            this.chcGamesCompatibility.AutoSize = true;
            this.chcGamesCompatibility.Location = new System.Drawing.Point(460, 97);
            this.chcGamesCompatibility.Name = "chcGamesCompatibility";
            this.chcGamesCompatibility.Size = new System.Drawing.Size(159, 17);
            this.chcGamesCompatibility.TabIndex = 6;
            this.chcGamesCompatibility.Text = "High Compatible with games";
            this.chcGamesCompatibility.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Press F10 to start and stop";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(304, 93);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(118, 23);
            this.btnStartStop.TabIndex = 8;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtClickTimer);
            this.panel3.Location = new System.Drawing.Point(128, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 32);
            this.panel3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time between clicks";
            // 
            // txtClickTimer
            // 
            this.txtClickTimer.Location = new System.Drawing.Point(118, 5);
            this.txtClickTimer.Name = "txtClickTimer";
            this.txtClickTimer.Size = new System.Drawing.Size(54, 20);
            this.txtClickTimer.TabIndex = 2;
            this.txtClickTimer.Text = "10";
            this.txtClickTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioMacro
            // 
            this.radioMacro.AutoSize = true;
            this.radioMacro.Location = new System.Drawing.Point(3, 78);
            this.radioMacro.Name = "radioMacro";
            this.radioMacro.Size = new System.Drawing.Size(103, 17);
            this.radioMacro.TabIndex = 2;
            this.radioMacro.TabStop = true;
            this.radioMacro.Text = "Click from macro";
            this.radioMacro.UseVisualStyleBackColor = true;
            // 
            // btnMacro
            // 
            this.btnMacro.Location = new System.Drawing.Point(3, 102);
            this.btnMacro.Name = "btnMacro";
            this.btnMacro.Size = new System.Drawing.Size(119, 23);
            this.btnMacro.TabIndex = 3;
            this.btnMacro.Text = "Create Macro";
            this.btnMacro.UseVisualStyleBackColor = true;
            this.btnMacro.Click += new System.EventHandler(this.btnMacro_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 128);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chcGamesCompatibility);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioOnlyClick;
        private System.Windows.Forms.RadioButton radioSetCursorandClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCursorLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLocationX;
        private System.Windows.Forms.TextBox txtLocationY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chcGamesCompatibility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtClickTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.RadioButton radioMacro;
        private System.Windows.Forms.Button btnMacro;
    }
}