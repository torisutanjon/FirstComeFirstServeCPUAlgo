namespace FCFS
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.p1AT = new System.Windows.Forms.TextBox();
            this.p2AT = new System.Windows.Forms.TextBox();
            this.p3AT = new System.Windows.Forms.TextBox();
            this.p4AT = new System.Windows.Forms.TextBox();
            this.p4ET = new System.Windows.Forms.TextBox();
            this.p3ET = new System.Windows.Forms.TextBox();
            this.p2ET = new System.Windows.Forms.TextBox();
            this.p1ET = new System.Windows.Forms.TextBox();
            this.p4WT = new System.Windows.Forms.TextBox();
            this.p3WT = new System.Windows.Forms.TextBox();
            this.p2WT = new System.Windows.Forms.TextBox();
            this.p1WT = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.awtTB = new System.Windows.Forms.TextBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrival Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Execution Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Waiting Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Process 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Process 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Process 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Process 4";
            // 
            // p1AT
            // 
            this.p1AT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p1AT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1AT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1AT.Location = new System.Drawing.Point(218, 84);
            this.p1AT.Name = "p1AT";
            this.p1AT.Size = new System.Drawing.Size(118, 23);
            this.p1AT.TabIndex = 8;
            // 
            // p2AT
            // 
            this.p2AT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p2AT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2AT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2AT.Location = new System.Drawing.Point(218, 176);
            this.p2AT.Name = "p2AT";
            this.p2AT.Size = new System.Drawing.Size(118, 23);
            this.p2AT.TabIndex = 9;
            // 
            // p3AT
            // 
            this.p3AT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p3AT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p3AT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3AT.Location = new System.Drawing.Point(218, 268);
            this.p3AT.Name = "p3AT";
            this.p3AT.Size = new System.Drawing.Size(118, 23);
            this.p3AT.TabIndex = 10;
            // 
            // p4AT
            // 
            this.p4AT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p4AT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p4AT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4AT.Location = new System.Drawing.Point(218, 359);
            this.p4AT.Name = "p4AT";
            this.p4AT.Size = new System.Drawing.Size(118, 23);
            this.p4AT.TabIndex = 11;
            // 
            // p4ET
            // 
            this.p4ET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p4ET.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p4ET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4ET.Location = new System.Drawing.Point(434, 359);
            this.p4ET.Name = "p4ET";
            this.p4ET.Size = new System.Drawing.Size(118, 23);
            this.p4ET.TabIndex = 15;
            // 
            // p3ET
            // 
            this.p3ET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p3ET.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p3ET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3ET.Location = new System.Drawing.Point(434, 268);
            this.p3ET.Name = "p3ET";
            this.p3ET.Size = new System.Drawing.Size(118, 23);
            this.p3ET.TabIndex = 14;
            // 
            // p2ET
            // 
            this.p2ET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p2ET.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2ET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ET.Location = new System.Drawing.Point(434, 176);
            this.p2ET.Name = "p2ET";
            this.p2ET.Size = new System.Drawing.Size(118, 23);
            this.p2ET.TabIndex = 13;
            // 
            // p1ET
            // 
            this.p1ET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p1ET.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1ET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ET.Location = new System.Drawing.Point(434, 84);
            this.p1ET.Name = "p1ET";
            this.p1ET.Size = new System.Drawing.Size(118, 23);
            this.p1ET.TabIndex = 12;
            // 
            // p4WT
            // 
            this.p4WT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p4WT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p4WT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4WT.Location = new System.Drawing.Point(675, 359);
            this.p4WT.Name = "p4WT";
            this.p4WT.Size = new System.Drawing.Size(118, 23);
            this.p4WT.TabIndex = 19;
            // 
            // p3WT
            // 
            this.p3WT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p3WT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p3WT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3WT.Location = new System.Drawing.Point(675, 268);
            this.p3WT.Name = "p3WT";
            this.p3WT.Size = new System.Drawing.Size(118, 23);
            this.p3WT.TabIndex = 18;
            // 
            // p2WT
            // 
            this.p2WT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p2WT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2WT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2WT.Location = new System.Drawing.Point(675, 176);
            this.p2WT.Name = "p2WT";
            this.p2WT.Size = new System.Drawing.Size(118, 23);
            this.p2WT.TabIndex = 17;
            // 
            // p1WT
            // 
            this.p1WT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.p1WT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1WT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1WT.Location = new System.Drawing.Point(675, 84);
            this.p1WT.Name = "p1WT";
            this.p1WT.Size = new System.Drawing.Size(118, 23);
            this.p1WT.TabIndex = 16;
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(356, 429);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(187, 56);
            this.calculateBtn.TabIndex = 20;
            this.calculateBtn.Text = "Calculate!";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(613, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 396);
            this.panel1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(21, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Average Waiting TIme";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.awtTB);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(867, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 393);
            this.panel2.TabIndex = 23;
            // 
            // awtTB
            // 
            this.awtTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.awtTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.awtTB.Location = new System.Drawing.Point(64, 146);
            this.awtTB.Name = "awtTB";
            this.awtTB.Size = new System.Drawing.Size(140, 23);
            this.awtTB.TabIndex = 23;
            this.awtTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clrBtn.FlatAppearance.BorderSize = 0;
            this.clrBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.Location = new System.Drawing.Point(31, 429);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(117, 62);
            this.clrBtn.TabIndex = 24;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(31, 511);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(117, 61);
            this.closeBtn.TabIndex = 25;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(218, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "Gantt Chart :";
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(222, 522);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(897, 131);
            this.datagrid.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1153, 665);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.p4WT);
            this.Controls.Add(this.p3WT);
            this.Controls.Add(this.p2WT);
            this.Controls.Add(this.p1WT);
            this.Controls.Add(this.p4ET);
            this.Controls.Add(this.p3ET);
            this.Controls.Add(this.p2ET);
            this.Controls.Add(this.p1ET);
            this.Controls.Add(this.p4AT);
            this.Controls.Add(this.p3AT);
            this.Controls.Add(this.p2AT);
            this.Controls.Add(this.p1AT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Come First Serve Algorithm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox p1AT;
        private System.Windows.Forms.TextBox p2AT;
        private System.Windows.Forms.TextBox p3AT;
        private System.Windows.Forms.TextBox p4AT;
        private System.Windows.Forms.TextBox p4ET;
        private System.Windows.Forms.TextBox p3ET;
        private System.Windows.Forms.TextBox p2ET;
        private System.Windows.Forms.TextBox p1ET;
        private System.Windows.Forms.TextBox p4WT;
        private System.Windows.Forms.TextBox p3WT;
        private System.Windows.Forms.TextBox p2WT;
        private System.Windows.Forms.TextBox p1WT;
        private System.Windows.Forms.Button calculateBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox awtTB;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView datagrid;
    }
}

