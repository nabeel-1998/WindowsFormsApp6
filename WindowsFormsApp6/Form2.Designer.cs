
namespace WindowsFormsApp6
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DASHBOARD_PAGE = new System.Windows.Forms.TabPage();
            this.EMPLOYEES_PAGE = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EMPLOYEES_LABEL = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.HALFDAY_LABEL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LATE_LABEL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ABSENT_LABEL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PRESENT_LABEL = new System.Windows.Forms.Label();
            this.ATTENDANCE_PAGE = new System.Windows.Forms.TabPage();
            this.DATA_PAGE = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DASHBOARD_PAGE.SuspendLayout();
            this.EMPLOYEES_PAGE.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 554);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "DASHBOARD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "EMPLOYEES";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "ATTENDANCE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "DATA";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DASHBOARD_PAGE);
            this.tabControl1.Controls.Add(this.EMPLOYEES_PAGE);
            this.tabControl1.Controls.Add(this.ATTENDANCE_PAGE);
            this.tabControl1.Controls.Add(this.DATA_PAGE);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(200, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 554);
            this.tabControl1.TabIndex = 1;
            // 
            // DASHBOARD_PAGE
            // 
            this.DASHBOARD_PAGE.BackColor = System.Drawing.SystemColors.Control;
            this.DASHBOARD_PAGE.Controls.Add(this.panel6);
            this.DASHBOARD_PAGE.Controls.Add(this.panel4);
            this.DASHBOARD_PAGE.Controls.Add(this.panel5);
            this.DASHBOARD_PAGE.Controls.Add(this.panel3);
            this.DASHBOARD_PAGE.Controls.Add(this.panel2);
            this.DASHBOARD_PAGE.Location = new System.Drawing.Point(4, 25);
            this.DASHBOARD_PAGE.Name = "DASHBOARD_PAGE";
            this.DASHBOARD_PAGE.Padding = new System.Windows.Forms.Padding(3);
            this.DASHBOARD_PAGE.Size = new System.Drawing.Size(534, 525);
            this.DASHBOARD_PAGE.TabIndex = 0;
            this.DASHBOARD_PAGE.Text = "DASHBAORD";
            // 
            // EMPLOYEES_PAGE
            // 
            this.EMPLOYEES_PAGE.Controls.Add(this.dataGridView1);
            this.EMPLOYEES_PAGE.Location = new System.Drawing.Point(4, 25);
            this.EMPLOYEES_PAGE.Name = "EMPLOYEES_PAGE";
            this.EMPLOYEES_PAGE.Padding = new System.Windows.Forms.Padding(3);
            this.EMPLOYEES_PAGE.Size = new System.Drawing.Size(534, 525);
            this.EMPLOYEES_PAGE.TabIndex = 1;
            this.EMPLOYEES_PAGE.Text = "EMPLOYEES";
            this.EMPLOYEES_PAGE.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.EMPLOYEES_LABEL);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(168, 364);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 8;
            // 
            // EMPLOYEES_LABEL
            // 
            this.EMPLOYEES_LABEL.AutoSize = true;
            this.EMPLOYEES_LABEL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMPLOYEES_LABEL.Location = new System.Drawing.Point(60, 58);
            this.EMPLOYEES_LABEL.Name = "EMPLOYEES_LABEL";
            this.EMPLOYEES_LABEL.Size = new System.Drawing.Size(78, 17);
            this.EMPLOYEES_LABEL.TabIndex = 1;
            this.EMPLOYEES_LABEL.Text = "EMPLOYEES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(91, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.HALFDAY_LABEL);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(277, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 9;
            // 
            // HALFDAY_LABEL
            // 
            this.HALFDAY_LABEL.AutoSize = true;
            this.HALFDAY_LABEL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HALFDAY_LABEL.Location = new System.Drawing.Point(71, 60);
            this.HALFDAY_LABEL.Name = "HALFDAY_LABEL";
            this.HALFDAY_LABEL.Size = new System.Drawing.Size(68, 17);
            this.HALFDAY_LABEL.TabIndex = 1;
            this.HALFDAY_LABEL.Text = "HALF DAY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "2";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.LATE_LABEL);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(58, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 7;
            // 
            // LATE_LABEL
            // 
            this.LATE_LABEL.AutoSize = true;
            this.LATE_LABEL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LATE_LABEL.Location = new System.Drawing.Point(81, 60);
            this.LATE_LABEL.Name = "LATE_LABEL";
            this.LATE_LABEL.Size = new System.Drawing.Size(35, 17);
            this.LATE_LABEL.TabIndex = 1;
            this.LATE_LABEL.Text = "LATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ABSENT_LABEL);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(277, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 6;
            // 
            // ABSENT_LABEL
            // 
            this.ABSENT_LABEL.AutoSize = true;
            this.ABSENT_LABEL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABSENT_LABEL.Location = new System.Drawing.Point(71, 60);
            this.ABSENT_LABEL.Name = "ABSENT_LABEL";
            this.ABSENT_LABEL.Size = new System.Drawing.Size(52, 17);
            this.ABSENT_LABEL.TabIndex = 1;
            this.ABSENT_LABEL.Text = "ABSENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.PRESENT_LABEL);
            this.panel2.Location = new System.Drawing.Point(58, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRESENT";
            // 
            // PRESENT_LABEL
            // 
            this.PRESENT_LABEL.AutoSize = true;
            this.PRESENT_LABEL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRESENT_LABEL.Location = new System.Drawing.Point(91, 33);
            this.PRESENT_LABEL.Name = "PRESENT_LABEL";
            this.PRESENT_LABEL.Size = new System.Drawing.Size(15, 17);
            this.PRESENT_LABEL.TabIndex = 0;
            this.PRESENT_LABEL.Text = "2";
            // 
            // ATTENDANCE_PAGE
            // 
            this.ATTENDANCE_PAGE.Location = new System.Drawing.Point(4, 25);
            this.ATTENDANCE_PAGE.Name = "ATTENDANCE_PAGE";
            this.ATTENDANCE_PAGE.Padding = new System.Windows.Forms.Padding(3);
            this.ATTENDANCE_PAGE.Size = new System.Drawing.Size(534, 525);
            this.ATTENDANCE_PAGE.TabIndex = 2;
            this.ATTENDANCE_PAGE.Text = "ATTENDANCE";
            this.ATTENDANCE_PAGE.UseVisualStyleBackColor = true;
            // 
            // DATA_PAGE
            // 
            this.DATA_PAGE.Location = new System.Drawing.Point(4, 25);
            this.DATA_PAGE.Name = "DATA_PAGE";
            this.DATA_PAGE.Padding = new System.Windows.Forms.Padding(3);
            this.DATA_PAGE.Size = new System.Drawing.Size(534, 525);
            this.DATA_PAGE.TabIndex = 3;
            this.DATA_PAGE.Text = "DATA";
            this.DATA_PAGE.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.DASHBOARD_PAGE.ResumeLayout(false);
            this.EMPLOYEES_PAGE.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DASHBOARD_PAGE;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label EMPLOYEES_LABEL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label HALFDAY_LABEL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LATE_LABEL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ABSENT_LABEL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PRESENT_LABEL;
        private System.Windows.Forms.TabPage EMPLOYEES_PAGE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage ATTENDANCE_PAGE;
        private System.Windows.Forms.TabPage DATA_PAGE;
    }
}