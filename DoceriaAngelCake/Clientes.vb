Public Class Clientes
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancodedadosDataSet)

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BancodedadosDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClienteTableAdapter.Fill(Me.BancodedadosDataSet.cliente)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClienteBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ClienteBindingSource.EndEdit()
            ClienteTableAdapter.Update(BancodedadosDataSet.cliente)
            MessageBox.Show("Alterações Salvas com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Houve um erro ao cadastrar o cliente, tente novamente.")

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClienteBindingSource.RemoveCurrent()
    End Sub
End Class