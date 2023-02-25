
namespace MT_project
{
    partial class tempConversion
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbCtoF = new System.Windows.Forms.RadioButton();
            this.rbFtoC = new System.Windows.Forms.RadioButton();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFromTemp = new System.Windows.Forms.Label();
            this.lblToTemp = new System.Windows.Forms.Label();
            this.txtFromTemp = new System.Windows.Forms.RichTextBox();
            this.txtToTemp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Read file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(322, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbCtoF
            // 
            this.rbCtoF.AutoSize = true;
            this.rbCtoF.Checked = true;
            this.rbCtoF.Location = new System.Drawing.Point(202, 27);
            this.rbCtoF.Name = "rbCtoF";
            this.rbCtoF.Size = new System.Drawing.Size(102, 21);
            this.rbCtoF.TabIndex = 3;
            this.rbCtoF.TabStop = true;
            this.rbCtoF.Text = "From C to F";
            this.rbCtoF.UseVisualStyleBackColor = true;
            this.rbCtoF.CheckedChanged += new System.EventHandler(this.rbCtoF_CheckedChanged);
            // 
            // rbFtoC
            // 
            this.rbFtoC.AutoSize = true;
            this.rbFtoC.Location = new System.Drawing.Point(202, 67);
            this.rbFtoC.Name = "rbFtoC";
            this.rbFtoC.Size = new System.Drawing.Size(102, 21);
            this.rbFtoC.TabIndex = 4;
            this.rbFtoC.Text = "From F to C";
            this.rbFtoC.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(40, 230);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(398, 76);
            this.txtMessage.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Message:";
            // 
            // lblFromTemp
            // 
            this.lblFromTemp.AutoSize = true;
            this.lblFromTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromTemp.Location = new System.Drawing.Point(106, 160);
            this.lblFromTemp.Name = "lblFromTemp";
            this.lblFromTemp.Size = new System.Drawing.Size(18, 17);
            this.lblFromTemp.TabIndex = 10;
            this.lblFromTemp.Text = "C";
            // 
            // lblToTemp
            // 
            this.lblToTemp.AutoSize = true;
            this.lblToTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToTemp.Location = new System.Drawing.Point(354, 160);
            this.lblToTemp.Name = "lblToTemp";
            this.lblToTemp.Size = new System.Drawing.Size(17, 17);
            this.lblToTemp.TabIndex = 11;
            this.lblToTemp.Text = "F";
            // 
            // txtFromTemp
            // 
            this.txtFromTemp.Location = new System.Drawing.Point(40, 107);
            this.txtFromTemp.Multiline = false;
            this.txtFromTemp.Name = "txtFromTemp";
            this.txtFromTemp.Size = new System.Drawing.Size(150, 40);
            this.txtFromTemp.TabIndex = 12;
            this.txtFromTemp.Text = "";
//            this.txtFromTemp.TextChanged += new System.EventHandler(this.txtFromTemp_TextChanged);
            // 
            // txtToTemp
            // 
            this.txtToTemp.Location = new System.Drawing.Point(287, 107);
            this.txtToTemp.Multiline = false;
            this.txtToTemp.Name = "txtToTemp";
            this.txtToTemp.ReadOnly = true;
            this.txtToTemp.Size = new System.Drawing.Size(150, 40);
            this.txtToTemp.TabIndex = 13;
            this.txtToTemp.Text = "";
            // 
            // tempConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 396);
            this.Controls.Add(this.txtToTemp);
            this.Controls.Add(this.txtFromTemp);
            this.Controls.Add(this.lblToTemp);
            this.Controls.Add(this.lblFromTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.rbFtoC);
            this.Controls.Add(this.rbCtoF);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "tempConversion";
            this.Text = "tempConversion-Essam";
            this.Load += new System.EventHandler(this.tempConversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbCtoF;
        private System.Windows.Forms.RadioButton rbFtoC;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFromTemp;
        private System.Windows.Forms.Label lblToTemp;
        private System.Windows.Forms.RichTextBox txtFromTemp;
        private System.Windows.Forms.RichTextBox txtToTemp;
    }
}