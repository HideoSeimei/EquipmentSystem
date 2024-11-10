namespace EquipmentSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            label17 = new Label();
            label22 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            groupBox7 = new GroupBox();
            groupBox4 = new GroupBox();
            button4 = new Button();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            pictureBox4 = new PictureBox();
            label21 = new Label();
            groupBox3 = new GroupBox();
            button3 = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            pictureBox3 = new PictureBox();
            label16 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label8 = new Label();
            label6 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.SeaGreen;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.None;
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label17);
            splitContainer1.Panel1.Controls.Add(label22);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Panel2.Controls.Add(groupBox7);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(902, 428);
            splitContainer1.SplitterDistance = 165;
            splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 110);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 10;
            label2.Text = "Users";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(51, 54);
            label17.Name = "label17";
            label17.Size = new Size(54, 18);
            label17.TabIndex = 9;
            label17.Text = "Home";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(51, 166);
            label22.Name = "label22";
            label22.Size = new Size(56, 18);
            label22.TabIndex = 8;
            label22.Text = "About";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(52, 337);
            label4.Name = "label4";
            label4.Size = new Size(50, 14);
            label4.TabIndex = 3;
            label4.Text = "Log out";
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownHeight = 75;
            comboBox1.DropDownWidth = 75;
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.SeaGreen;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(592, 20);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(116, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Text = " Category";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.White;
            groupBox7.Controls.Add(groupBox4);
            groupBox7.Controls.Add(groupBox3);
            groupBox7.Controls.Add(groupBox1);
            groupBox7.Controls.Add(groupBox2);
            groupBox7.Location = new Point(24, 62);
            groupBox7.Margin = new Padding(3, 2, 3, 2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 2, 3, 2);
            groupBox7.Size = new Size(683, 344);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.WhiteSmoke;
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(pictureBox4);
            groupBox4.Controls.Add(label21);
            groupBox4.Location = new Point(382, 188);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(234, 122);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.CadetBlue;
            button4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(121, 92);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(94, 22);
            button4.TabIndex = 8;
            button4.Text = "BORROW";
            button4.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.DimGray;
            label18.Location = new Point(124, 60);
            label18.Name = "label18";
            label18.Size = new Size(64, 14);
            label18.TabIndex = 7;
            label18.Text = "Time: N/A";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.DimGray;
            label19.Location = new Point(125, 38);
            label19.Name = "label19";
            label19.Size = new Size(54, 14);
            label19.TabIndex = 6;
            label19.Text = "Stock: 1";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.DimGray;
            label20.Location = new Point(124, 17);
            label20.Name = "label20";
            label20.Size = new Size(50, 14);
            label20.TabIndex = 5;
            label20.Text = "LED TV";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(11, 16);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(108, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.SeaGreen;
            label21.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(26, 95);
            label21.Name = "label21";
            label21.Size = new Size(70, 16);
            label21.TabIndex = 3;
            label21.Text = "Available";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(label16);
            groupBox3.Location = new Point(63, 188);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(234, 122);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(121, 92);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(94, 22);
            button3.TabIndex = 8;
            button3.Text = "BORROW";
            button3.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(125, 60);
            label13.Name = "label13";
            label13.Size = new Size(64, 14);
            label13.TabIndex = 7;
            label13.Text = "Time: N/A";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(125, 38);
            label14.Name = "label14";
            label14.Size = new Size(54, 14);
            label14.TabIndex = 6;
            label14.Text = "Stock: 4";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(124, 17);
            label15.Name = "label15";
            label15.Size = new Size(95, 14);
            label15.TabIndex = 5;
            label15.Text = "Extension Cord";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 16);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(108, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.SeaGreen;
            label16.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(26, 95);
            label16.Name = "label16";
            label16.Size = new Size(70, 16);
            label16.TabIndex = 3;
            label16.Text = "Available";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(382, 30);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(234, 122);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(121, 92);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(94, 22);
            button2.TabIndex = 8;
            button2.Text = "BORROW";
            button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(124, 60);
            label7.Name = "label7";
            label7.Size = new Size(64, 14);
            label7.TabIndex = 7;
            label7.Text = "Time: N/A";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(125, 38);
            label10.Name = "label10";
            label10.Size = new Size(54, 14);
            label10.TabIndex = 6;
            label10.Text = "Stock: 4";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(124, 17);
            label11.Name = "label11";
            label11.Size = new Size(39, 14);
            label11.TabIndex = 5;
            label11.Text = "HDMI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.SeaGreen;
            label12.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(26, 95);
            label12.Name = "label12";
            label12.Size = new Size(70, 16);
            label12.TabIndex = 3;
            label12.Text = "Available";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(63, 30);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(234, 122);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(121, 92);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 22);
            button1.TabIndex = 8;
            button1.Text = "BORROW";
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(124, 60);
            label8.Name = "label8";
            label8.Size = new Size(64, 14);
            label8.TabIndex = 7;
            label8.Text = "Time: N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(125, 38);
            label6.Name = "label6";
            label6.Size = new Size(54, 14);
            label6.TabIndex = 6;
            label6.Text = "Stock: 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(124, 17);
            label3.Name = "label3";
            label3.Size = new Size(60, 14);
            label3.TabIndex = 5;
            label3.Text = "Projector";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 16);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.SeaGreen;
            label9.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(26, 95);
            label9.Name = "label9";
            label9.Size = new Size(70, 16);
            label9.TabIndex = 3;
            label9.Text = "Available";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(216, 24);
            label5.Name = "label5";
            label5.Size = new Size(48, 14);
            label5.TabIndex = 5;
            label5.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 20);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "Equipments";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 428);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Form3";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private GroupBox groupBox7;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label3;
        private Button button1;
        private GroupBox groupBox4;
        private Button button4;
        private Label label18;
        private Label label19;
        private Label label20;
        private PictureBox pictureBox4;
        private Label label21;
        private GroupBox groupBox3;
        private Button button3;
        private Label label13;
        private Label label14;
        private Label label15;
        private PictureBox pictureBox3;
        private Label label16;
        private GroupBox groupBox1;
        private Button button2;
        private Label label7;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label2;
        private Label label17;
        private Label label22;
    }
}