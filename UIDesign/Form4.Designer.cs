﻿namespace UIDesign
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_cmndnv = new System.Windows.Forms.TextBox();
            this.label_cmndnv = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_diachinv = new System.Windows.Forms.Label();
            this.textBox_namenv = new System.Windows.Forms.TextBox();
            this.label_phonenv = new System.Windows.Forms.Label();
            this.label_DOBnv = new System.Windows.Forms.Label();
            this.label_namenv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_luongnv = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button_subTTCN_search = new System.Windows.Forms.Button();
            this.button_subTTCN_sort = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.button_back.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_back.Image = ((System.Drawing.Image)(resources.GetObject("button_back.Image")));
            this.button_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_back.Location = new System.Drawing.Point(0, 0);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(79, 64);
            this.button_back.TabIndex = 0;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 955);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 373);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox_cmndnv);
            this.panel2.Controls.Add(this.label_cmndnv);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label_luongnv);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label_diachinv);
            this.panel2.Controls.Add(this.textBox_namenv);
            this.panel2.Controls.Add(this.label_phonenv);
            this.panel2.Controls.Add(this.label_DOBnv);
            this.panel2.Controls.Add(this.label_namenv);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(79, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 342);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(13, 204);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(353, 1);
            this.panel5.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(9, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 1);
            this.panel4.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(373, 203);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(354, 1);
            this.panel7.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(373, 115);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(354, 1);
            this.panel6.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(9, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 1);
            this.panel3.TabIndex = 3;
            // 
            // textBox_cmndnv
            // 
            this.textBox_cmndnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_cmndnv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_cmndnv.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cmndnv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_cmndnv.Location = new System.Drawing.Point(108, 253);
            this.textBox_cmndnv.Name = "textBox_cmndnv";
            this.textBox_cmndnv.Size = new System.Drawing.Size(197, 22);
            this.textBox_cmndnv.TabIndex = 2;
            // 
            // label_cmndnv
            // 
            this.label_cmndnv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cmndnv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_cmndnv.Location = new System.Drawing.Point(4, 252);
            this.label_cmndnv.Name = "label_cmndnv";
            this.label_cmndnv.Size = new System.Drawing.Size(98, 23);
            this.label_cmndnv.TabIndex = 1;
            this.label_cmndnv.Text = "CMND";
            this.label_cmndnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Location = new System.Drawing.Point(508, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(508, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label_diachinv
            // 
            this.label_diachinv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diachinv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_diachinv.Location = new System.Drawing.Point(368, 174);
            this.label_diachinv.Name = "label_diachinv";
            this.label_diachinv.Size = new System.Drawing.Size(141, 23);
            this.label_diachinv.TabIndex = 1;
            this.label_diachinv.Text = "Địa chỉ";
            this.label_diachinv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_namenv
            // 
            this.textBox_namenv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_namenv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_namenv.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_namenv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_namenv.Location = new System.Drawing.Point(108, 87);
            this.textBox_namenv.Name = "textBox_namenv";
            this.textBox_namenv.Size = new System.Drawing.Size(197, 22);
            this.textBox_namenv.TabIndex = 2;
            // 
            // label_phonenv
            // 
            this.label_phonenv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phonenv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_phonenv.Location = new System.Drawing.Point(368, 86);
            this.label_phonenv.Name = "label_phonenv";
            this.label_phonenv.Size = new System.Drawing.Size(141, 23);
            this.label_phonenv.TabIndex = 1;
            this.label_phonenv.Text = "Số điện thoại";
            this.label_phonenv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_DOBnv
            // 
            this.label_DOBnv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DOBnv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_DOBnv.Location = new System.Drawing.Point(4, 175);
            this.label_DOBnv.Name = "label_DOBnv";
            this.label_DOBnv.Size = new System.Drawing.Size(98, 23);
            this.label_DOBnv.TabIndex = 1;
            this.label_DOBnv.Text = "Ngày sinh";
            this.label_DOBnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_namenv
            // 
            this.label_namenv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namenv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_namenv.Location = new System.Drawing.Point(4, 86);
            this.label_namenv.Name = "label_namenv";
            this.label_namenv.Size = new System.Drawing.Size(98, 23);
            this.label_namenv.TabIndex = 1;
            this.label_namenv.Text = "Họ và tên";
            this.label_namenv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin chi tiết";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_luongnv
            // 
            this.label_luongnv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_luongnv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_luongnv.Location = new System.Drawing.Point(368, 252);
            this.label_luongnv.Name = "label_luongnv";
            this.label_luongnv.Size = new System.Drawing.Size(141, 23);
            this.label_luongnv.TabIndex = 1;
            this.label_luongnv.Text = "Lương";
            this.label_luongnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox3.Location = new System.Drawing.Point(508, 253);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 22);
            this.textBox3.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(373, 281);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(354, 1);
            this.panel8.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.Location = new System.Drawing.Point(567, 405);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Tìm kiếm";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(562, 433);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(172, 1);
            this.panel9.TabIndex = 3;
            // 
            // button_subTTCN_search
            // 
            this.button_subTTCN_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subTTCN_search.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subTTCN_search.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subTTCN_search.Location = new System.Drawing.Point(740, 397);
            this.button_subTTCN_search.Name = "button_subTTCN_search";
            this.button_subTTCN_search.Size = new System.Drawing.Size(118, 37);
            this.button_subTTCN_search.TabIndex = 4;
            this.button_subTTCN_search.Text = "Tìm kiếm";
            this.button_subTTCN_search.UseVisualStyleBackColor = true;
            // 
            // button_subTTCN_sort
            // 
            this.button_subTTCN_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subTTCN_sort.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subTTCN_sort.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subTTCN_sort.Location = new System.Drawing.Point(740, 510);
            this.button_subTTCN_sort.Name = "button_subTTCN_sort";
            this.button_subTTCN_sort.Size = new System.Drawing.Size(118, 37);
            this.button_subTTCN_sort.TabIndex = 4;
            this.button_subTTCN_sort.Text = "Sắp xếp";
            this.button_subTTCN_sort.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(870, 955);
            this.Controls.Add(this.button_subTTCN_sort);
            this.Controls.Add(this.button_subTTCN_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_namenv;
        private System.Windows.Forms.TextBox textBox_namenv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_cmndnv;
        private System.Windows.Forms.Label label_cmndnv;
        private System.Windows.Forms.Label label_DOBnv;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_phonenv;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_diachinv;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_luongnv;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button_subTTCN_search;
        private System.Windows.Forms.Button button_subTTCN_sort;
    }
}