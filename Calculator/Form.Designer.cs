
namespace Form
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBTN = new System.Windows.Forms.Button();
            this.subtractBTN = new System.Windows.Forms.Button();
            this.multiplyBTN = new System.Windows.Forms.Button();
            this.divisionBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.screenTXT = new System.Windows.Forms.TextBox();
            this.val1TXT = new System.Windows.Forms.TextBox();
            this.val1LBL = new System.Windows.Forms.Label();
            this.val2LBL = new System.Windows.Forms.Label();
            this.headingLBL = new System.Windows.Forms.Label();
            this.val2TXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addBTN
            // 
            this.addBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBTN.Location = new System.Drawing.Point(178, 142);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(45, 36);
            this.addBTN.TabIndex = 0;
            this.addBTN.Text = "+";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // subtractBTN
            // 
            this.subtractBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subtractBTN.Location = new System.Drawing.Point(232, 142);
            this.subtractBTN.Name = "subtractBTN";
            this.subtractBTN.Size = new System.Drawing.Size(45, 34);
            this.subtractBTN.TabIndex = 2;
            this.subtractBTN.Text = "-";
            this.subtractBTN.UseVisualStyleBackColor = true;
            this.subtractBTN.Click += new System.EventHandler(this.subtractBTN_Click);
            // 
            // multiplyBTN
            // 
            this.multiplyBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiplyBTN.Location = new System.Drawing.Point(178, 184);
            this.multiplyBTN.Name = "multiplyBTN";
            this.multiplyBTN.Size = new System.Drawing.Size(44, 33);
            this.multiplyBTN.TabIndex = 3;
            this.multiplyBTN.Text = "*";
            this.multiplyBTN.UseVisualStyleBackColor = true;
            this.multiplyBTN.Click += new System.EventHandler(this.multiplyBTN_Click);
            // 
            // divisionBTN
            // 
            this.divisionBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divisionBTN.Location = new System.Drawing.Point(232, 182);
            this.divisionBTN.Name = "divisionBTN";
            this.divisionBTN.Size = new System.Drawing.Size(45, 33);
            this.divisionBTN.TabIndex = 4;
            this.divisionBTN.Text = "/";
            this.divisionBTN.UseVisualStyleBackColor = true;
            this.divisionBTN.Click += new System.EventHandler(this.divisionBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.Tomato;
            this.clearBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearBTN.ForeColor = System.Drawing.Color.White;
            this.clearBTN.Location = new System.Drawing.Point(303, 185);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(146, 30);
            this.clearBTN.TabIndex = 5;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // calculateBTN
            // 
            this.calculateBTN.BackColor = System.Drawing.Color.SeaGreen;
            this.calculateBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateBTN.ForeColor = System.Drawing.Color.White;
            this.calculateBTN.Location = new System.Drawing.Point(303, 141);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(146, 31);
            this.calculateBTN.TabIndex = 6;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = false;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // screenTXT
            // 
            this.screenTXT.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.screenTXT.Enabled = false;
            this.screenTXT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.screenTXT.Location = new System.Drawing.Point(25, 39);
            this.screenTXT.Multiline = true;
            this.screenTXT.Name = "screenTXT";
            this.screenTXT.Size = new System.Drawing.Size(424, 86);
            this.screenTXT.TabIndex = 8;
            // 
            // val1TXT
            // 
            this.val1TXT.Location = new System.Drawing.Point(75, 146);
            this.val1TXT.Name = "val1TXT";
            this.val1TXT.Size = new System.Drawing.Size(96, 23);
            this.val1TXT.TabIndex = 0;
            this.val1TXT.TextChanged += new System.EventHandler(this.val1TXT_TextChanged);
            // 
            // val1LBL
            // 
            this.val1LBL.AutoSize = true;
            this.val1LBL.Location = new System.Drawing.Point(25, 154);
            this.val1LBL.Name = "val1LBL";
            this.val1LBL.Size = new System.Drawing.Size(44, 15);
            this.val1LBL.TabIndex = 11;
            this.val1LBL.Text = "Value 1";
            // 
            // val2LBL
            // 
            this.val2LBL.AutoSize = true;
            this.val2LBL.Location = new System.Drawing.Point(25, 193);
            this.val2LBL.Name = "val2LBL";
            this.val2LBL.Size = new System.Drawing.Size(44, 15);
            this.val2LBL.TabIndex = 12;
            this.val2LBL.Text = "Value 2";
            // 
            // headingLBL
            // 
            this.headingLBL.AutoSize = true;
            this.headingLBL.Location = new System.Drawing.Point(25, 9);
            this.headingLBL.Name = "headingLBL";
            this.headingLBL.Size = new System.Drawing.Size(305, 15);
            this.headingLBL.TabIndex = 13;
            this.headingLBL.Text = "Enter Value1, select Operator,enter Value 2, and Calculate";
            // 
            // val2TXT
            // 
            this.val2TXT.Location = new System.Drawing.Point(75, 190);
            this.val2TXT.Name = "val2TXT";
            this.val2TXT.Size = new System.Drawing.Size(96, 23);
            this.val2TXT.TabIndex = 14;
            this.val2TXT.TextChanged += new System.EventHandler(this.val2TXT_TextChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 256);
            this.Controls.Add(this.val2TXT);
            this.Controls.Add(this.headingLBL);
            this.Controls.Add(this.val2LBL);
            this.Controls.Add(this.val1LBL);
            this.Controls.Add(this.val1TXT);
            this.Controls.Add(this.screenTXT);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.divisionBTN);
            this.Controls.Add(this.multiplyBTN);
            this.Controls.Add(this.subtractBTN);
            this.Controls.Add(this.addBTN);
            this.Name = "Form";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button subtractBTN;
        private System.Windows.Forms.Button multiplyBTN;
        private System.Windows.Forms.Button divisionBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.TextBox screenTXT;
        private System.Windows.Forms.TextBox val1TXT;
        private System.Windows.Forms.Label val1LBL;
        private System.Windows.Forms.Label val2LBL;
        private System.Windows.Forms.Label headingLBL;
        private System.Windows.Forms.TextBox val2TXT;
    }
}

