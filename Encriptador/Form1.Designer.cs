namespace Encriptador
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbCtrl = new System.Windows.Forms.TabControl();
            this.pageAscii = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pageAsimetrico = new System.Windows.Forms.TabPage();
            this.pageHash = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tbCtrl.SuspendLayout();
            this.pageAscii.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tbCtrl.Controls.Add(this.tabPage2);
            this.tbCtrl.Controls.Add(this.pageAsimetrico);
            this.tbCtrl.Controls.Add(this.pageHash);
            this.tbCtrl.Location = new System.Drawing.Point(3, 3);
            this.tbCtrl.Name = "tbCtrl";
            this.tbCtrl.SelectedIndex = 0;
            this.tbCtrl.Size = new System.Drawing.Size(569, 391);
            this.tbCtrl.TabIndex = 1;
            // 
            // pageAscii
            // 
            this.pageAscii.Controls.Add(this.label3);
            this.pageAscii.Location = new System.Drawing.Point(4, 24);
            this.pageAscii.Name = "pageAscii";
            this.pageAscii.Padding = new System.Windows.Forms.Padding(3);
            this.pageAscii.Size = new System.Drawing.Size(561, 363);
            this.pageAscii.TabIndex = 0;
            this.pageAscii.Text = "Tipo ASCII";
            this.pageAscii.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simetrico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pageAsimetrico
            // 
            this.pageAsimetrico.Location = new System.Drawing.Point(4, 24);
            this.pageAsimetrico.Name = "pageAsimetrico";
            this.pageAsimetrico.Padding = new System.Windows.Forms.Padding(3);
            this.pageAsimetrico.Size = new System.Drawing.Size(561, 363);
            this.pageAsimetrico.TabIndex = 2;
            this.pageAsimetrico.Text = "Asimetrico";
            this.pageAsimetrico.UseVisualStyleBackColor = true;
            // 
            // pageHash
            // 
            this.pageHash.Location = new System.Drawing.Point(4, 24);
            this.pageHash.Name = "pageHash";
            this.pageHash.Padding = new System.Windows.Forms.Padding(3);
            this.pageHash.Size = new System.Drawing.Size(561, 363);
            this.pageHash.TabIndex = 3;
            this.pageHash.Text = "HASH";
            this.pageHash.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 38);
            this.panel1.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Encriptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Desencriptar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Encriptador";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tbCtrl.ResumeLayout(false);
            this.pageAscii.ResumeLayout(false);
            this.pageAscii.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TabControl tbCtrl;
        private TabPage pageAscii;
        private TabPage tabPage2;
        private TabPage pageAsimetrico;
        private TabPage pageHash;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}