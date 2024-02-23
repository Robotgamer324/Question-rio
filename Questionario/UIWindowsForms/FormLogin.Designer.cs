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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 109);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(176, 211);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 20);
            labelSenha.TabIndex = 1;
            labelSenha.Text = "Senha";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(93, 169);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(215, 27);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(93, 248);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(215, 27);
            textBoxSenha.TabIndex = 3;
            textBoxSenha.TextChanged += textBox2_TextChanged;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(179, 146);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(46, 20);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            labelLogin.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 427);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxLogin);
            Controls.Add(labelLogin);
            Controls.Add(labelSenha);
            Controls.Add(label1);
            Name = "FormLogin";
            ShowIcon = false;
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
    }
}