namespace frmMain
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSound = new System.Windows.Forms.Button();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.lbSoBuocDi = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSoDia = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbC = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.CotA = new System.Windows.Forms.Panel();
            this.CotB = new System.Windows.Forms.Panel();
            this.CotC = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.btnSound);
            this.panel1.Controls.Add(this.lbThoiGian);
            this.panel1.Controls.Add(this.btnChoiLai);
            this.panel1.Controls.Add(this.lbSoBuocDi);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSoDia);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 448);
            this.panel1.TabIndex = 0;
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSound.ForeColor = System.Drawing.Color.Magenta;
            this.btnSound.Location = new System.Drawing.Point(52, 413);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(79, 32);
            this.btnSound.TabIndex = 6;
            this.btnSound.Text = "Sound Off";
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.ForeColor = System.Drawing.Color.Aqua;
            this.lbThoiGian.Location = new System.Drawing.Point(49, 266);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(89, 60);
            this.lbThoiGian.TabIndex = 5;
            this.lbThoiGian.Text = "00";
            this.lbThoiGian.Visible = false;
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.BackColor = System.Drawing.Color.Aqua;
            this.btnChoiLai.Enabled = false;
            this.btnChoiLai.ForeColor = System.Drawing.Color.Blue;
            this.btnChoiLai.Location = new System.Drawing.Point(35, 374);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(123, 31);
            this.btnChoiLai.TabIndex = 4;
            this.btnChoiLai.Text = "Chơi Lại";
            this.btnChoiLai.UseVisualStyleBackColor = false;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // lbSoBuocDi
            // 
            this.lbSoBuocDi.AutoSize = true;
            this.lbSoBuocDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoBuocDi.ForeColor = System.Drawing.Color.Yellow;
            this.lbSoBuocDi.Location = new System.Drawing.Point(59, 141);
            this.lbSoBuocDi.Name = "lbSoBuocDi";
            this.lbSoBuocDi.Size = new System.Drawing.Size(69, 73);
            this.lbSoBuocDi.TabIndex = 3;
            this.lbSoBuocDi.Text = "0";
            this.lbSoBuocDi.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(35, 67);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 33);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số đĩa:";
            // 
            // cbSoDia
            // 
            this.cbSoDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSoDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoDia.ForeColor = System.Drawing.Color.Red;
            this.cbSoDia.FormattingEnabled = true;
            this.cbSoDia.Items.AddRange(new object[] {
            "1 Đĩa",
            "2 Đĩa",
            "3  Đĩa",
            "4 Đĩa",
            "5 Đĩa",
            "6 Đĩa",
            "7 Đĩa",
            "8 Đĩa",
            "9 Đĩa",
            "10 Đĩa",
            ""});
            this.cbSoDia.Location = new System.Drawing.Point(88, 15);
            this.cbSoDia.Name = "cbSoDia";
            this.cbSoDia.Size = new System.Drawing.Size(88, 26);
            this.cbSoDia.TabIndex = 0;
            this.cbSoDia.SelectedIndexChanged += new System.EventHandler(this.cbSoDia_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lbC);
            this.panel2.Controls.Add(this.lbB);
            this.panel2.Controls.Add(this.lbA);
            this.panel2.Location = new System.Drawing.Point(204, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 72);
            this.panel2.TabIndex = 1;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.ForeColor = System.Drawing.Color.Lime;
            this.lbC.Location = new System.Drawing.Point(655, -1);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(78, 73);
            this.lbC.TabIndex = 2;
            this.lbC.Text = "C";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.ForeColor = System.Drawing.Color.Lime;
            this.lbB.Location = new System.Drawing.Point(369, -2);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(75, 73);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "B";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.ForeColor = System.Drawing.Color.Lime;
            this.lbA.Location = new System.Drawing.Point(106, 0);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(75, 73);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "A";
            // 
            // CotA
            // 
            this.CotA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CotA.Location = new System.Drawing.Point(331, 30);
            this.CotA.Name = "CotA";
            this.CotA.Size = new System.Drawing.Size(22, 350);
            this.CotA.TabIndex = 0;
            // 
            // CotB
            // 
            this.CotB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CotB.Location = new System.Drawing.Point(593, 30);
            this.CotB.Name = "CotB";
            this.CotB.Size = new System.Drawing.Size(22, 350);
            this.CotB.TabIndex = 1;
            // 
            // CotC
            // 
            this.CotC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CotC.Location = new System.Drawing.Point(878, 30);
            this.CotC.Name = "CotC";
            this.CotC.Size = new System.Drawing.Size(22, 350);
            this.CotC.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CotA);
            this.Controls.Add(this.CotB);
            this.Controls.Add(this.CotC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Tower of Hanoi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Label lbSoBuocDi;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSoDia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Panel CotA;
        private System.Windows.Forms.Panel CotB;
        private System.Windows.Forms.Panel CotC;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnSound;
    }
}

