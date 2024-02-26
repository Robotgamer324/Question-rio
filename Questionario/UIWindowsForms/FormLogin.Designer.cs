namespace UIWindowsForms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            labelSenha = new Label();
            textBoxLogin = new TextBox();
            textBoxSenha = new TextBox();
            labelLogin = new Label();
            pictureBox1 = new PictureBox();
            buttonSair = new Button();
            buttonComfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 93);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.BackColor = Color.Transparent;
            labelSenha.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.ForeColor = SystemColors.ButtonFace;
            labelSenha.Location = new Point(112, 200);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(94, 37);
            labelSenha.TabIndex = 1;
            labelSenha.Text = "Senha";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(50, 170);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(215, 27);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(50, 251);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(215, 27);
            textBoxSenha.TabIndex = 3;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogin.ForeColor = SystemColors.ButtonFace;
            labelLogin.Location = new Point(115, 130);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(89, 37);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // buttonSair
            // 
            buttonSair.Location = new Point(50, 284);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(94, 29);
            buttonSair.TabIndex = 5;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonComfirmar
            // 
            buttonComfirmar.Location = new Point(171, 284);
            buttonComfirmar.Name = "buttonComfirmar";
            buttonComfirmar.Size = new Size(94, 29);
            buttonComfirmar.TabIndex = 6;
            buttonComfirmar.Text = "Comfirmar";
            buttonComfirmar.UseVisualStyleBackColor = true;
            buttonComfirmar.Click += buttonComfirmar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(321, 392);
            Controls.Add(buttonComfirmar);
            Controls.Add(buttonSair);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxLogin);
            Controls.Add(labelLogin);
            Controls.Add(labelSenha);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelSenha;
        private TextBox textBoxLogin;
        private TextBox textBoxSenha;
        private Label labelLogin;
        private PictureBox pictureBox1;
        private Button buttonSair;
        private Button buttonComfirmar;
    }
}