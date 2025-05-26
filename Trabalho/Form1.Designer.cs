namespace Trabalho
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usuariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gabriel_BDDataSet = new Trabalho.Gabriel_BDDataSet();
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
            this.usuariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExcluir = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.usuariosTableAdapter = new Trabalho.Gabriel_BDDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Trabalho.Gabriel_BDDataSetTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).BeginInit();
            this.usuariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gabriel_BDDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(57, 47);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(29, 25);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(57, 101);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(52, 25);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(57, 155);
            telefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(69, 25);
            telefoneLabel.TabIndex = 5;
            telefoneLabel.Text = "Telefone:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.Location = new System.Drawing.Point(57, 209);
            cPFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(40, 25);
            cPFLabel.TabIndex = 7;
            cPFLabel.Text = "CPF:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(57, 263);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(48, 25);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // usuariosBindingNavigator
            // 
            this.usuariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuariosBindingNavigator.BindingSource = this.usuariosBindingSource;
            this.usuariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuariosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.usuariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usuariosBindingNavigatorSaveItem});
            this.usuariosBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.usuariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuariosBindingNavigator.Name = "usuariosBindingNavigator";
            this.usuariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuariosBindingNavigator.Size = new System.Drawing.Size(295, 25);
            this.usuariosBindingNavigator.TabIndex = 0;
            this.usuariosBindingNavigator.Text = "bindingNavigator1";
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
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.gabriel_BDDataSet;
            // 
            // gabriel_BDDataSet
            // 
            this.gabriel_BDDataSet.DataSetName = "Gabriel_BDDataSet";
            this.gabriel_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
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
            // usuariosBindingNavigatorSaveItem
            // 
            this.usuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosBindingNavigatorSaveItem.Image")));
            this.usuariosBindingNavigatorSaveItem.Name = "usuariosBindingNavigatorSaveItem";
            this.usuariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuariosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.usuariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuariosBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(134, 40);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(78, 33);
            this.iDTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(134, 94);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(162, 33);
            this.nomeTextBox.TabIndex = 4;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Telefone", true));
            this.telefoneTextBox.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTextBox.Location = new System.Drawing.Point(134, 148);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(162, 33);
            this.telefoneTextBox.TabIndex = 6;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "CPF", true));
            this.cPFTextBox.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPFTextBox.Location = new System.Drawing.Point(134, 202);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(162, 33);
            this.cPFTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(134, 256);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(162, 33);
            this.emailTextBox.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 534);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.usuariosBindingNavigator);
            this.tabPage1.Controls.Add(iDLabel);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(this.iDTextBox);
            this.tabPage1.Controls.Add(emailLabel);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.cPFTextBox);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Controls.Add(cPFLabel);
            this.tabPage1.Controls.Add(telefoneLabel);
            this.tabPage1.Controls.Add(this.telefoneTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(506, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 40);
            this.label7.TabIndex = 14;
            this.label7.Text = "CodeNova";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(421, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(282, 280);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "©2005-2025 CodeNova  All Rights Reserved";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnPesquisa);
            this.tabPage2.Controls.Add(this.txtPesquisa);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 680);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "©2005-2025 CodeNova  All Rights Reserved";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(103, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(607, 220);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn9.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn10.HeaderText = "Email";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPesquisa.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisa.Location = new System.Drawing.Point(603, 47);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(107, 66);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.White;
            this.txtPesquisa.CausesValidation = false;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.ForeColor = System.Drawing.Color.White;
            this.txtPesquisa.Location = new System.Drawing.Point(113, 66);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(475, 35);
            this.txtPesquisa.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtExcluir);
            this.tabPage3.Controls.Add(this.btnExcluir);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(772, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Exclusão";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "©2005-2025 CodeNova  All Rights Reserved";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 680);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "©2005-2025 CodeNova  All Rights Reserved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o ID do Usuário a ser excluído:";
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(266, 138);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(170, 35);
            this.txtExcluir.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(489, 124);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 70);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Trabalho.Gabriel_BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 534);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).EndInit();
            this.usuariosBindingNavigator.ResumeLayout(false);
            this.usuariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gabriel_BDDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gabriel_BDDataSet gabriel_BDDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private Gabriel_BDDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private Gabriel_BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuariosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton usuariosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;

    }
}

