namespace RestaurantReservationWinForm
{
    partial class FormCustomer
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
            pictureBox2 = new PictureBox();
            textBox4 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            label5 = new Label();
            button2 = new Button();
            Food = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            tableDgv = new DataGridView();
            textBox6 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            button5.Location = new Point(855, 569);
            button5.Name = "button5";
            button5.Size = new Size(80, 46);
            button5.TabIndex = 110;
            button5.Text = "Lưu";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("SVN-Oscine", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(596, 214);
            label4.Name = "label4";
            label4.Size = new Size(205, 27);
            label4.TabIndex = 109;
            label4.Text = "Thông Tin Khách Hàng";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(910, 110);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 108;
            pictureBox2.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("SVN-Oscine", 9F);
            textBox4.Location = new Point(596, 113);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Tìm kiếm";
            textBox4.Size = new Size(308, 27);
            textBox4.TabIndex = 107;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label1.Location = new Point(596, 424);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 106;
            label1.Text = "Số điện thoại";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("SVN-Oscine", 9F);
            textBox2.Location = new Point(596, 381);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 27);
            textBox2.TabIndex = 105;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(855, 213);
            button3.Name = "button3";
            button3.Size = new Size(80, 34);
            button3.TabIndex = 104;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("SVN-Oscine", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(596, 70);
            label5.Name = "label5";
            label5.Size = new Size(209, 27);
            label5.TabIndex = 103;
            label5.Text = "Danh Sách Khách Hàng";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(726, 569);
            button2.Name = "button2";
            button2.Size = new Size(113, 46);
            button2.TabIndex = 102;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // Food
            // 
            Food.Anchor = AnchorStyles.None;
            Food.AutoSize = true;
            Food.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            Food.Location = new Point(596, 358);
            Food.Name = "Food";
            Food.Size = new Size(111, 20);
            Food.TabIndex = 101;
            Food.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label3.Location = new Point(596, 289);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 100;
            label3.Text = "Mã";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(52, 78, 131);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(596, 569);
            button1.Name = "button1";
            button1.Size = new Size(113, 46);
            button1.TabIndex = 98;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("SVN-Oscine", 9F);
            textBox1.Location = new Point(596, 315);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(339, 27);
            textBox1.TabIndex = 97;
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
            tableDgv.Size = new Size(555, 729);
            tableDgv.TabIndex = 96;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("SVN-Oscine", 9F);
            textBox6.Location = new Point(596, 447);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(339, 27);
            textBox6.TabIndex = 116;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("SVN-Oscine", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(596, 490);
            label2.Name = "label2";
            label2.Size = new Size(273, 20);
            label2.TabIndex = 117;
            label2.Text = "Lưu ý: Mã là mặc định không thể thay đổi!";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(975, 729);
            Controls.Add(label2);
            Controls.Add(textBox6);
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
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(tableDgv);
            Name = "FormCustomer";
            Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button button1;
        private TextBox textBox1;
        private DataGridView tableDgv;
        private TextBox textBox6;
        private Label label2;
    }
}