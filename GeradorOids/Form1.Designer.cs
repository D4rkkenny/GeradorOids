namespace GeradorOids
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
            mainTitulo = new Label();
            ipFornecido = new TextBox();
            txtIP = new Label();
            buttonGerar = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            txtSelectedPath = new TextBox();
            BtnSelectFolder = new Button();
            conclusao = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // mainTitulo
            // 
            mainTitulo.AutoSize = true;
            mainTitulo.Font = new Font("Segoe UI", 16F);
            mainTitulo.Location = new Point(129, 21);
            mainTitulo.Name = "mainTitulo";
            mainTitulo.Size = new Size(143, 30);
            mainTitulo.TabIndex = 0;
            mainTitulo.Text = "Gerador Oids";
            // 
            // ipFornecido
            // 
            ipFornecido.Location = new Point(155, 75);
            ipFornecido.Name = "ipFornecido";
            ipFornecido.Size = new Size(100, 23);
            ipFornecido.TabIndex = 1;
            ipFornecido.TextAlign = HorizontalAlignment.Center;
            // 
            // txtIP
            // 
            txtIP.AutoSize = true;
            txtIP.Location = new Point(129, 78);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(20, 15);
            txtIP.TabIndex = 2;
            txtIP.Text = "IP:";
            // 
            // buttonGerar
            // 
            buttonGerar.Location = new Point(129, 216);
            buttonGerar.Name = "buttonGerar";
            buttonGerar.Size = new Size(143, 23);
            buttonGerar.TabIndex = 3;
            buttonGerar.Text = "Gerar";
            buttonGerar.UseVisualStyleBackColor = true;
            buttonGerar.Click += buttonGerar_Click;
            // 
            // txtSelectedPath
            // 
            txtSelectedPath.Location = new Point(42, 160);
            txtSelectedPath.Name = "txtSelectedPath";
            txtSelectedPath.Size = new Size(194, 23);
            txtSelectedPath.TabIndex = 4;
            // 
            // BtnSelectFolder
            // 
            BtnSelectFolder.Location = new Point(242, 160);
            BtnSelectFolder.Name = "BtnSelectFolder";
            BtnSelectFolder.Size = new Size(108, 23);
            BtnSelectFolder.TabIndex = 5;
            BtnSelectFolder.Text = "Selecionar pasta";
            BtnSelectFolder.UseVisualStyleBackColor = true;
            BtnSelectFolder.Click += BtnSelectFolder_Click;
            // 
            // conclusao
            // 
            conclusao.AutoSize = true;
            conclusao.Font = new Font("Segoe UI", 12F);
            conclusao.ForeColor = Color.OliveDrab;
            conclusao.Location = new Point(140, 261);
            conclusao.Name = "conclusao";
            conclusao.Size = new Size(115, 21);
            conclusao.TabIndex = 6;
            conclusao.Text = "Arquivo Criado";
            conclusao.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 130);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 7;
            label1.Text = "Local Salvamento do Arquivo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 331);
            Controls.Add(label1);
            Controls.Add(conclusao);
            Controls.Add(BtnSelectFolder);
            Controls.Add(txtSelectedPath);
            Controls.Add(buttonGerar);
            Controls.Add(txtIP);
            Controls.Add(ipFornecido);
            Controls.Add(mainTitulo);
            Name = "Form1";
            Text = "Gerador Oids";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainTitulo;
        private TextBox ipFornecido;
        private Label txtIP;
        private Button buttonGerar;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtSelectedPath;
        private Button BtnSelectFolder;
        private Label conclusao;
        private Label label1;
    }
}
