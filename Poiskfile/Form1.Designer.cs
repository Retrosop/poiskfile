namespace Poiskfile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.loadpathdir = new System.Windows.Forms.Button();
            this.loadlistgms = new System.Windows.Forms.Button();
            this.outpathdir = new System.Windows.Forms.Button();
            this.textBoxload = new System.Windows.Forms.TextBox();
            this.textBoxout = new System.Windows.Forms.TextBox();
            this.richTextBoxGMS = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxLogin = new System.Windows.Forms.TextBox();
            this.txtbxPort = new System.Windows.Forms.TextBox();
            this.txtbxServer = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxDB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxSQL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // loadpathdir
            // 
            this.loadpathdir.Location = new System.Drawing.Point(787, 40);
            this.loadpathdir.Name = "loadpathdir";
            this.loadpathdir.Size = new System.Drawing.Size(156, 39);
            this.loadpathdir.TabIndex = 0;
            this.loadpathdir.Text = "Загрузить из...";
            this.loadpathdir.UseVisualStyleBackColor = true;
            this.loadpathdir.Click += new System.EventHandler(this.loadpathdir_Click);
            // 
            // loadlistgms
            // 
            this.loadlistgms.Location = new System.Drawing.Point(787, 142);
            this.loadlistgms.Name = "loadlistgms";
            this.loadlistgms.Size = new System.Drawing.Size(156, 37);
            this.loadlistgms.TabIndex = 1;
            this.loadlistgms.Text = "Загрузить гмс";
            this.loadlistgms.UseVisualStyleBackColor = true;
            this.loadlistgms.Click += new System.EventHandler(this.loadlistgms_Click);
            // 
            // outpathdir
            // 
            this.outpathdir.Location = new System.Drawing.Point(787, 93);
            this.outpathdir.Name = "outpathdir";
            this.outpathdir.Size = new System.Drawing.Size(156, 34);
            this.outpathdir.TabIndex = 2;
            this.outpathdir.Text = "Выгрузить в ...";
            this.outpathdir.UseVisualStyleBackColor = true;
            this.outpathdir.Click += new System.EventHandler(this.outpathdir_Click);
            // 
            // textBoxload
            // 
            this.textBoxload.Location = new System.Drawing.Point(170, 44);
            this.textBoxload.Name = "textBoxload";
            this.textBoxload.Size = new System.Drawing.Size(611, 23);
            this.textBoxload.TabIndex = 3;
            // 
            // textBoxout
            // 
            this.textBoxout.Location = new System.Drawing.Point(170, 97);
            this.textBoxout.Name = "textBoxout";
            this.textBoxout.Size = new System.Drawing.Size(611, 23);
            this.textBoxout.TabIndex = 4;
            // 
            // richTextBoxGMS
            // 
            this.richTextBoxGMS.Location = new System.Drawing.Point(170, 146);
            this.richTextBoxGMS.Name = "richTextBoxGMS";
            this.richTextBoxGMS.Size = new System.Drawing.Size(611, 103);
            this.richTextBoxGMS.TabIndex = 5;
            this.richTextBoxGMS.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Путь загрузки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список гмс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Путь выгрузки";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(787, 259);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(156, 34);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Сформировать csv";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 263);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(611, 142);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Открыть MySQL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Сервер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Порт";
            // 
            // txtbxLogin
            // 
            this.txtbxLogin.Location = new System.Drawing.Point(214, 420);
            this.txtbxLogin.Name = "txtbxLogin";
            this.txtbxLogin.Size = new System.Drawing.Size(61, 23);
            this.txtbxLogin.TabIndex = 16;
            this.txtbxLogin.Text = "root";
            // 
            // txtbxPort
            // 
            this.txtbxPort.Location = new System.Drawing.Point(599, 422);
            this.txtbxPort.Name = "txtbxPort";
            this.txtbxPort.Size = new System.Drawing.Size(35, 23);
            this.txtbxPort.TabIndex = 17;
            this.txtbxPort.Text = "3306";
            // 
            // txtbxServer
            // 
            this.txtbxServer.Location = new System.Drawing.Point(480, 422);
            this.txtbxServer.Name = "txtbxServer";
            this.txtbxServer.Size = new System.Drawing.Size(62, 23);
            this.txtbxServer.TabIndex = 18;
            this.txtbxServer.Text = "localhost";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(339, 420);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(82, 23);
            this.txtbxPassword.TabIndex = 19;
            this.txtbxPassword.Text = "root";
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "БД";
            // 
            // txtbxDB
            // 
            this.txtbxDB.Location = new System.Drawing.Point(678, 422);
            this.txtbxDB.Name = "txtbxDB";
            this.txtbxDB.Size = new System.Drawing.Size(103, 23);
            this.txtbxDB.TabIndex = 21;
            this.txtbxDB.Text = "meteonasa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Содержимое csv";
            // 
            // txtbxSQL
            // 
            this.txtbxSQL.Location = new System.Drawing.Point(170, 462);
            this.txtbxSQL.Multiline = true;
            this.txtbxSQL.Name = "txtbxSQL";
            this.txtbxSQL.Size = new System.Drawing.Size(611, 142);
            this.txtbxSQL.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "SQL- запрос";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(787, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "Закрыть MySQL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(787, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 34);
            this.button3.TabIndex = 26;
            this.button3.Text = "Экспорт MySQL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 616);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbxSQL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbxDB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxServer);
            this.Controls.Add(this.txtbxPort);
            this.Controls.Add(this.txtbxLogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxGMS);
            this.Controls.Add(this.textBoxout);
            this.Controls.Add(this.textBoxload);
            this.Controls.Add(this.outpathdir);
            this.Controls.Add(this.loadlistgms);
            this.Controls.Add(this.loadpathdir);
            this.Name = "Form1";
            this.Text = "Приложение импорта данных гидрометеостаниций NASA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button loadpathdir;
        private Button loadlistgms;
        private Button outpathdir;
        private TextBox textBoxload;
        private TextBox textBoxout;
        private RichTextBox richTextBoxGMS;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonStart;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtbxLogin;
        private TextBox txtbxPort;
        private TextBox txtbxServer;
        private TextBox txtbxPassword;
        private Label label8;
        private TextBox txtbxDB;
        private Label label9;
        private TextBox txtbxSQL;
        private Label label10;
        private Button button2;
        private Button button3;
    }
}