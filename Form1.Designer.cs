
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using System.Windows.Forms;

namespace Custom_checkbox_and_radiobutton
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new GradientPanel();
            this.panel2 = new GradientPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox1.Location = new System.Drawing.Point(28, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "ShowCheckBoxes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckedChanged += CheckBox2_CheckedChanged;
            this.checkBox2.Location = new System.Drawing.Point(28, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "ShowOptionButtons";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderColor = Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(37, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(322, 322);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderColor = Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.BackColor = Color.White;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Dock = DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(449, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 104);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private GradientPanel panel1;
        private GradientPanel panel2;
    }
}

