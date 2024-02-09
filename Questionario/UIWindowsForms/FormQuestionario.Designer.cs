namespace UIWindowsForms
{
    partial class FormQuestionario
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
            labelPergunta = new Label();
            buttonProximo = new Button();
            checkBoxSim = new CheckBox();
            checkBoxNao = new CheckBox();
            checkBoxTalvez = new CheckBox();
            SuspendLayout();
            // 
            // labelPergunta
            // 
            labelPergunta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPergunta.FlatStyle = FlatStyle.Flat;
            labelPergunta.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            labelPergunta.ForeColor = SystemColors.Control;
            labelPergunta.Location = new Point(12, 9);
            labelPergunta.Name = "labelPergunta";
            labelPergunta.Size = new Size(776, 210);
            labelPergunta.TabIndex = 2;
            labelPergunta.Text = "label1";
            labelPergunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonProximo
            // 
            buttonProximo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonProximo.Location = new Point(353, 408);
            buttonProximo.Name = "buttonProximo";
            buttonProximo.Size = new Size(94, 30);
            buttonProximo.TabIndex = 3;
            buttonProximo.Text = "Proxima";
            buttonProximo.UseVisualStyleBackColor = true;
            buttonProximo.Click += buttonProximo_Click;
            // 
            // checkBoxSim
            // 
            checkBoxSim.AutoSize = true;
            checkBoxSim.Location = new Point(372, 232);
            checkBoxSim.Name = "checkBoxSim";
            checkBoxSim.Size = new Size(56, 24);
            checkBoxSim.TabIndex = 4;
            checkBoxSim.Text = "Sim";
            checkBoxSim.UseVisualStyleBackColor = true;
            checkBoxSim.CheckedChanged += checkBoxSim_CheckedChanged;
            // 
            // checkBoxNao
            // 
            checkBoxNao.AutoSize = true;
            checkBoxNao.Location = new Point(371, 266);
            checkBoxNao.Name = "checkBoxNao";
            checkBoxNao.Size = new Size(59, 24);
            checkBoxNao.TabIndex = 5;
            checkBoxNao.Text = "Não";
            checkBoxNao.UseVisualStyleBackColor = true;
            checkBoxNao.CheckedChanged += checkBoxNao_CheckedChanged;
            // 
            // checkBoxTalvez
            // 
            checkBoxTalvez.AutoSize = true;
            checkBoxTalvez.Location = new Point(371, 296);
            checkBoxTalvez.Name = "checkBoxTalvez";
            checkBoxTalvez.Size = new Size(71, 24);
            checkBoxTalvez.TabIndex = 6;
            checkBoxTalvez.Text = "Talvez";
            checkBoxTalvez.UseVisualStyleBackColor = true;
            checkBoxTalvez.CheckedChanged += checkBoxTalvez_CheckedChanged;
            // 
            // FormQuestionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxTalvez);
            Controls.Add(checkBoxNao);
            Controls.Add(checkBoxSim);
            Controls.Add(buttonProximo);
            Controls.Add(labelPergunta);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormQuestionario";
            ShowIcon = false;
            Load += FormQuestionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelPergunta;
        private Button buttonProximo;
        private CheckBox checkBoxSim;
        private CheckBox checkBoxNao;
        private CheckBox checkBoxTalvez;
    }
}