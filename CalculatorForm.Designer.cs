namespace SimpleCalculatorApp
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_Clearall = new System.Windows.Forms.Button();
            this.btn_Clearone = new System.Windows.Forms.Button();
            this.Disp_Label = new System.Windows.Forms.Label();
            this.btn_log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_input.Location = new System.Drawing.Point(30, 22);
            this.txt_input.Name = "txt_input";
            this.txt_input.ReadOnly = true;
            this.txt_input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_input.Size = new System.Drawing.Size(324, 20);
            this.txt_input.TabIndex = 0;
            this.txt_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(30, 84);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(56, 49);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_Digit_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(92, 84);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(56, 49);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_Digit_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(154, 84);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(56, 49);
            this.btn_9.TabIndex = 3;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_Digit_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(216, 84);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(56, 49);
            this.btn_divide.TabIndex = 4;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(30, 139);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(56, 49);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_Digit_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(92, 139);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(56, 49);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_Digit_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(154, 139);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(56, 49);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_Digit_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(216, 139);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(56, 49);
            this.btn_multiply.TabIndex = 8;
            this.btn_multiply.Text = "X";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(30, 194);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(56, 49);
            this.btn_1.TabIndex = 9;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_Digit_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(92, 194);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(56, 49);
            this.btn_2.TabIndex = 10;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_Digit_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(154, 194);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(56, 49);
            this.btn_3.TabIndex = 11;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_Digit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(216, 194);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 49);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(30, 249);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(118, 49);
            this.btn_0.TabIndex = 13;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_Digit_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(279, 194);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(75, 104);
            this.btn_equal.TabIndex = 14;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(216, 249);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(56, 49);
            this.btn_sub.TabIndex = 15;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_point
            // 
            this.btn_point.Location = new System.Drawing.Point(154, 249);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(56, 49);
            this.btn_point.TabIndex = 16;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_Clearall
            // 
            this.btn_Clearall.Location = new System.Drawing.Point(279, 139);
            this.btn_Clearall.Name = "btn_Clearall";
            this.btn_Clearall.Size = new System.Drawing.Size(75, 48);
            this.btn_Clearall.TabIndex = 17;
            this.btn_Clearall.Text = "C";
            this.btn_Clearall.UseVisualStyleBackColor = true;
            this.btn_Clearall.Click += new System.EventHandler(this.btn_Clearall_Click);
            // 
            // btn_Clearone
            // 
            this.btn_Clearone.Location = new System.Drawing.Point(279, 84);
            this.btn_Clearone.Name = "btn_Clearone";
            this.btn_Clearone.Size = new System.Drawing.Size(75, 48);
            this.btn_Clearone.TabIndex = 18;
            this.btn_Clearone.Text = "CE";
            this.btn_Clearone.UseVisualStyleBackColor = true;
            this.btn_Clearone.Click += new System.EventHandler(this.btn_Clearone_Click);
            // 
            // Disp_Label
            // 
            this.Disp_Label.AutoSize = true;
            this.Disp_Label.BackColor = System.Drawing.Color.Transparent;
            this.Disp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disp_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Disp_Label.Location = new System.Drawing.Point(28, 52);
            this.Disp_Label.Name = "Disp_Label";
            this.Disp_Label.Size = new System.Drawing.Size(91, 20);
            this.Disp_Label.TabIndex = 19;
            this.Disp_Label.Text = "Expression:";
            this.Disp_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(30, 305);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(324, 23);
            this.btn_log.TabIndex = 20;
            this.btn_log.Text = "Show Log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(386, 343);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.Disp_Label);
            this.Controls.Add(this.btn_Clearone);
            this.Controls.Add(this.btn_Clearall);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.txt_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_Clearall;
        private System.Windows.Forms.Button btn_Clearone;
        private System.Windows.Forms.Label Disp_Label;
        private System.Windows.Forms.Button btn_log;
    }
}

