namespace UIWindowsForms
{
    partial class FormAlterar
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            perguntaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idcategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            perguntasBindingSource = new BindingSource(components);
            label1 = new Label();
            buttonBuscar = new Button();
            label2 = new Label();
            textBoxPergunta = new TextBox();
            label3 = new Label();
            textBoxCategoria = new TextBox();
            textBoxIdDeBusca = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perguntasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, perguntaDataGridViewTextBoxColumn, idcategoriaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = perguntasBindingSource;
            dataGridView1.Location = new Point(12, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(849, 91);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 70;
            // 
            // perguntaDataGridViewTextBoxColumn
            // 
            perguntaDataGridViewTextBoxColumn.DataPropertyName = "pergunta";
            perguntaDataGridViewTextBoxColumn.HeaderText = "pergunta";
            perguntaDataGridViewTextBoxColumn.MinimumWidth = 6;
            perguntaDataGridViewTextBoxColumn.Name = "perguntaDataGridViewTextBoxColumn";
            perguntaDataGridViewTextBoxColumn.ReadOnly = true;
            perguntaDataGridViewTextBoxColumn.Width = 600;
            // 
            // idcategoriaDataGridViewTextBoxColumn
            // 
            idcategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_categoria";
            idcategoriaDataGridViewTextBoxColumn.HeaderText = "id_categoria";
            idcategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            idcategoriaDataGridViewTextBoxColumn.Name = "idcategoriaDataGridViewTextBoxColumn";
            idcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            idcategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // perguntasBindingSource
            // 
            perguntasBindingSource.DataSource = typeof(Models.Perguntas);
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(873, 76);
            label1.TabIndex = 1;
            label1.Text = "Alterar Pergunta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(125, 113);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 240);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Pergunta";
            // 
            // textBoxPergunta
            // 
            textBoxPergunta.Location = new Point(12, 263);
            textBoxPergunta.Name = "textBoxPergunta";
            textBoxPergunta.Size = new Size(716, 27);
            textBoxPergunta.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(734, 240);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "Categoria";
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(734, 263);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(127, 27);
            textBoxCategoria.TabIndex = 2;
            // 
            // textBoxIdDeBusca
            // 
            textBoxIdDeBusca.Location = new Point(12, 113);
            textBoxIdDeBusca.Name = "textBoxIdDeBusca";
            textBoxIdDeBusca.Size = new Size(107, 27);
            textBoxIdDeBusca.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 90);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 5;
            label4.Text = "id da pergunta";
            // 
            // button2
            // 
            button2.Location = new Point(767, 301);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(667, 301);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormAlterar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(873, 341);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxPergunta);
            Controls.Add(textBoxIdDeBusca);
            Controls.Add(textBoxCategoria);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormAlterar";
            Text = "FormAlterar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)perguntasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource perguntasBindingSource;
        private Label label1;
        private Button buttonBuscar;
        private Label label2;
        private TextBox textBoxPergunta;
        private Label label3;
        private TextBox textBoxCategoria;
        private TextBox textBoxIdDeBusca;
        private Label label4;
        private Button button2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perguntaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
        private Button button1;
    }
}