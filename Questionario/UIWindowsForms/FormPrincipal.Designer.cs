namespace UIWindowsForms
{
    partial class FormPrincipal
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
            buttonIniciar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonIniciar
            // 
            buttonIniciar.Anchor = AnchorStyles.None;
            buttonIniciar.Location = new Point(311, 221);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(144, 54);
            buttonIniciar.TabIndex = 0;
            buttonIniciar.Text = "Iniciar";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(110, 96);
            label1.Name = "label1";
            label1.Size = new Size(546, 98);
            label1.TabIndex = 1;
            label1.Text = "Bem vindo\r\nVamos descobrir sua vocação!!!!!\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(767, 496);
            Controls.Add(label1);
            Controls.Add(buttonIniciar);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormPrincipal";
            ShowIcon = false;
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonIniciar;
        private Label label1;
    }
}
