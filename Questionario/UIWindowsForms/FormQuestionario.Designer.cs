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
            radioButtonSim = new RadioButton();
            radioButtonNao = new RadioButton();
            buttonSair = new Button();
            SuspendLayout();
            // 
            // labelPergunta
            // 
            labelPergunta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPergunta.BackColor = Color.Transparent;
            labelPergunta.FlatStyle = FlatStyle.Flat;
            labelPergunta.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelPergunta.ForeColor = Color.WhiteSmoke;
            labelPergunta.Location = new Point(0, 138);
            labelPergunta.Name = "labelPergunta";
            labelPergunta.Size = new Size(888, 183);
            labelPergunta.TabIndex = 2;
            labelPergunta.Text = "label1";
            labelPergunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonProximo
            // 
            buttonProximo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonProximo.Location = new Point(444, 398);
            buttonProximo.Name = "buttonProximo";
            buttonProximo.Size = new Size(93, 30);
            buttonProximo.TabIndex = 3;
            buttonProximo.Text = "Proxima";
            buttonProximo.UseVisualStyleBackColor = true;
            buttonProximo.Click += buttonProximo_Click;
            // 
            // radioButtonSim
            // 
            radioButtonSim.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButtonSim.AutoSize = true;
            radioButtonSim.BackColor = Color.Transparent;
            radioButtonSim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Millimeter);
            radioButtonSim.ForeColor = SystemColors.ButtonFace;
            radioButtonSim.Location = new Point(281, 324);
            radioButtonSim.Name = "radioButtonSim";
            radioButtonSim.Size = new Size(121, 63);
            radioButtonSim.TabIndex = 7;
            radioButtonSim.TabStop = true;
            radioButtonSim.Text = "Sim";
            radioButtonSim.UseVisualStyleBackColor = false;
            radioButtonSim.CheckedChanged += radioButtonSim_CheckedChanged;
            // 
            // radioButtonNao
            // 
            radioButtonNao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButtonNao.AutoSize = true;
            radioButtonNao.BackColor = Color.Transparent;
            radioButtonNao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Millimeter);
            radioButtonNao.ForeColor = SystemColors.ButtonFace;
            radioButtonNao.Location = new Point(487, 324);
            radioButtonNao.Name = "radioButtonNao";
            radioButtonNao.Size = new Size(129, 63);
            radioButtonNao.TabIndex = 7;
            radioButtonNao.TabStop = true;
            radioButtonNao.Text = "Não";
            radioButtonNao.UseVisualStyleBackColor = false;
            radioButtonNao.CheckedChanged += radioButtonNao_CheckedChanged;
            // 
            // buttonSair
            // 
            buttonSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSair.Location = new Point(344, 398);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(93, 30);
            buttonSair.TabIndex = 3;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // FormQuestionario
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(888, 440);
            Controls.Add(radioButtonNao);
            Controls.Add(radioButtonSim);
            Controls.Add(buttonSair);
            Controls.Add(buttonProximo);
            Controls.Add(labelPergunta);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "FormQuestionario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormQuestionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelPergunta;
        private Button buttonProximo;
        private RadioButton radioButtonSim;
        private RadioButton radioButtonNao;
        private Button buttonSair;
    }
}