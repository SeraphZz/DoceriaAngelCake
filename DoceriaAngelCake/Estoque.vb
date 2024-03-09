Public Class Estoque
    Private Sub EstoqueBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstoqueBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstoqueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancodedadosDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BancodedadosDataSet.estoque'. Você pode movê-la ou removê-la conforme necessário.
        Me.EstoqueTableAdapter.Fill(Me.BancodedadosDataSet.estoque)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EstoqueBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            EstoqueBindingSource.EndEdit()
            EstoqueTableAdapter.Update(bancodedadosDataSet.estoque)
            MessageBox.Show("Alterações Salvas com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Houve um erro ao cadastrar seu produto, por favor tente novamente.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EstoqueBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


End Class