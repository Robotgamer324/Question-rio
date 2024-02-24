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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestionario));
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
            labelPergunta.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            labelPergunta.ForeColor = Color.Black;
            labelPergunta.Location = new Point(0, 212);
            labelPergunta.Name = "labelPergunta";
            labelPergunta.Size = new Size(789, 109);
            labelPergunta.TabIndex = 2;
            labelPergunta.Text = "label1";
            labelPergunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonProximo
            // 
            buttonProximo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonProximo.Location = new Point(395, 398);
            buttonProximo.Name = "buttonProximo";
            buttonProximo.Size = new Size(83, 30);
            buttonProximo.TabIndex = 3;
            buttonProximo.Text = "Proxima";
            buttonProximo.UseVisualStyleBackColor = true;
            buttonProximo.Click += buttonProximo_Click;
            // 
            // radioButtonSim
            // 
            radioButtonSim.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButtonSim.AutoSize = true;
            radioButtonSim.BackColor = Color.Transparent;
            radioButtonSim.Location = new Point(367, 324);
            radioButtonSim.Name = "radioButtonSim";
            radioButtonSim.Size = new Size(55, 24);
            radioButtonSim.TabIndex = 7;
            radioButtonSim.TabStop = true;
            radioButtonSim.Text = "Sim";
            radioButtonSim.UseVisualStyleBackColor = false;
            radioButtonSim.CheckedChanged += radioButtonSim_CheckedChanged;
            // 
            // radioButtonNao
            // 
            radioButtonNao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButtonNao.AutoSize = true;
            radioButtonNao.BackColor = Color.Transparent;
            radioButtonNao.Location = new Point(365, 354);
            radioButtonNao.Name = "radioButtonNao";
            radioButtonNao.Size = new Size(58, 24);
            radioButtonNao.TabIndex = 7;
            radioButtonNao.TabStop = true;
            radioButtonNao.Text = "Não";
            radioButtonNao.UseVisualStyleBackColor = false;
            // 
            // buttonSair
            // 
            buttonSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSair.Location = new Point(306, 398);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(83, 30);
            buttonSair.TabIndex = 3;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // FormQuestionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(789, 440);
            Controls.Add(radioButtonNao);
            Controls.Add(radioButtonSim);
            Controls.Add(buttonSair);
            Controls.Add(buttonProximo);
            Controls.Add(labelPergunta);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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