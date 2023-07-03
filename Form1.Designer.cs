namespace AgendadeContatos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_CONTATOLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label aNIVERSARIOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDeContatosDataSet = new AgendadeContatos.AgendaDeContatosDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CONTATOTextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.tELEFONETextBox = new System.Windows.Forms.TextBox();
            this.aNIVERSARIODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fAMILIACheckBox = new System.Windows.Forms.CheckBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgContatos = new System.Windows.Forms.DataGridView();
            this.tableTableAdapter = new AgendadeContatos.AgendaDeContatosDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new AgendadeContatos.AgendaDeContatosDataSetTableAdapters.TableAdapterManager();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANIVERSARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_CONTATOLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            aNIVERSARIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDeContatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CONTATOLabel
            // 
            iD_CONTATOLabel.AutoSize = true;
            iD_CONTATOLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_CONTATOLabel.Location = new System.Drawing.Point(12, 36);
            iD_CONTATOLabel.Name = "iD_CONTATOLabel";
            iD_CONTATOLabel.Size = new System.Drawing.Size(125, 28);
            iD_CONTATOLabel.TabIndex = 1;
            iD_CONTATOLabel.Text = "ID CONTATO:";
            iD_CONTATOLabel.Click += new System.EventHandler(this.iD_CONTATOLabel_Click);
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOMELabel.Location = new System.Drawing.Point(12, 84);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(69, 28);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "NOME:";
            nOMELabel.Click += new System.EventHandler(this.nOMELabel_Click);
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tELEFONELabel.Location = new System.Drawing.Point(12, 126);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(106, 28);
            tELEFONELabel.TabIndex = 5;
            tELEFONELabel.Text = "TELEFONE:";
            tELEFONELabel.Click += new System.EventHandler(this.tELEFONELabel_Click);
            // 
            // aNIVERSARIOLabel
            // 
            aNIVERSARIOLabel.AutoSize = true;
            aNIVERSARIOLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aNIVERSARIOLabel.Location = new System.Drawing.Point(12, 166);
            aNIVERSARIOLabel.Name = "aNIVERSARIOLabel";
            aNIVERSARIOLabel.Size = new System.Drawing.Size(133, 28);
            aNIVERSARIOLabel.TabIndex = 7;
            aNIVERSARIOLabel.Text = "ANIVERSARIO:";
            aNIVERSARIOLabel.Click += new System.EventHandler(this.aNIVERSARIOLabel_Click);
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(447, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.agendaDeContatosDataSet;
            // 
            // agendaDeContatosDataSet
            // 
            this.agendaDeContatosDataSet.DataSetName = "AgendaDeContatosDataSet";
            this.agendaDeContatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // iD_CONTATOTextBox
            // 
            this.iD_CONTATOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ID_CONTATO", true));
            this.iD_CONTATOTextBox.Enabled = false;
            this.iD_CONTATOTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_CONTATOTextBox.Location = new System.Drawing.Point(160, 33);
            this.iD_CONTATOTextBox.Name = "iD_CONTATOTextBox";
            this.iD_CONTATOTextBox.Size = new System.Drawing.Size(68, 36);
            this.iD_CONTATOTextBox.TabIndex = 2;
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "NOME", true));
            this.nOMETextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOMETextBox.Location = new System.Drawing.Point(158, 76);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(234, 36);
            this.nOMETextBox.TabIndex = 4;
            // 
            // tELEFONETextBox
            // 
            this.tELEFONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "TELEFONE", true));
            this.tELEFONETextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tELEFONETextBox.Location = new System.Drawing.Point(160, 118);
            this.tELEFONETextBox.Name = "tELEFONETextBox";
            this.tELEFONETextBox.Size = new System.Drawing.Size(150, 36);
            this.tELEFONETextBox.TabIndex = 6;
            // 
            // aNIVERSARIODateTimePicker
            // 
            this.aNIVERSARIODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "ANIVERSARIO", true));
            this.aNIVERSARIODateTimePicker.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aNIVERSARIODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aNIVERSARIODateTimePicker.Location = new System.Drawing.Point(160, 160);
            this.aNIVERSARIODateTimePicker.Name = "aNIVERSARIODateTimePicker";
            this.aNIVERSARIODateTimePicker.Size = new System.Drawing.Size(139, 36);
            this.aNIVERSARIODateTimePicker.TabIndex = 8;
            // 
            // fAMILIACheckBox
            // 
            this.fAMILIACheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "FAMILIA", true));
            this.fAMILIACheckBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fAMILIACheckBox.Location = new System.Drawing.Point(314, 169);
            this.fAMILIACheckBox.Name = "fAMILIACheckBox";
            this.fAMILIACheckBox.Size = new System.Drawing.Size(135, 24);
            this.fAMILIACheckBox.TabIndex = 10;
            this.fAMILIACheckBox.Text = "É da familia";
            this.fAMILIACheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::AgendadeContatos.Properties.Resources.img_pesquisar;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(324, 224);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(149, 31);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(34, 230);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(284, 20);
            this.txtPesquisa.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Digite o nome do contato e clique no botão Pesquisar";
            // 
            // dtgContatos
            // 
            this.dtgContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME,
            this.TELEFONE,
            this.ANIVERSARIO,
            this.FAMILIA});
            this.dtgContatos.Location = new System.Drawing.Point(17, 282);
            this.dtgContatos.Name = "dtgContatos";
            this.dtgContatos.RowHeadersVisible = false;
            this.dtgContatos.Size = new System.Drawing.Size(418, 150);
            this.dtgContatos.TabIndex = 15;
            this.dtgContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = AgendadeContatos.AgendaDeContatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "ID_CONTATO";
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 45;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.Width = 140;
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "TELEFONE";
            this.TELEFONE.HeaderText = "Telefone";
            this.TELEFONE.Name = "TELEFONE";
            // 
            // ANIVERSARIO
            // 
            this.ANIVERSARIO.DataPropertyName = "ANIVERSARIO";
            this.ANIVERSARIO.HeaderText = "Aniversário";
            this.ANIVERSARIO.Name = "ANIVERSARIO";
            this.ANIVERSARIO.Width = 80;
            // 
            // FAMILIA
            // 
            this.FAMILIA.DataPropertyName = "FAMILIA";
            this.FAMILIA.HeaderText = "Familia";
            this.FAMILIA.Name = "FAMILIA";
            this.FAMILIA.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 434);
            this.Controls.Add(this.dtgContatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(iD_CONTATOLabel);
            this.Controls.Add(this.iD_CONTATOTextBox);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONETextBox);
            this.Controls.Add(aNIVERSARIOLabel);
            this.Controls.Add(this.aNIVERSARIODateTimePicker);
            this.Controls.Add(this.fAMILIACheckBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Meus Contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDeContatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgendaDeContatosDataSet agendaDeContatosDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private AgendaDeContatosDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private AgendaDeContatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CONTATOTextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox tELEFONETextBox;
        private System.Windows.Forms.DateTimePicker aNIVERSARIODateTimePicker;
        private System.Windows.Forms.CheckBox fAMILIACheckBox;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANIVERSARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
    }
}

