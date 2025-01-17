﻿namespace RestaurantReservationWinForm
{
    partial class FormTable
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
            button5 = new Button();
            label4 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            Food = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            tableDgv = new DataGridView();
            cbFood = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableDgv).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = SystemColors.Info;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(64, 64, 64);
            button5.Location = new Point(818, 455);
            button5.Name = "button5";
            button5.Size = new Size(80, 46);
            button5.TabIndex = 70;
            button5.Text = "Lưu";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("SVN-Oscine", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(559, 81);
            label4.Name = "label4";
            label4.Size = new Size(135, 27);
            label4.TabIndex = 69;
            label4.Text = "Thông Tin Bàn";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label1.Location = new Point(559, 288);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 65;
            label1.Text = "Trạng thái";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("SVN-Oscine", 9F);
            textBox2.Location = new Point(559, 246);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 27);
            textBox2.TabIndex = 64;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(818, 80);
            button3.Name = "button3";
            button3.Size = new Size(80, 34);
            button3.TabIndex = 63;
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
            button2.Location = new Point(689, 455);
            button2.Name = "button2";
            button2.Size = new Size(113, 46);
            button2.TabIndex = 61;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // Food
            // 
            Food.Anchor = AnchorStyles.None;
            Food.AutoSize = true;
            Food.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            Food.Location = new Point(559, 223);
            Food.Name = "Food";
            Food.Size = new Size(60, 20);
            Food.TabIndex = 60;
            Food.Text = "Tên bàn";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label3.Location = new Point(559, 154);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 59;
            label3.Text = "Mã bàn";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(52, 78, 131);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(559, 455);
            button1.Name = "button1";
            button1.Size = new Size(113, 46);
            button1.TabIndex = 57;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("SVN-Oscine", 9F);
            textBox1.Location = new Point(559, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 27);
            textBox1.TabIndex = 56;
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
            tableDgv.Size = new Size(511, 587);
            tableDgv.TabIndex = 54;
            // 
            // cbFood
            // 
            cbFood.Anchor = AnchorStyles.None;
            cbFood.DisplayMember = "Trống";
            cbFood.Font = new Font("SVN-Oscine", 9F);
            cbFood.FormattingEnabled = true;
            cbFood.Items.AddRange(new object[] { "Trống" });
            cbFood.Location = new Point(559, 311);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(339, 28);
            cbFood.TabIndex = 71;
            cbFood.ValueMember = "Trống";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(559, 375);
            label2.Name = "label2";
            label2.Size = new Size(295, 20);
            label2.TabIndex = 72;
            label2.Text = "Lưu ý: Trạng thái bàn luôn mặc định là trống!";
            // 
            // FormTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(946, 587);
            Controls.Add(label2);
            Controls.Add(cbFood);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Food);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(tableDgv);
            Name = "FormTable";
            Text = "FormTable";
            ((System.ComponentModel.ISupportInitialize)tableDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label4;
        private Label label1;
        private TextBox textBox2;
        private Button button3;
        private Button button2;
        private Label Food;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private DataGridView tableDgv;
        private ComboBox cbFood;
        private Label label2;
    }
}