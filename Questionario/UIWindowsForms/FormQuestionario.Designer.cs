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
            checkedListBoxRespostas = new CheckedListBox();
            labelPergunta = new Label();
            SuspendLayout();
            // 
            // checkedListBoxRespostas
            // 
            checkedListBoxRespostas.Dock = DockStyle.Bottom;
            checkedListBoxRespostas.FormattingEnabled = true;
            checkedListBoxRespostas.Location = new Point(0, 314);
            checkedListBoxRespostas.Name = "checkedListBoxRespostas";
            checkedListBoxRespostas.Size = new Size(800, 136);
            checkedListBoxRespostas.TabIndex = 0;
            checkedListBoxRespostas.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // labelPergunta
            // 
            labelPergunta.AutoSize = true;
            labelPergunta.Location = new Point(375, 171);
            labelPergunta.Name = "labelPergunta";
            labelPergunta.Size = new Size(50, 20);
            labelPergunta.TabIndex = 2;
            labelPergunta.Text = "label1";
            labelPergunta.Click += labelPergunta_Click_1;
            // 
            // FormQuestionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPergunta);
            Controls.Add(checkedListBoxRespostas);
            Name = "FormQuestionario";
            Text = "FormQuestionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxRespostas;
        private Label labelPergunta;
    }
}