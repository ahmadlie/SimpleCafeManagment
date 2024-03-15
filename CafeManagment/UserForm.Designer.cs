namespace CafeManagment
{
    partial class UserForm
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
            label1 = new Label();
            panel11 = new Panel();
            button2 = new Button();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            itemsGV = new DataGridView();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(1215, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 38);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Snow;
            panel11.Controls.Add(button2);
            panel11.Controls.Add(label9);
            panel11.Controls.Add(dataGridView1);
            panel11.Controls.Add(label7);
            panel11.Controls.Add(button1);
            panel11.Controls.Add(label6);
            panel11.Controls.Add(label5);
            panel11.Controls.Add(label4);
            panel11.Controls.Add(itemsGV);
            panel11.Controls.Add(comboBox1);
            panel11.Controls.Add(label3);
            panel11.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel11.Location = new Point(142, 27);
            panel11.Name = "panel11";
            panel11.Size = new Size(1067, 611);
            panel11.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.GhostWhite;
            button2.Location = new Point(958, 3);
            button2.Name = "button2";
            button2.Size = new Size(106, 45);
            button2.TabIndex = 13;
            button2.Text = "LogOut";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.PowderBlue;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.InfoText;
            label9.Location = new Point(525, 308);
            label9.Name = "label9";
            label9.Size = new Size(144, 29);
            label9.TabIndex = 12;
            label9.Text = "Your Orders";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(268, 350);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(668, 188);
            dataGridView1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Yellow;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(23, 212);
            label7.Name = "label7";
            label7.Size = new Size(187, 30);
            label7.TabIndex = 9;
            label7.Text = "Quantity          :     ";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.GhostWhite;
            button1.Location = new Point(23, 260);
            button1.Name = "button1";
            button1.Size = new Size(187, 44);
            button1.TabIndex = 8;
            button1.Text = "Add  To  Card";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(748, 552);
            label6.Name = "label6";
            label6.Size = new Size(188, 26);
            label6.TabIndex = 7;
            label6.Text = "Order Amount :     ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Yellow;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(22, 172);
            label5.Name = "label5";
            label5.Size = new Size(189, 30);
            label5.TabIndex = 6;
            label5.Text = "Seller Name     :     ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(22, 133);
            label4.Name = "label4";
            label4.Size = new Size(188, 30);
            label4.TabIndex = 5;
            label4.Text = "Order Number :     ";
            // 
            // itemsGV
            // 
            itemsGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            itemsGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            itemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsGV.EnableHeadersVisualStyles = false;
            itemsGV.Location = new Point(268, 80);
            itemsGV.Name = "itemsGV";
            itemsGV.RowHeadersWidth = 51;
            itemsGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemsGV.Size = new Size(668, 188);
            itemsGV.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Beverage" });
            comboBox1.Location = new Point(22, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 33);
            comboBox1.TabIndex = 3;
            comboBox1.Text = " Choose Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PowderBlue;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(443, 33);
            label3.Name = "label3";
            label3.Size = new Size(305, 29);
            label3.TabIndex = 0;
            label3.Text = "You can choose your orders";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(1250, 661);
            Controls.Add(panel11);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "UserForm";
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel11;
        private Button button2;
        private Label label9;
        private DataGridView dataGridView1;
        private Label label7;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView itemsGV;
        private ComboBox comboBox1;
        private Label label3;
    }
}