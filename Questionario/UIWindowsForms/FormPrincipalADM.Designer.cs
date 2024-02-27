namespace UIWindowsForms
{
    partial class FormPrincipalADM
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
            buttonAlterarQuetionario = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAlterarQuetionario
            // 
            buttonAlterarQuetionario.Location = new Point(76, 193);
            buttonAlterarQuetionario.Name = "buttonAlterarQuetionario";
            buttonAlterarQuetionario.Size = new Size(162, 29);
            buttonAlterarQuetionario.TabIndex = 0;
            buttonAlterarQuetionario.Text = "Altera Questionario";
            buttonAlterarQuetionario.UseVisualStyleBackColor = true;
            buttonAlterarQuetionario.Click += buttonAlterarQuetionario_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(315, 333);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipalADM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(315, 333);
            Controls.Add(buttonAlterarQuetionario);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipalADM";
            ShowIcon = false;
            Load += FormPrincipalADM_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAlterarQuetionario;
        private Label label1;
    }
}