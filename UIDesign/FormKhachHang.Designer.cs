namespace UIDesign
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.button_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_agekh = new System.Windows.Forms.TextBox();
            this.label_cmndnv = new System.Windows.Forms.Label();
            this.textBox_sdtkh = new System.Windows.Forms.TextBox();
            this.textBox_namenv = new System.Windows.Forms.TextBox();
            this.label_phonenv = new System.Windows.Forms.Label();
            this.label_namekh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button_subQLKH_search = new System.Windows.Forms.Button();
            this.button_subQLKH_sort = new System.Windows.Forms.Button();
            this.button_subQLKH_add = new System.Windows.Forms.Button();
            this.button_subQLKH_update = new System.Windows.Forms.Button();
            this.button_subQLKH_delete = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox_agekh);
            this.panel2.Controls.Add(this.label_cmndnv);
            this.panel2.Controls.Add(this.textBox_sdtkh);
            this.panel2.Controls.Add(this.textBox_namenv);
            this.panel2.Controls.Add(this.label_phonenv);
            this.panel2.Controls.Add(this.label_namekh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(79, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 342);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(9, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 1);
            this.panel4.TabIndex = 3;
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
            // textBox_agekh
            // 
            this.textBox_agekh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_agekh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_agekh.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_agekh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_agekh.Location = new System.Drawing.Point(108, 253);
            this.textBox_agekh.Name = "textBox_agekh";
            this.textBox_agekh.Size = new System.Drawing.Size(197, 22);
            this.textBox_agekh.TabIndex = 2;
            // 
            // label_cmndnv
            // 
            this.label_cmndnv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cmndnv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_cmndnv.Location = new System.Drawing.Point(4, 252);
            this.label_cmndnv.Name = "label_cmndnv";
            this.label_cmndnv.Size = new System.Drawing.Size(98, 23);
            this.label_cmndnv.TabIndex = 1;
            this.label_cmndnv.Text = "Tuổi";
            this.label_cmndnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_sdtkh
            // 
            this.textBox_sdtkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.textBox_sdtkh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_sdtkh.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sdtkh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_sdtkh.Location = new System.Drawing.Point(508, 87);
            this.textBox_sdtkh.Name = "textBox_sdtkh";
            this.textBox_sdtkh.Size = new System.Drawing.Size(161, 22);
            this.textBox_sdtkh.TabIndex = 2;
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
            // label_namekh
            // 
            this.label_namekh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namekh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_namekh.Location = new System.Drawing.Point(4, 86);
            this.label_namekh.Name = "label_namekh";
            this.label_namekh.Size = new System.Drawing.Size(98, 23);
            this.label_namekh.TabIndex = 1;
            this.label_namekh.Text = "Họ và tên";
            this.label_namekh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // button_subQLKH_search
            // 
            this.button_subQLKH_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subQLKH_search.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subQLKH_search.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subQLKH_search.Location = new System.Drawing.Point(740, 360);
            this.button_subQLKH_search.Name = "button_subQLKH_search";
            this.button_subQLKH_search.Size = new System.Drawing.Size(118, 37);
            this.button_subQLKH_search.TabIndex = 4;
            this.button_subQLKH_search.Text = "Tìm kiếm";
            this.button_subQLKH_search.UseVisualStyleBackColor = true;
            this.button_subQLKH_search.Click += new System.EventHandler(this.Button_subQLKH_search_Click);
            // 
            // button_subQLKH_sort
            // 
            this.button_subQLKH_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subQLKH_sort.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subQLKH_sort.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subQLKH_sort.Location = new System.Drawing.Point(740, 647);
            this.button_subQLKH_sort.Name = "button_subQLKH_sort";
            this.button_subQLKH_sort.Size = new System.Drawing.Size(118, 37);
            this.button_subQLKH_sort.TabIndex = 4;
            this.button_subQLKH_sort.Text = "Sắp xếp";
            this.button_subQLKH_sort.UseVisualStyleBackColor = true;
            this.button_subQLKH_sort.Click += new System.EventHandler(this.Button_subQLKH_sort_Click);
            // 
            // button_subQLKH_add
            // 
            this.button_subQLKH_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subQLKH_add.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subQLKH_add.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subQLKH_add.Location = new System.Drawing.Point(740, 432);
            this.button_subQLKH_add.Name = "button_subQLKH_add";
            this.button_subQLKH_add.Size = new System.Drawing.Size(118, 37);
            this.button_subQLKH_add.TabIndex = 5;
            this.button_subQLKH_add.Text = "Thêm";
            this.button_subQLKH_add.UseVisualStyleBackColor = true;
            this.button_subQLKH_add.Click += new System.EventHandler(this.Button_subQLKH_add_Click);
            // 
            // button_subQLKH_update
            // 
            this.button_subQLKH_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subQLKH_update.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subQLKH_update.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subQLKH_update.Location = new System.Drawing.Point(740, 504);
            this.button_subQLKH_update.Name = "button_subQLKH_update";
            this.button_subQLKH_update.Size = new System.Drawing.Size(118, 37);
            this.button_subQLKH_update.TabIndex = 6;
            this.button_subQLKH_update.Text = "Chỉnh sửa";
            this.button_subQLKH_update.UseVisualStyleBackColor = true;
            this.button_subQLKH_update.Click += new System.EventHandler(this.Button_subQLKH_update_Click);
            // 
            // button_subQLKH_delete
            // 
            this.button_subQLKH_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subQLKH_delete.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subQLKH_delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_subQLKH_delete.Location = new System.Drawing.Point(740, 578);
            this.button_subQLKH_delete.Name = "button_subQLKH_delete";
            this.button_subQLKH_delete.Size = new System.Drawing.Size(118, 37);
            this.button_subQLKH_delete.TabIndex = 7;
            this.button_subQLKH_delete.Text = "Xóa";
            this.button_subQLKH_delete.UseVisualStyleBackColor = true;
            this.button_subQLKH_delete.Click += new System.EventHandler(this.Button_subQLKH_delete_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(870, 955);
            this.Controls.Add(this.button_subQLKH_delete);
            this.Controls.Add(this.button_subQLKH_update);
            this.Controls.Add(this.button_subQLKH_add);
            this.Controls.Add(this.button_subQLKH_sort);
            this.Controls.Add(this.button_subQLKH_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.textBox_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKhachHang";
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
        private System.Windows.Forms.Label label_namekh;
        private System.Windows.Forms.TextBox textBox_namenv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_agekh;
        private System.Windows.Forms.Label label_cmndnv;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox_sdtkh;
        private System.Windows.Forms.Label label_phonenv;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button_subQLKH_search;
        private System.Windows.Forms.Button button_subQLKH_sort;
        private System.Windows.Forms.Button button_subQLKH_add;
        private System.Windows.Forms.Button button_subQLKH_update;
        private System.Windows.Forms.Button button_subQLKH_delete;
    }
}