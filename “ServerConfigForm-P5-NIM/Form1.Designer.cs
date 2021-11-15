
namespace _ServerConfigForm_P5_NIM
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnON = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.labelOnorOff = new System.Windows.Forms.Label();
            this.labelKet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(287, 240);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(75, 32);
            this.btnON.TabIndex = 1;
            this.btnON.Text = "On";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(428, 240);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 32);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // labelOnorOff
            // 
            this.labelOnorOff.AutoSize = true;
            this.labelOnorOff.Location = new System.Drawing.Point(377, 152);
            this.labelOnorOff.Name = "labelOnorOff";
            this.labelOnorOff.Size = new System.Drawing.Size(0, 17);
            this.labelOnorOff.TabIndex = 3;
            // 
            // labelKet
            // 
            this.labelKet.AutoSize = true;
            this.labelKet.Location = new System.Drawing.Point(378, 205);
            this.labelKet.Name = "labelKet";
            this.labelKet.Size = new System.Drawing.Size(0, 17);
            this.labelKet.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKet);
            this.Controls.Add(this.labelOnorOff);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label labelOnorOff;
        private System.Windows.Forms.Label labelKet;
    }
}

