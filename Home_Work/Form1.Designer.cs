﻿namespace Home_Work
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab2_button1 = new System.Windows.Forms.Button();
            this.tab2_textBox1 = new System.Windows.Forms.TextBox();
            this.tab2_textBox2 = new System.Windows.Forms.TextBox();
            this.tab2_textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 290);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(339, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tab2_textBox3);
            this.tabPage2.Controls.Add(this.tab2_textBox2);
            this.tabPage2.Controls.Add(this.tab2_textBox1);
            this.tabPage2.Controls.Add(this.tab2_button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(339, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab2_button1
            // 
            this.tab2_button1.Location = new System.Drawing.Point(114, 97);
            this.tab2_button1.Name = "tab2_button1";
            this.tab2_button1.Size = new System.Drawing.Size(94, 23);
            this.tab2_button1.TabIndex = 0;
            this.tab2_button1.Text = "button1";
            this.tab2_button1.UseVisualStyleBackColor = true;
            // 
            // tab2_textBox1
            // 
            this.tab2_textBox1.Location = new System.Drawing.Point(17, 54);
            this.tab2_textBox1.Name = "tab2_textBox1";
            this.tab2_textBox1.Size = new System.Drawing.Size(100, 21);
            this.tab2_textBox1.TabIndex = 1;
            // 
            // tab2_textBox2
            // 
            this.tab2_textBox2.Location = new System.Drawing.Point(206, 54);
            this.tab2_textBox2.Name = "tab2_textBox2";
            this.tab2_textBox2.Size = new System.Drawing.Size(100, 21);
            this.tab2_textBox2.TabIndex = 2;
            // 
            // tab2_textBox3
            // 
            this.tab2_textBox3.Location = new System.Drawing.Point(114, 147);
            this.tab2_textBox3.Name = "tab2_textBox3";
            this.tab2_textBox3.Size = new System.Drawing.Size(100, 21);
            this.tab2_textBox3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 315);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tab2_textBox3;
        private System.Windows.Forms.TextBox tab2_textBox2;
        private System.Windows.Forms.TextBox tab2_textBox1;
        private System.Windows.Forms.Button tab2_button1;
    }
}

