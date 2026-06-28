namespace WinFormsApp1
{
    partial class Form6
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
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            аналитиковААToolStripMenuItem = new ToolStripMenuItem();
            моиАвтоматыToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            menuStrip2 = new MenuStrip();
            записиToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 45);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Location = new Point(0, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 410);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(619, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 45);
            panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { аналитиковААToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(188, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // аналитиковААToolStripMenuItem
            // 
            аналитиковААToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { моиАвтоматыToolStripMenuItem, выходToolStripMenuItem });
            аналитиковААToolStripMenuItem.Name = "аналитиковААToolStripMenuItem";
            аналитиковААToolStripMenuItem.Size = new Size(56, 20);
            аналитиковААToolStripMenuItem.Text = "analyst";
            // 
            // моиАвтоматыToolStripMenuItem
            // 
            моиАвтоматыToolStripMenuItem.Name = "моиАвтоматыToolStripMenuItem";
            моиАвтоматыToolStripMenuItem.Size = new Size(180, 22);
            моиАвтоматыToolStripMenuItem.Text = "my machines";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "exit";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2026_01_21_192558;
            pictureBox1.Location = new Point(3, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(3, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(152, 410);
            panel4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 330);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "notes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 258);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "show";
            // 
            // panel5
            // 
            panel5.Controls.Add(menuStrip2);
            panel5.Location = new Point(18, 287);
            panel5.Name = "panel5";
            panel5.Size = new Size(121, 25);
            panel5.TabIndex = 5;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { записиToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(121, 24);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // записиToolStripMenuItem
            // 
            записиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            записиToolStripMenuItem.Name = "записиToolStripMenuItem";
            записиToolStripMenuItem.Size = new Size(48, 20);
            записиToolStripMenuItem.Text = "notes";
            записиToolStripMenuItem.Click += записиToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "10";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "20";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(180, 22);
            toolStripMenuItem4.Text = "30";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(180, 22);
            toolStripMenuItem5.Text = "40";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(180, 22);
            toolStripMenuItem6.Text = "50";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Location = new Point(18, 144);
            button4.Name = "button4";
            button4.Size = new Size(121, 40);
            button4.TabIndex = 4;
            button4.Text = "change";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Location = new Point(18, 203);
            button3.Name = "button3";
            button3.Size = new Size(121, 40);
            button3.TabIndex = 3;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(18, 84);
            button1.Name = "button1";
            button1.Size = new Size(121, 40);
            button1.TabIndex = 2;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(18, 23);
            button2.Name = "button2";
            button2.Size = new Size(121, 40);
            button2.TabIndex = 1;
            button2.Text = "sale management";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView2.Location = new Point(161, 52);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(637, 386);
            dataGridView2.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "number of machine";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "number of item";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "quantity";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "date of sale";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "payment method";
            Column6.Name = "Column6";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip2;
            Name = "Form6";
            Text = "analytics";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem аналитиковААToolStripMenuItem;
        private ToolStripMenuItem моиАвтоматыToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button button2;
        private DataGridView dataGridView2;
        private Button button1;
        private Panel panel5;
        private MenuStrip menuStrip2;
        private Button button4;
        private Button button3;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem записиToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}