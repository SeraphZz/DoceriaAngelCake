<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estoque
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
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim ValidadeLabel As System.Windows.Forms.Label
        Dim PreçoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estoque))
        Me.BancodedadosDataSet = New DoceriaAngelCake.bancodedadosDataSet()
        Me.EstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstoqueTableAdapter = New DoceriaAngelCake.bancodedadosDataSetTableAdapters.estoqueTableAdapter()
        Me.TableAdapterManager = New DoceriaAngelCake.bancodedadosDataSetTableAdapters.TableAdapterManager()
        Me.EstoqueBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EstoqueBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EstoqueDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.QuantidadeTextBox = New System.Windows.Forms.TextBox()
        Me.ValidadeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PreçoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        QuantidadeLabel = New System.Windows.Forms.Label()
        ValidadeLabel = New System.Windows.Forms.Label()
        PreçoLabel = New System.Windows.Forms.Label()
        CType(Me.BancodedadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstoqueBindingNavigator.SuspendLayout()
        CType(Me.EstoqueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(10, 154)
        NomeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 2
        NomeLabel.Text = "Nome:"
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Location = New System.Drawing.Point(10, 177)
        QuantidadeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(65, 13)
        QuantidadeLabel.TabIndex = 4
        QuantidadeLabel.Text = "Quantidade:"
        '
        'ValidadeLabel
        '
        ValidadeLabel.AutoSize = True
        ValidadeLabel.Location = New System.Drawing.Point(10, 200)
        ValidadeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ValidadeLabel.Name = "ValidadeLabel"
        ValidadeLabel.Size = New System.Drawing.Size(51, 13)
        ValidadeLabel.TabIndex = 6
        ValidadeLabel.Text = "Validade:"
        '
        'PreçoLabel
        '
        PreçoLabel.AutoSize = True
        PreçoLabel.Location = New System.Drawing.Point(10, 222)
        PreçoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PreçoLabel.Name = "PreçoLabel"
        PreçoLabel.Size = New System.Drawing.Size(38, 13)
        PreçoLabel.TabIndex = 8
        PreçoLabel.Text = "Preço:"
        '
        'BancodedadosDataSet
        '
        Me.BancodedadosDataSet.DataSetName = "bancodedadosDataSet"
        Me.BancodedadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstoqueBindingSource
        '
        Me.EstoqueBindingSource.DataMember = "estoque"
        Me.EstoqueBindingSource.DataSource = Me.BancodedadosDataSet
        '
        'EstoqueTableAdapter
        '
        Me.EstoqueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.estoqueTableAdapter = Me.EstoqueTableAdapter
        Me.TableAdapterManager.funcionariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DoceriaAngelCake.bancodedadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EstoqueBindingNavigator
        '
        Me.EstoqueBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EstoqueBindingNavigator.BindingSource = Me.EstoqueBindingSource
        Me.EstoqueBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EstoqueBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EstoqueBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EstoqueBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EstoqueBindingNavigatorSaveItem})
        Me.EstoqueBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EstoqueBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EstoqueBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EstoqueBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EstoqueBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EstoqueBindingNavigator.Name = "EstoqueBindingNavigator"
        Me.EstoqueBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EstoqueBindingNavigator.Size = New System.Drawing.Size(610, 22)
        Me.EstoqueBindingNavigator.TabIndex = 0
        Me.EstoqueBindingNavigator.Text = "BindingNavigator1"
        Me.EstoqueBindingNavigator.Visible = False
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
        'EstoqueBindingNavigatorSaveItem
        '
        Me.EstoqueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EstoqueBindingNavigatorSaveItem.Image = CType(resources.GetObject("EstoqueBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EstoqueBindingNavigatorSaveItem.Name = "EstoqueBindingNavigatorSaveItem"
        Me.EstoqueBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 19)
        Me.EstoqueBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'EstoqueDataGridView
        '
        Me.EstoqueDataGridView.AutoGenerateColumns = False
        Me.EstoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstoqueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.EstoqueDataGridView.DataSource = Me.EstoqueBindingSource
        Me.EstoqueDataGridView.Location = New System.Drawing.Point(213, 26)
        Me.EstoqueDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.EstoqueDataGridView.Name = "EstoqueDataGridView"
        Me.EstoqueDataGridView.RowHeadersWidth = 51
        Me.EstoqueDataGridView.RowTemplate.Height = 24
        Me.EstoqueDataGridView.Size = New System.Drawing.Size(387, 353)
        Me.EstoqueDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Quantidade"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Validade"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Validade"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Preço"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Preço"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(80, 151)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(129, 20)
        Me.NomeTextBox.TabIndex = 3
        '
        'QuantidadeTextBox
        '
        Me.QuantidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Quantidade", True))
        Me.QuantidadeTextBox.Location = New System.Drawing.Point(80, 174)
        Me.QuantidadeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QuantidadeTextBox.Name = "QuantidadeTextBox"
        Me.QuantidadeTextBox.Size = New System.Drawing.Size(129, 20)
        Me.QuantidadeTextBox.TabIndex = 5
        '
        'ValidadeDateTimePicker
        '
        Me.ValidadeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EstoqueBindingSource, "Validade", True))
        Me.ValidadeDateTimePicker.Location = New System.Drawing.Point(80, 197)
        Me.ValidadeDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.ValidadeDateTimePicker.Name = "ValidadeDateTimePicker"
        Me.ValidadeDateTimePicker.Size = New System.Drawing.Size(129, 20)
        Me.ValidadeDateTimePicker.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 257)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 44)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Novo Produto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(120, 257)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 44)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Salvar Alterações"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(60, 306)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 35)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Remover Produto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(31, 26)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 19)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Voltar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PreçoMaskedTextBox
        '
        Me.PreçoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Preço", True))
        Me.PreçoMaskedTextBox.Location = New System.Drawing.Point(80, 222)
        Me.PreçoMaskedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PreçoMaskedTextBox.Mask = "$ 00.00"
        Me.PreçoMaskedTextBox.Name = "PreçoMaskedTextBox"
        Me.PreçoMaskedTextBox.Size = New System.Drawing.Size(129, 20)
        Me.PreçoMaskedTextBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 36)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Estoque"
        '
        'Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PreçoMaskedTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(QuantidadeLabel)
        Me.Controls.Add(Me.QuantidadeTextBox)
        Me.Controls.Add(ValidadeLabel)
        Me.Controls.Add(Me.ValidadeDateTimePicker)
        Me.Controls.Add(PreçoLabel)
        Me.Controls.Add(Me.EstoqueDataGridView)
        Me.Controls.Add(Me.EstoqueBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Estoque"
        Me.Text = "Estoque"
        CType(Me.BancodedadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstoqueBindingNavigator.ResumeLayout(False)
        Me.EstoqueBindingNavigator.PerformLayout()
        CType(Me.EstoqueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BancodedadosDataSet As bancodedadosDataSet
    Friend WithEvents EstoqueBindingSource As BindingSource
    Friend WithEvents EstoqueTableAdapter As bancodedadosDataSetTableAdapters.estoqueTableAdapter
    Friend WithEvents TableAdapterManager As bancodedadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstoqueBindingNavigator As BindingNavigator
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
    Friend WithEvents EstoqueBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EstoqueDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents QuantidadeTextBox As TextBox
    Friend WithEvents ValidadeDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PreçoMaskedTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
End Class
