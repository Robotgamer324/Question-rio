namespace UIWindowsForms
{
    partial class FormBuscarPerguntas
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
            comboBoxBuscarPor = new ComboBox();
            dataGridViewUsuario = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            buttonExcluir = new Button();
            buttonCancelar = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            buttonBuscar = new Button();
            textBoxBuscarPor = new TextBox();
            perguntasBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            perguntaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idcategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perguntasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Pergunta", "Id", "Id categoria" });
            comboBoxBuscarPor.Location = new Point(12, 130);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(151, 28);
            comboBoxBuscarPor.TabIndex = 35;
            // 
            // dataGridViewUsuario
            // 
            dataGridViewUsuario.AllowUserToAddRows = false;
            dataGridViewUsuario.AllowUserToDeleteRows = false;
            dataGridViewUsuario.AllowUserToOrderColumns = true;
            dataGridViewUsuario.AutoGenerateColumns = false;
            dataGridViewUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuario.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, perguntaDataGridViewTextBoxColumn, idcategoriaDataGridViewTextBoxColumn });
            dataGridViewUsuario.DataSource = perguntasBindingSource;
            dataGridViewUsuario.Location = new Point(12, 165);
            dataGridViewUsuario.Name = "dataGridViewUsuario";
            dataGridViewUsuario.ReadOnly = true;
            dataGridViewUsuario.RowHeadersWidth = 51;
            dataGridViewUsuario.RowTemplate.Height = 29;
            dataGridViewUsuario.Size = new Size(997, 239);
            dataGridViewUsuario.TabIndex = 34;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1021, 63);
            label3.TabIndex = 32;
            label3.Text = "Buscar Perguntas";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 33;
            label4.Text = "Buscar por";
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(902, 131);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(93, 28);
            buttonExcluir.TabIndex = 27;
            buttonExcluir.Text = "E&xcluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(916, 416);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(93, 28);
            buttonCancelar.TabIndex = 28;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(803, 131);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(93, 28);
            buttonInserir.TabIndex = 29;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(704, 130);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(93, 28);
            buttonAlterar.TabIndex = 30;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(605, 129);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(93, 28);
            buttonBuscar.TabIndex = 31;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Location = new Point(169, 131);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(430, 27);
            textBoxBuscarPor.TabIndex = 26;
            // 
            // perguntasBindingSource
            // 
            perguntasBindingSource.DataSource = typeof(Models.Perguntas);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // perguntaDataGridViewTextBoxColumn
            // 
            perguntaDataGridViewTextBoxColumn.DataPropertyName = "pergunta";
            perguntaDataGridViewTextBoxColumn.HeaderText = "pergunta";
            perguntaDataGridViewTextBoxColumn.MinimumWidth = 6;
            perguntaDataGridViewTextBoxColumn.Name = "perguntaDataGridViewTextBoxColumn";
            perguntaDataGridViewTextBoxColumn.ReadOnly = true;
            perguntaDataGridViewTextBoxColumn.Width = 125;
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
            // FormBuscarPerguntas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1021, 450);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(dataGridViewUsuario);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonInserir);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscarPor);
            Name = "FormBuscarPerguntas";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)perguntasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewUsuario;
        private Label label3;
        private Label label4;
        private Button buttonExcluir;
        private Button buttonCancelar;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonBuscar;
        private TextBox textBoxBuscarPor;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perguntaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
        private BindingSource perguntasBindingSource;
    }
}