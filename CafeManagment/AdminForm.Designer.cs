namespace CafeManagment
{
    partial class AdminForm
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
            panel2 = new Panel();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label7 = new Label();
            button1 = new Button();
            label5 = new Label();
            itemsGV = new DataGridView();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemsGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(itemsGV);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label3);
            panel2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel2.Location = new Point(132, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(1067, 611);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 16.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(915, 92);
            label1.Name = "label1";
            label1.Size = new Size(131, 38);
            label1.TabIndex = 19;
            label1.Text = "Prod. List";
            // 
            // button4
            // 
            button4.BackColor = Color.ForestGreen;
            button4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.GhostWhite;
            button4.Location = new Point(262, 284);
            button4.Name = "button4";
            button4.Size = new Size(114, 44);
            button4.TabIndex = 18;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.GhostWhite;
            button3.Location = new Point(142, 284);
            button3.Name = "button3";
            button3.Size = new Size(114, 44);
            button3.TabIndex = 17;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(182, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 34);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(182, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 34);
            textBox2.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.GhostWhite;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(106, 45);
            button2.TabIndex = 13;
            button2.Text = "LogOut";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Candara", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label7.ForeColor = Color.DeepPink;
            label7.Location = new Point(35, 207);
            label7.Name = "label7";
            label7.Size = new Size(132, 28);
            label7.TabIndex = 9;
            label7.Text = "Prod Price   :";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.GhostWhite;
            button1.Location = new Point(22, 284);
            button1.Name = "button1";
            button1.Size = new Size(114, 44);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Candara", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label5.ForeColor = Color.DeepPink;
            label5.Location = new Point(36, 158);
            label5.Name = "label5";
            label5.Size = new Size(131, 28);
            label5.TabIndex = 6;
            label5.Text = "Prod Name :";
            // 
            // itemsGV
            // 
            itemsGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            itemsGV.BackgroundColor = SystemColors.ButtonHighlight;
            itemsGV.BorderStyle = BorderStyle.None;
            itemsGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            itemsGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            itemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsGV.EnableHeadersVisualStyles = false;
            itemsGV.Location = new Point(415, 133);
            itemsGV.Name = "itemsGV";
            itemsGV.RowHeadersWidth = 51;
            itemsGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemsGV.Size = new Size(617, 390);
            itemsGV.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Beverage" });
            comboBox1.Location = new Point(22, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 33);
            comboBox1.TabIndex = 3;
            comboBox1.Text = " Choose Category";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Candara", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DeepPink;
            label3.Location = new Point(460, 19);
            label3.Name = "label3";
            label3.Size = new Size(219, 38);
            label3.TabIndex = 0;
            label3.Text = "Menage Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1216, -1);
            label2.Name = "label2";
            label2.Size = new Size(35, 38);
            label2.TabIndex = 20;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(1250, 661);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button2;
        private Label label7;
        private Button button1;
        private Label label5;
        private DataGridView itemsGV;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Label label2;
    }
}