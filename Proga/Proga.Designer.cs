namespace Proga
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cl = new System.Windows.Forms.Button();
            this.btn_STOP = new System.Windows.Forms.Button();
            this.cmb_RY = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_db = new System.Windows.Forms.ComboBox();
            this.cmb_br = new System.Windows.Forms.ComboBox();
            this.cmb_com = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_vsos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Zm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Zb = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Ym = new System.Windows.Forms.Button();
            this.btn_Yb = new System.Windows.Forms.Button();
            this.btn_Xm = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_Xb = new System.Windows.Forms.Button();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.txt_Z = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cl);
            this.groupBox1.Controls.Add(this.btn_STOP);
            this.groupBox1.Controls.Add(this.cmb_RY);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmb_db);
            this.groupBox1.Controls.Add(this.cmb_br);
            this.groupBox1.Controls.Add(this.cmb_com);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Последовательный Порт";
            // 
            // btn_cl
            // 
            this.btn_cl.Location = new System.Drawing.Point(140, 149);
            this.btn_cl.Name = "btn_cl";
            this.btn_cl.Size = new System.Drawing.Size(89, 36);
            this.btn_cl.TabIndex = 14;
            this.btn_cl.Text = "Закрыть порт ";
            this.btn_cl.UseVisualStyleBackColor = true;
            this.btn_cl.Click += new System.EventHandler(this.btn_cl_Click);
            // 
            // btn_STOP
            // 
            this.btn_STOP.BackColor = System.Drawing.Color.LightCoral;
            this.btn_STOP.Location = new System.Drawing.Point(140, 199);
            this.btn_STOP.Name = "btn_STOP";
            this.btn_STOP.Size = new System.Drawing.Size(105, 68);
            this.btn_STOP.TabIndex = 13;
            this.btn_STOP.Text = "Экстренное торможение";
            this.btn_STOP.UseVisualStyleBackColor = false;
            this.btn_STOP.Click += new System.EventHandler(this.btn_STOP_Click);
            // 
            // cmb_RY
            // 
            this.cmb_RY.FormattingEnabled = true;
            this.cmb_RY.Items.AddRange(new object[] {
            "5 ",
            "10 ",
            "20 ",
            "50",
            "100"});
            this.cmb_RY.Location = new System.Drawing.Point(124, 119);
            this.cmb_RY.Name = "cmb_RY";
            this.cmb_RY.Size = new System.Drawing.Size(121, 21);
            this.cmb_RY.TabIndex = 12;
            this.cmb_RY.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Шаг для Р/У";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Открыть порт ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_db
            // 
            this.cmb_db.FormattingEnabled = true;
            this.cmb_db.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cmb_db.Location = new System.Drawing.Point(124, 89);
            this.cmb_db.Name = "cmb_db";
            this.cmb_db.Size = new System.Drawing.Size(121, 21);
            this.cmb_db.TabIndex = 7;
            this.cmb_db.SelectedIndexChanged += new System.EventHandler(this.cmb_db_SelectedIndexChanged);
            // 
            // cmb_br
            // 
            this.cmb_br.FormattingEnabled = true;
            this.cmb_br.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cmb_br.Location = new System.Drawing.Point(124, 58);
            this.cmb_br.Name = "cmb_br";
            this.cmb_br.Size = new System.Drawing.Size(121, 21);
            this.cmb_br.TabIndex = 6;
            this.cmb_br.SelectedIndexChanged += new System.EventHandler(this.cmb_br_SelectedIndexChanged);
            // 
            // cmb_com
            // 
            this.cmb_com.FormattingEnabled = true;
            this.cmb_com.Location = new System.Drawing.Point(124, 26);
            this.cmb_com.Name = "cmb_com";
            this.cmb_com.Size = new System.Drawing.Size(121, 21);
            this.cmb_com.TabIndex = 5;
            this.cmb_com.SelectedIndexChanged += new System.EventHandler(this.cmb_com_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "BOUD RATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATA BITS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM-port";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_enter);
            this.groupBox2.Controls.Add(this.txt_Z);
            this.groupBox2.Controls.Add(this.txt_Y);
            this.groupBox2.Controls.Add(this.txt_X);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btn_vsos);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Y);
            this.groupBox2.Controls.Add(this.Z);
            this.groupBox2.Controls.Add(this.X);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Zm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Zb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_Ym);
            this.groupBox2.Controls.Add(this.btn_Yb);
            this.groupBox2.Controls.Add(this.btn_Xm);
            this.groupBox2.Controls.Add(this.btn_home);
            this.groupBox2.Controls.Add(this.btn_Xb);
            this.groupBox2.Location = new System.Drawing.Point(378, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление роботом";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(118, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 26;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(180, 89);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "Выпустить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(99, 116);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Сбросить ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_vsos
            // 
            this.btn_vsos.Location = new System.Drawing.Point(18, 89);
            this.btn_vsos.Name = "btn_vsos";
            this.btn_vsos.Size = new System.Drawing.Size(75, 23);
            this.btn_vsos.TabIndex = 20;
            this.btn_vsos.Text = "Всосать";
            this.btn_vsos.UseVisualStyleBackColor = true;
            this.btn_vsos.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Задать координаты вручную (x, y, z):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(41, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Присоска:";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(119, 216);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(0, 17);
            this.Y.TabIndex = 16;
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z.Location = new System.Drawing.Point(119, 233);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(0, 17);
            this.Z.TabIndex = 15;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(119, 199);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(0, 17);
            this.X.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Координата Y:";
            // 
            // btn_Zm
            // 
            this.btn_Zm.Location = new System.Drawing.Point(180, 58);
            this.btn_Zm.Name = "btn_Zm";
            this.btn_Zm.Size = new System.Drawing.Size(75, 23);
            this.btn_Zm.TabIndex = 6;
            this.btn_Zm.Text = "-Z";
            this.btn_Zm.UseVisualStyleBackColor = true;
            this.btn_Zm.Click += new System.EventHandler(this.btn_Zm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Координата Z:";
            // 
            // btn_Zb
            // 
            this.btn_Zb.Location = new System.Drawing.Point(180, 27);
            this.btn_Zb.Name = "btn_Zb";
            this.btn_Zb.Size = new System.Drawing.Size(75, 23);
            this.btn_Zb.TabIndex = 5;
            this.btn_Zb.Text = "+Z";
            this.btn_Zb.UseVisualStyleBackColor = true;
            this.btn_Zb.Click += new System.EventHandler(this.btn_Zb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Координата X:";
            // 
            // btn_Ym
            // 
            this.btn_Ym.Location = new System.Drawing.Point(99, 89);
            this.btn_Ym.Name = "btn_Ym";
            this.btn_Ym.Size = new System.Drawing.Size(75, 23);
            this.btn_Ym.TabIndex = 4;
            this.btn_Ym.Text = "-Y";
            this.btn_Ym.UseVisualStyleBackColor = true;
            this.btn_Ym.Click += new System.EventHandler(this.btn_Ym_Click);
            // 
            // btn_Yb
            // 
            this.btn_Yb.Location = new System.Drawing.Point(99, 27);
            this.btn_Yb.Name = "btn_Yb";
            this.btn_Yb.Size = new System.Drawing.Size(75, 23);
            this.btn_Yb.TabIndex = 3;
            this.btn_Yb.Text = "+Y";
            this.btn_Yb.UseVisualStyleBackColor = true;
            this.btn_Yb.Click += new System.EventHandler(this.btn_Yb_Click);
            // 
            // btn_Xm
            // 
            this.btn_Xm.Location = new System.Drawing.Point(18, 58);
            this.btn_Xm.Name = "btn_Xm";
            this.btn_Xm.Size = new System.Drawing.Size(75, 23);
            this.btn_Xm.TabIndex = 2;
            this.btn_Xm.Text = "-X";
            this.btn_Xm.UseVisualStyleBackColor = true;
            this.btn_Xm.Click += new System.EventHandler(this.btn_Xm_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(99, 58);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_Xb
            // 
            this.btn_Xb.Location = new System.Drawing.Point(18, 27);
            this.btn_Xb.Name = "btn_Xb";
            this.btn_Xb.Size = new System.Drawing.Size(75, 23);
            this.btn_Xb.TabIndex = 0;
            this.btn_Xb.Text = "+X";
            this.btn_Xb.UseVisualStyleBackColor = true;
            this.btn_Xb.Click += new System.EventHandler(this.btn_Xb_Click);
            // 
            // txt_X
            // 
            this.txt_X.Location = new System.Drawing.Point(18, 162);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(62, 20);
            this.txt_X.TabIndex = 27;
            this.txt_X.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(86, 162);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(62, 20);
            this.txt_Y.TabIndex = 28;
            // 
            // txt_Z
            // 
            this.txt_Z.Location = new System.Drawing.Point(154, 162);
            this.txt_Z.Name = "txt_Z";
            this.txt_Z.Size = new System.Drawing.Size(62, 20);
            this.txt_Z.TabIndex = 29;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.Silver;
            this.btn_enter.Location = new System.Drawing.Point(222, 162);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(33, 23);
            this.btn_enter.TabIndex = 30;
            this.btn_enter.Text = ">";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 316);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_db;
        private System.Windows.Forms.ComboBox cmb_br;
        private System.Windows.Forms.ComboBox cmb_com;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_Xb;
        private System.Windows.Forms.Button btn_Zm;
        private System.Windows.Forms.Button btn_Zb;
        private System.Windows.Forms.Button btn_Ym;
        private System.Windows.Forms.Button btn_Yb;
        private System.Windows.Forms.Button btn_Xm;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cl;
        private System.Windows.Forms.Button btn_STOP;
        private System.Windows.Forms.ComboBox cmb_RY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_vsos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox txt_Z;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.TextBox txt_X;
    }
}

