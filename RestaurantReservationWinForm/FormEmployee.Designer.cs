namespace RestaurantReservationWinForm
{
    partial class FormEmployee
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
            tableDgv = new DataGridView();
            button5 = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            textBox4 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            label5 = new Label();
            button2 = new Button();
            Food = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            cbFood = new ComboBox();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            tableDgv.Size = new Size(511, 761);
            tableDgv.TabIndex = 73;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = SystemColors.Info;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(64, 64, 64);
            button5.Location = new Point(813, 641);
            button5.Name = "button5";
            button5.Size = new Size(80, 46);
            button5.TabIndex = 89;
            button5.Text = "Lưu";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("SVN-Oscine", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(554, 196);
            label4.Name = "label4";
            label4.Size = new Size(190, 27);
            label4.TabIndex = 88;
            label4.Text = "Thông Tin Nhân Viên";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(868, 92);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 87;
            pictureBox2.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("SVN-Oscine", 9F);
            textBox4.Location = new Point(554, 95);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Tìm kiếm";
            textBox4.Size = new Size(308, 27);
            textBox4.TabIndex = 86;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label1.Location = new Point(554, 405);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 84;
            label1.Text = "Giới tính";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("SVN-Oscine", 9F);
            textBox2.Location = new Point(554, 363);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 27);
            textBox2.TabIndex = 83;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(813, 195);
            button3.Name = "button3";
            button3.Size = new Size(80, 34);
            button3.TabIndex = 82;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("SVN-Oscine", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(554, 52);
            label5.Name = "label5";
            label5.Size = new Size(194, 27);
            label5.TabIndex = 81;
            label5.Text = "Danh Sách Nhân Viên";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(684, 641);
            button2.Name = "button2";
            button2.Size = new Size(113, 46);
            button2.TabIndex = 80;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // Food
            // 
            Food.Anchor = AnchorStyles.None;
            Food.AutoSize = true;
            Food.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            Food.Location = new Point(554, 340);
            Food.Name = "Food";
            Food.Size = new Size(33, 20);
            Food.TabIndex = 79;
            Food.Text = "Tên";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label3.Location = new Point(554, 271);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 78;
            label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label2.Location = new Point(677, 271);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 77;
            label2.Text = "Vai trò";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(52, 78, 131);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(554, 641);
            button1.Name = "button1";
            button1.Size = new Size(113, 46);
            button1.TabIndex = 76;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("SVN-Oscine", 9F);
            textBox1.Location = new Point(554, 297);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 27);
            textBox1.TabIndex = 75;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("SVN-Oscine", 9F);
            textBox5.Location = new Point(677, 297);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(216, 27);
            textBox5.TabIndex = 90;
            // 
            // cbFood
            // 
            cbFood.Anchor = AnchorStyles.None;
            cbFood.DisplayMember = "Nam";
            cbFood.Font = new Font("SVN-Oscine", 9F);
            cbFood.FormattingEnabled = true;
            cbFood.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbFood.Location = new Point(554, 428);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(339, 28);
            cbFood.TabIndex = 91;
            cbFood.ValueMember = "Nam";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("SVN-Oscine", 9F);
            textBox3.Location = new Point(554, 495);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(339, 27);
            textBox3.TabIndex = 93;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label6.Location = new Point(554, 472);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 92;
            label6.Text = "Số điện thoại";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("SVN-Oscine", 9F);
            textBox6.Location = new Point(554, 562);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(339, 27);
            textBox6.TabIndex = 95;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label7.Location = new Point(554, 539);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 94;
            label7.Text = "Địa chỉ";
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(938, 761);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(cbFood);
            Controls.Add(textBox5);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(Food);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(tableDgv);
            Name = "FormEmployee";
            Text = "FormEmployee";
            ((System.ComponentModel.ISupportInitialize)tableDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView tableDgv;
        private Button button5;
        private Label label4;
        private PictureBox pictureBox2;
        private TextBox textBox4;
        private Label label1;
        private TextBox textBox2;
        private Button button3;
        private Label label5;
        private Button button2;
        private Label Food;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox5;
        private ComboBox cbFood;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
    }
}