<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funcionario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NomeLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim Data_de_NascimentoLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funcionario))
        Me.BancodedadosDataSet = New DoceriaAngelCake.bancodedadosDataSet()
        Me.FuncionariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncionariosTableAdapter = New DoceriaAngelCake.bancodedadosDataSetTableAdapters.funcionariosTableAdapter()
        Me.TableAdapterManager = New DoceriaAngelCake.bancodedadosDataSetTableAdapters.TableAdapterManager()
        Me.FuncionariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FuncionariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FuncionariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox()
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Data_de_NascimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        NomeLabel = New System.Windows.Forms.Label()
        EndereçoLabel = New System.Windows.Forms.Label()
        CPFLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        Data_de_NascimentoLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        CType(Me.BancodedadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FuncionariosBindingNavigator.SuspendLayout()
        CType(Me.FuncionariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(3, 123)
        NomeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 2
        NomeLabel.Text = "Nome:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Location = New System.Drawing.Point(3, 146)
        EndereçoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(56, 13)
        EndereçoLabel.TabIndex = 4
        EndereçoLabel.Text = "Endereço:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(3, 169)
        CPFLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 6
        CPFLabel.Text = "CPF:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(3, 191)
        TelefoneLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 8
        TelefoneLabel.Text = "Telefone:"
        '
        'Data_de_NascimentoLabel
        '
        Data_de_NascimentoLabel.AutoSize = True
        Data_de_NascimentoLabel.Location = New System.Drawing.Point(3, 215)
        Data_de_NascimentoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Data_de_NascimentoLabel.Name = "Data_de_NascimentoLabel"
        Data_de_NascimentoLabel.Size = New System.Drawing.Size(107, 13)
        Data_de_NascimentoLabel.TabIndex = 10
        Data_de_NascimentoLabel.Text = "Data de Nascimento:"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Location = New System.Drawing.Point(3, 237)
        E_mailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(38, 13)
        E_mailLabel.TabIndex = 12
        E_mailLabel.Text = "E-mail:"
        '
        'BancodedadosDataSet
        '
        Me.BancodedadosDataSet.DataSetName = "bancodedadosDataSet"
        Me.BancodedadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FuncionariosBindingSource
        '
        Me.FuncionariosBindingSource.DataMember = "funcionarios"
        Me.FuncionariosBindingSource.DataSource = Me.BancodedadosDataSet
        '
        'FuncionariosTableAdapter
        '
        Me.FuncionariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.estoqueTableAdapter = Nothing
        Me.TableAdapterManager.funcionariosTableAdapter = Me.FuncionariosTableAdapter
        Me.TableAdapterManager.UpdateOrder = DoceriaAngelCake.bancodedadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FuncionariosBindingNavigator
        '
        Me.FuncionariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FuncionariosBindingNavigator.BindingSource = Me.FuncionariosBindingSource
        Me.FuncionariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FuncionariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FuncionariosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FuncionariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FuncionariosBindingNavigatorSaveItem})
        Me.FuncionariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FuncionariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FuncionariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FuncionariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FuncionariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FuncionariosBindingNavigator.Name = "FuncionariosBindingNavigator"
        Me.FuncionariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FuncionariosBindingNavigator.Size = New System.Drawing.Size(696, 22)
        Me.FuncionariosBindingNavigator.TabIndex = 0
        Me.FuncionariosBindingNavigator.Text = "BindingNavigator1"
        Me.FuncionariosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 19)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 22)
        '
        'FuncionariosBindingNavigatorSaveItem
        '
        Me.FuncionariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FuncionariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("FuncionariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FuncionariosBindingNavigatorSaveItem.Name = "FuncionariosBindingNavigatorSaveItem"
        Me.FuncionariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 19)
        Me.FuncionariosBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'FuncionariosDataGridView
        '
        Me.FuncionariosDataGridView.AutoGenerateColumns = False
        Me.FuncionariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FuncionariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.FuncionariosDataGridView.DataSource = Me.FuncionariosBindingSource
        Me.FuncionariosDataGridView.Location = New System.Drawing.Point(229, 18)
        Me.FuncionariosDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FuncionariosDataGridView.Name = "FuncionariosDataGridView"
        Me.FuncionariosDataGridView.RowHeadersWidth = 51
        Me.FuncionariosDataGridView.RowTemplate.Height = 24
        Me.FuncionariosDataGridView.Size = New System.Drawing.Size(372, 359)
        Me.FuncionariosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Endereço"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Endereço"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CPF"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CPF"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Telefone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telefone"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Data de Nascimento"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Data de Nascimento"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "E-mail"
        Me.DataGridViewTextBoxColumn6.HeaderText = "E-mail"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(113, 121)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(112, 20)
        Me.NomeTextBox.TabIndex = 3
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(113, 143)
        Me.EndereçoTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(112, 20)
        Me.EndereçoTextBox.TabIndex = 5
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(113, 166)
        Me.CPFMaskedTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CPFMaskedTextBox.Mask = "000.000.000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(112, 20)
        Me.CPFMaskedTextBox.TabIndex = 7
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(113, 189)
        Me.TelefoneMaskedTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TelefoneMaskedTextBox.Mask = "(21) 00000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(112, 20)
        Me.TelefoneMaskedTextBox.TabIndex = 9
        '
        'Data_de_NascimentoDateTimePicker
        '
        Me.Data_de_NascimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FuncionariosBindingSource, "Data de Nascimento", True))
        Me.Data_de_NascimentoDateTimePicker.Location = New System.Drawing.Point(113, 212)
        Me.Data_de_NascimentoDateTimePicker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Data_de_NascimentoDateTimePicker.Name = "Data_de_NascimentoDateTimePicker"
        Me.Data_de_NascimentoDateTimePicker.Size = New System.Drawing.Size(112, 20)
        Me.Data_de_NascimentoDateTimePicker.TabIndex = 11
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionariosBindingSource, "E-mail", True))
        Me.E_mailTextBox.Location = New System.Drawing.Point(113, 234)
        Me.E_mailTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(112, 20)
        Me.E_mailTextBox.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(65, 322)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 40)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Remover Funcionário"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(113, 278)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 39)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Salvar Alterações"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 278)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 39)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Novo Funcionário"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 36)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Funcionários"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(32, 19)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 19)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Voltar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(EndereçoLabel)
        Me.Controls.Add(Me.EndereçoTextBox)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFMaskedTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.Controls.Add(Data_de_NascimentoLabel)
        Me.Controls.Add(Me.Data_de_NascimentoDateTimePicker)
        Me.Controls.Add(E_mailLabel)
        Me.Controls.Add(Me.E_mailTextBox)
        Me.Controls.Add(Me.FuncionariosDataGridView)
        Me.Controls.Add(Me.FuncionariosBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Funcionario"
        Me.Text = "Funcionários"
        CType(Me.BancodedadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FuncionariosBindingNavigator.ResumeLayout(False)
        Me.FuncionariosBindingNavigator.PerformLayout()
        CType(Me.FuncionariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BancodedadosDataSet As bancodedadosDataSet
    Friend WithEvents FuncionariosBindingSource As BindingSource
    Friend WithEvents FuncionariosTableAdapter As bancodedadosDataSetTableAdapters.funcionariosTableAdapter
    Friend WithEvents TableAdapterManager As bancodedadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FuncionariosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents FuncionariosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FuncionariosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents EndereçoTextBox As TextBox
    Friend WithEvents CPFMaskedTextBox As MaskedTextBox
    Friend WithEvents TelefoneMaskedTextBox As MaskedTextBox
    Friend WithEvents Data_de_NascimentoDateTimePicker As DateTimePicker
    Friend WithEvents E_mailTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
End Class
