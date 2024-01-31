namespace UIWinFormsApp
{
    partial class FormPrincipal
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
            IniciarButteon = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // IniciarButteon
            // 
            IniciarButteon.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            IniciarButteon.Cursor = Cursors.Cross;
            IniciarButteon.Enabled = false;
            IniciarButteon.Location = new Point(159, 196);
            IniciarButteon.Name = "IniciarButteon";
            IniciarButteon.Size = new Size(397, 96);
            IniciarButteon.TabIndex = 0;
            IniciarButteon.TabStop = false;
            IniciarButteon.Text = "Iniciar";
            IniciarButteon.UseVisualStyleBackColor = true;
            IniciarButteon.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(231, 134);
            label1.Name = "label1";
            label1.Size = new Size(271, 59);
            label1.TabIndex = 1;
            label1.Text = "Teste Vocacional";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 450);
            Controls.Add(label1);
            Controls.Add(IniciarButteon);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button IniciarButteon;
        private Label label1;
    }
}