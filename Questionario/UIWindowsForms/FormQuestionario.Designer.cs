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
            checkedListBoxRespostas = new CheckedListBox();
            SuspendLayout();
            // 
            // labelPergunta
            // 
            labelPergunta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPergunta.FlatStyle = FlatStyle.Flat;
            labelPergunta.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
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
            buttonProximo.Text = "button1";
            buttonProximo.UseVisualStyleBackColor = true;
            buttonProximo.Click += buttonProximo_Click;
            // 
            // checkedListBoxRespostas
            // 
            checkedListBoxRespostas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxRespostas.BackColor = SystemColors.ButtonFace;
            checkedListBoxRespostas.BorderStyle = BorderStyle.None;
            checkedListBoxRespostas.CheckOnClick = true;
            checkedListBoxRespostas.FormattingEnabled = true;
            checkedListBoxRespostas.Items.AddRange(new object[] { "Sim", "Não", "Talvez" });
            checkedListBoxRespostas.Location = new Point(278, 222);
            checkedListBoxRespostas.Name = "checkedListBoxRespostas";
            checkedListBoxRespostas.Size = new Size(244, 132);
            checkedListBoxRespostas.TabIndex = 4;
            checkedListBoxRespostas.TabStop = false;
            checkedListBoxRespostas.ThreeDCheckBoxes = true;
            checkedListBoxRespostas.UseTabStops = false;
            checkedListBoxRespostas.SelectedIndexChanged += checkedListBoxRespostas_SelectedIndexChanged;
            // 
            // FormQuestionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBoxRespostas);
            Controls.Add(buttonProximo);
            Controls.Add(labelPergunta);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormQuestionario";
            Text = "FormQuestionario";
            Load += FormQuestionario_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label labelPergunta;
        private Button buttonProximo;
        private CheckedListBox checkedListBoxRespostas;
    }
}