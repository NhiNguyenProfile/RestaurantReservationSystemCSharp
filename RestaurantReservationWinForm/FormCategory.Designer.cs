﻿namespace RestaurantReservationWinForm
{
    partial class FormCategory
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
            label2 = new Label();
            button5 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            Food = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            tableDgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tableDgv).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(556, 303);
            label2.Name = "label2";
            label2.Size = new Size(340, 20);
            label2.TabIndex = 85;
            label2.Text = "Lưu ý: Mã danh mục là mặc định không thể thay đổi!";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = SystemColors.Info;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(64, 64, 64);
            button5.Location = new Point(815, 385);
            button5.Name = "button5";
            button5.Size = new Size(80, 46);
            button5.TabIndex = 83;
            button5.Text = "Lưu";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("SVN-Oscine", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(556, 91);
            label4.Name = "label4";
            label4.Size = new Size(186, 27);
            label4.TabIndex = 82;
            label4.Text = "Thông Tin Danh Mục";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("SVN-Oscine", 9F);
            textBox2.Location = new Point(556, 256);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 27);
            textBox2.TabIndex = 80;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(815, 90);
            button3.Name = "button3";
            button3.Size = new Size(80, 34);
            button3.TabIndex = 79;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(686, 385);
            button2.Name = "button2";
            button2.Size = new Size(113, 46);
            button2.TabIndex = 78;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // Food
            // 
            Food.Anchor = AnchorStyles.None;
            Food.AutoSize = true;
            Food.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            Food.Location = new Point(556, 233);
            Food.Name = "Food";
            Food.Size = new Size(100, 20);
            Food.TabIndex = 77;
            Food.Text = "Tên danh mục";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label3.Location = new Point(556, 164);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 76;
            label3.Text = "Mã danh mục";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(52, 78, 131);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(556, 385);
            button1.Name = "button1";
            button1.Size = new Size(113, 46);
            button1.TabIndex = 75;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("SVN-Oscine", 9F);
            textBox1.Location = new Point(556, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 27);
            textBox1.TabIndex = 74;
            // 
            // tableDgv
            // 
            tableDgv.BackgroundColor = Color.FromArgb(236, 236, 236);
            tableDgv.BorderStyle = BorderStyle.None;
            tableDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDgv.Dock = DockStyle.Left;
            tableDgv.Location = new Point(0, 0);
            tableDgv.Name = "tableDgv";
            tableDgv.RowHeadersWidth = 51;
            tableDgv.Size = new Size(511, 542);
            tableDgv.TabIndex = 73;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(938, 542);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Food);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(tableDgv);
            Name = "FormCategory";
            Text = "FormCategory";
            ((System.ComponentModel.ISupportInitialize)tableDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button5;
        private Label label4;
        private TextBox textBox2;
        private Button button3;
        private Button button2;
        private Label Food;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private DataGridView tableDgv;
    }
}