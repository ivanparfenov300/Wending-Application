namespace WinFormsApp1
{
    partial class Form7
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
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            menuStrip3 = new MenuStrip();
            записиToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            button4 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            аналитиковААToolStripMenuItem = new ToolStripMenuItem();
            моиАвтоматыToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            menuStrip3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(162, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(646, 386);
            dataGridView1.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(4, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(152, 410);
            panel4.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 227);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "notes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 149);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "show";
            // 
            // panel5
            // 
            panel5.Controls.Add(menuStrip3);
            panel5.Location = new Point(18, 179);
            panel5.Name = "panel5";
            panel5.Size = new Size(131, 27);
            panel5.TabIndex = 5;
            // 
            // menuStrip3
            // 
            menuStrip3.Items.AddRange(new ToolStripItem[] { записиToolStripMenuItem });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(131, 24);
            menuStrip3.TabIndex = 0;
            menuStrip3.Text = "menuStrip3";
            // 
            // записиToolStripMenuItem
            // 
            записиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            записиToolStripMenuItem.Name = "записиToolStripMenuItem";
            записиToolStripMenuItem.Size = new Size(43, 20);
            записиToolStripMenuItem.Text = "note";
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
            button4.Location = new Point(18, 88);
            button4.Name = "button4";
            button4.Size = new Size(121, 40);
            button4.TabIndex = 4;
            button4.Text = "change";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(18, 27);
            button2.Name = "button2";
            button2.Size = new Size(121, 40);
            button2.TabIndex = 1;
            button2.Text = "status of machine";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 45);
            panel1.TabIndex = 9;
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
            аналитиковААToolStripMenuItem.Size = new Size(71, 20);
            аналитиковААToolStripMenuItem.Text = "mechanic";
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
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "payment method";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "last check";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "next check";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "resource of machine";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "condititon";
            Column6.Name = "Column6";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "Form7";
            Text = "repair";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private Panel panel5;
        private Button button4;
        private Button button2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem аналитиковААToolStripMenuItem;
        private ToolStripMenuItem моиАвтоматыToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip3;
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