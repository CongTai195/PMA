namespace UIDesign
{
    partial class FormSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            this.button_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_dvtsp = new System.Windows.Forms.TextBox();
            this.label_dvtsp = new System.Windows.Forms.Label();
            this.textBox_pricesp = new System.Windows.Forms.TextBox();
            this.label_pricesp = new System.Windows.Forms.Label();
            this.textBox_namesp = new System.Windows.Forms.TextBox();
            this.label_loaisp = new System.Windows.Forms.Label();
            this.label_namesp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button_subQLSP_search = new System.Windows.Forms.Button();
            this.button_subQLSP_sort = new System.Windows.Forms.Button();
            this.button_subQLSP_add = new System.Windows.Forms.Button();
            this.button_subQLSP_update = new System.Windows.Forms.Button();
            this.button_subQLSP_delete = new System.Windows.Forms.Button();
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
            this.button_back.Click += new System.EventHandler(this.Button_back_Click);
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
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox_dvtsp);
            this.panel2.Controls.Add(this.label_dvtsp);
            this.panel2.Controls.Add(this.textBox_pricesp);
            this.panel2.Controls.Add(this.label_pricesp);
            this.panel2.Controls.Add(this.textBox_namesp);
            this.panel2.Controls.Add(this.label_loaisp);
            this.panel2.Controls.Add(this.label_namesp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(79, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 342);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(327, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loại sản phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(488, 310);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 29);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 29);
            this.comboBox1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(13, 204);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(353, 1);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(9, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 1);
            this.panel4.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(373, 281);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(354, 1);
            this.panel8.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(9, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 1);
            this.panel3.TabIndex = 3;
            // 
            // textBox_dvtsp
            // 
            this.textBox_dvtsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_dvtsp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_dvtsp.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dvtsp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_dvtsp.Location = new System.Drawing.Point(157, 253);
            this.textBox_dvtsp.Name = "textBox_dvtsp";
            this.textBox_dvtsp.Size = new System.Drawing.Size(197, 22);
            this.textBox_dvtsp.TabIndex = 2;
            // 
            // label_dvtsp
            // 
            this.label_dvtsp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dvtsp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_dvtsp.Location = new System.Drawing.Point(4, 252);
            this.label_dvtsp.Name = "label_dvtsp";
            this.label_dvtsp.Size = new System.Drawing.Size(145, 23);
            this.label_dvtsp.TabIndex = 1;
            this.label_dvtsp.Text = "Đơn vị tính";
            this.label_dvtsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_pricesp
            // 
            this.textBox_pricesp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_pricesp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_pricesp.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pricesp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_pricesp.Location = new System.Drawing.Point(552, 253);
            this.textBox_pricesp.Name = "textBox_pricesp";
            this.textBox_pricesp.Size = new System.Drawing.Size(161, 22);
            this.textBox_pricesp.TabIndex = 2;
            // 
            // label_pricesp
            // 
            this.label_pricesp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pricesp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_pricesp.Location = new System.Drawing.Point(368, 252);
            this.label_pricesp.Name = "label_pricesp";
            this.label_pricesp.Size = new System.Drawing.Size(141, 23);
            this.label_pricesp.TabIndex = 1;
            this.label_pricesp.Text = "Giá";
            this.label_pricesp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_namesp
            // 
            this.textBox_namesp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_namesp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_namesp.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_namesp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_namesp.Location = new System.Drawing.Point(155, 87);
            this.textBox_namesp.Name = "textBox_namesp";
            this.textBox_namesp.Size = new System.Drawing.Size(197, 22);
            this.textBox_namesp.TabIndex = 2;
            // 
            // label_loaisp
            // 
            this.label_loaisp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loaisp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_loaisp.Location = new System.Drawing.Point(4, 175);
            this.label_loaisp.Name = "label_loaisp";
            this.label_loaisp.Size = new System.Drawing.Size(145, 23);
            this.label_loaisp.TabIndex = 1;
            this.label_loaisp.Text = "Loại sản phẩm";
            this.label_loaisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_namesp
            // 
            this.label_namesp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namesp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_namesp.Location = new System.Drawing.Point(4, 86);
            this.label_namesp.Name = "label_namesp";
            this.label_namesp.Size = new System.Drawing.Size(145, 23);
            this.label_namesp.TabIndex = 1;
            this.label_namesp.Text = "Tên sản phẩm";
            this.label_namesp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // textBox_search
            // 
            this.textBox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_search.Location = new System.Drawing.Point(567, 368);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(153, 22);
            this.textBox_search.TabIndex = 2;
            this.textBox_search.Text = "Tìm kiếm";
            this.textBox_search.Click += new System.EventHandler(this.TextBox_search_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(562, 396);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(172, 1);
            this.panel9.TabIndex = 3;
            // 
            // button_subQLSP_search
            // 
            this.button_subQLSP_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subQLSP_search.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subQLSP_search.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subQLSP_search.Location = new System.Drawing.Point(740, 360);
            this.button_subQLSP_search.Name = "button_subQLSP_search";
            this.button_subQLSP_search.Size = new System.Drawing.Size(118, 37);
            this.button_subQLSP_search.TabIndex = 4;
            this.button_subQLSP_search.Text = "Tìm kiếm";
            this.button_subQLSP_search.UseVisualStyleBackColor = true;
            this.button_subQLSP_search.Click += new System.EventHandler(this.Button_subQLSP_search_Click);
            // 
            // button_subQLSP_sort
            // 
            this.button_subQLSP_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subQLSP_sort.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subQLSP_sort.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subQLSP_sort.Location = new System.Drawing.Point(740, 647);
            this.button_subQLSP_sort.Name = "button_subQLSP_sort";
            this.button_subQLSP_sort.Size = new System.Drawing.Size(118, 37);
            this.button_subQLSP_sort.TabIndex = 4;
            this.button_subQLSP_sort.Text = "Sắp xếp";
            this.button_subQLSP_sort.UseVisualStyleBackColor = true;
            this.button_subQLSP_sort.Click += new System.EventHandler(this.Button_subQLSP_sort_Click);
            // 
            // button_subQLSP_add
            // 
            this.button_subQLSP_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subQLSP_add.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subQLSP_add.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subQLSP_add.Location = new System.Drawing.Point(740, 432);
            this.button_subQLSP_add.Name = "button_subQLSP_add";
            this.button_subQLSP_add.Size = new System.Drawing.Size(118, 37);
            this.button_subQLSP_add.TabIndex = 5;
            this.button_subQLSP_add.Text = "Thêm";
            this.button_subQLSP_add.UseVisualStyleBackColor = true;
            this.button_subQLSP_add.Click += new System.EventHandler(this.Button_subQLSP_add_Click);
            // 
            // button_subQLSP_update
            // 
            this.button_subQLSP_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subQLSP_update.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subQLSP_update.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subQLSP_update.Location = new System.Drawing.Point(740, 504);
            this.button_subQLSP_update.Name = "button_subQLSP_update";
            this.button_subQLSP_update.Size = new System.Drawing.Size(118, 37);
            this.button_subQLSP_update.TabIndex = 6;
            this.button_subQLSP_update.Text = "Chỉnh sửa";
            this.button_subQLSP_update.UseVisualStyleBackColor = true;
            this.button_subQLSP_update.Click += new System.EventHandler(this.Button_subQLSP_update_Click);
            // 
            // button_subQLSP_delete
            // 
            this.button_subQLSP_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subQLSP_delete.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subQLSP_delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subQLSP_delete.Location = new System.Drawing.Point(740, 578);
            this.button_subQLSP_delete.Name = "button_subQLSP_delete";
            this.button_subQLSP_delete.Size = new System.Drawing.Size(118, 37);
            this.button_subQLSP_delete.TabIndex = 7;
            this.button_subQLSP_delete.Text = "Xóa";
            this.button_subQLSP_delete.UseVisualStyleBackColor = true;
            this.button_subQLSP_delete.Click += new System.EventHandler(this.Button_subQLSP_delete_Click);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(870, 955);
            this.Controls.Add(this.button_subQLSP_delete);
            this.Controls.Add(this.button_subQLSP_update);
            this.Controls.Add(this.button_subQLSP_add);
            this.Controls.Add(this.button_subQLSP_sort);
            this.Controls.Add(this.button_subQLSP_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.textBox_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSanPham";
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
        private System.Windows.Forms.Label label_namesp;
        private System.Windows.Forms.TextBox textBox_namesp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_dvtsp;
        private System.Windows.Forms.Label label_dvtsp;
        private System.Windows.Forms.Label label_loaisp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox_pricesp;
        private System.Windows.Forms.Label label_pricesp;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button_subQLSP_search;
        private System.Windows.Forms.Button button_subQLSP_sort;
        private System.Windows.Forms.Button button_subQLSP_add;
        private System.Windows.Forms.Button button_subQLSP_update;
        private System.Windows.Forms.Button button_subQLSP_delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}