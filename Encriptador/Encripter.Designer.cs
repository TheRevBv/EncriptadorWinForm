namespace Encriptador
{
    partial class Encripter
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbCtrl = new System.Windows.Forms.TabControl();
            this.pageAscii = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputClave1 = new System.Windows.Forms.TextBox();
            this.inputMsj1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pageSimetrico = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.inputMsj2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pageAsimetrico = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputMsj3 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pageHash = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.inputMsj4 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tbCtrl.SuspendLayout();
            this.pageAscii.SuspendLayout();
            this.pageSimetrico.SuspendLayout();
            this.pageAsimetrico.SuspendLayout();
            this.pageHash.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbCtrl);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(572, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tbCtrl
            // 
            this.tbCtrl.Controls.Add(this.pageAscii);
            this.tbCtrl.Controls.Add(this.pageSimetrico);
            this.tbCtrl.Controls.Add(this.pageAsimetrico);
            this.tbCtrl.Controls.Add(this.pageHash);
            this.tbCtrl.Location = new System.Drawing.Point(3, 3);
            this.tbCtrl.Name = "tbCtrl";
            this.tbCtrl.SelectedIndex = 0;
            this.tbCtrl.Size = new System.Drawing.Size(569, 314);
            this.tbCtrl.TabIndex = 1;
            // 
            // pageAscii
            // 
            this.pageAscii.Controls.Add(this.label4);
            this.pageAscii.Controls.Add(this.label2);
            this.pageAscii.Controls.Add(this.inputClave1);
            this.pageAscii.Controls.Add(this.inputMsj1);
            this.pageAscii.Controls.Add(this.label3);
            this.pageAscii.Location = new System.Drawing.Point(4, 24);
            this.pageAscii.Name = "pageAscii";
            this.pageAscii.Padding = new System.Windows.Forms.Padding(3);
            this.pageAscii.Size = new System.Drawing.Size(561, 286);
            this.pageAscii.TabIndex = 0;
            this.pageAscii.Text = "Tipo ASCII";
            this.pageAscii.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese la clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el mensaje";
            // 
            // inputClave1
            // 
            this.inputClave1.Location = new System.Drawing.Point(134, 191);
            this.inputClave1.Name = "inputClave1";
            this.inputClave1.Size = new System.Drawing.Size(297, 23);
            this.inputClave1.TabIndex = 4;
            // 
            // inputMsj1
            // 
            this.inputMsj1.Location = new System.Drawing.Point(134, 89);
            this.inputMsj1.Name = "inputMsj1";
            this.inputMsj1.Size = new System.Drawing.Size(297, 70);
            this.inputMsj1.TabIndex = 3;
            this.inputMsj1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(149, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encriptador Tipo Ascii";
            // 
            // pageSimetrico
            // 
            this.pageSimetrico.Controls.Add(this.label6);
            this.pageSimetrico.Controls.Add(this.inputMsj2);
            this.pageSimetrico.Controls.Add(this.label1);
            this.pageSimetrico.Location = new System.Drawing.Point(4, 24);
            this.pageSimetrico.Name = "pageSimetrico";
            this.pageSimetrico.Padding = new System.Windows.Forms.Padding(3);
            this.pageSimetrico.Size = new System.Drawing.Size(561, 286);
            this.pageSimetrico.TabIndex = 1;
            this.pageSimetrico.Text = "Simetrico";
            this.pageSimetrico.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese el mensaje";
            // 
            // inputMsj2
            // 
            this.inputMsj2.Location = new System.Drawing.Point(132, 90);
            this.inputMsj2.Name = "inputMsj2";
            this.inputMsj2.Size = new System.Drawing.Size(297, 70);
            this.inputMsj2.TabIndex = 7;
            this.inputMsj2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encriptador Simetrico";
            // 
            // pageAsimetrico
            // 
            this.pageAsimetrico.Controls.Add(this.label5);
            this.pageAsimetrico.Controls.Add(this.textBox1);
            this.pageAsimetrico.Controls.Add(this.label8);
            this.pageAsimetrico.Controls.Add(this.inputMsj3);
            this.pageAsimetrico.Controls.Add(this.label9);
            this.pageAsimetrico.Location = new System.Drawing.Point(4, 24);
            this.pageAsimetrico.Name = "pageAsimetrico";
            this.pageAsimetrico.Padding = new System.Windows.Forms.Padding(3);
            this.pageAsimetrico.Size = new System.Drawing.Size(561, 286);
            this.pageAsimetrico.TabIndex = 2;
            this.pageAsimetrico.Text = "Asimetrico";
            this.pageAsimetrico.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ingrese el nombre del archivo de llaves";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 23);
            this.textBox1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ingrese el mensaje";
            // 
            // inputMsj3
            // 
            this.inputMsj3.Location = new System.Drawing.Point(132, 112);
            this.inputMsj3.Name = "inputMsj3";
            this.inputMsj3.Size = new System.Drawing.Size(297, 70);
            this.inputMsj3.TabIndex = 12;
            this.inputMsj3.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(132, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "Encriptador Asimetrico";
            // 
            // pageHash
            // 
            this.pageHash.Controls.Add(this.label10);
            this.pageHash.Controls.Add(this.label11);
            this.pageHash.Controls.Add(this.textBox3);
            this.pageHash.Controls.Add(this.inputMsj4);
            this.pageHash.Controls.Add(this.label12);
            this.pageHash.Location = new System.Drawing.Point(4, 24);
            this.pageHash.Name = "pageHash";
            this.pageHash.Padding = new System.Windows.Forms.Padding(3);
            this.pageHash.Size = new System.Drawing.Size(561, 286);
            this.pageHash.TabIndex = 3;
            this.pageHash.Text = "HASH";
            this.pageHash.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ingrese la clave";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ingrese el mensaje";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(297, 23);
            this.textBox3.TabIndex = 18;
            // 
            // inputMsj4
            // 
            this.inputMsj4.Location = new System.Drawing.Point(132, 112);
            this.inputMsj4.Name = "inputMsj4";
            this.inputMsj4.Size = new System.Drawing.Size(297, 70);
            this.inputMsj4.TabIndex = 17;
            this.inputMsj4.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(178, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Encriptador Hash";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.btnDesencriptar);
            this.panel1.Controls.Add(this.btnEncriptar);
            this.panel1.Location = new System.Drawing.Point(3, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 115);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.lblRespuesta);
            this.flowLayoutPanel2.Controls.Add(this.txtResponse);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(557, 74);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(10, 10);
            this.lblRespuesta.Margin = new System.Windows.Forms.Padding(10);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Padding = new System.Windows.Forms.Padding(15);
            this.lblRespuesta.Size = new System.Drawing.Size(93, 45);
            this.lblRespuesta.TabIndex = 0;
            this.lblRespuesta.Text = "Respuesta:";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(133, 20);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(20);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(404, 23);
            this.txtResponse.TabIndex = 1;
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Location = new System.Drawing.Point(352, 80);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(202, 32);
            this.btnDesencriptar.TabIndex = 4;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(4, 80);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(202, 32);
            this.btnEncriptar.TabIndex = 3;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // Encripter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Encripter";
            this.Text = "Encriptador";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tbCtrl.ResumeLayout(false);
            this.pageAscii.ResumeLayout(false);
            this.pageAscii.PerformLayout();
            this.pageSimetrico.ResumeLayout(false);
            this.pageSimetrico.PerformLayout();
            this.pageAsimetrico.ResumeLayout(false);
            this.pageAsimetrico.PerformLayout();
            this.pageHash.ResumeLayout(false);
            this.pageHash.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TabControl tbCtrl;
        private TabPage pageAscii;
        private TabPage pageSimetrico;
        private TabPage pageAsimetrico;
        private TabPage pageHash;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Button btnDesencriptar;
        private Button btnEncriptar;
        private Label label2;
        private TextBox inputClave1;
        private RichTextBox inputMsj1;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblRespuesta;
        private Label label6;
        private RichTextBox inputMsj2;
        private Label label8;
        private RichTextBox inputMsj3;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox3;
        private RichTextBox inputMsj4;
        private Label label12;
        private TextBox txtResponse;
        private Label label5;
        private TextBox textBox1;
    }
}