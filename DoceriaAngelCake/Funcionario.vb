Public Class Funcionario


    Private Sub Funcionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BancodedadosDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
        Me.FuncionariosTableAdapter.Fill(Me.BancodedadosDataSet.funcionarios)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FuncionariosBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            FuncionariosBindingSource.EndEdit()
            FuncionariosTableAdapter.Update(BancodedadosDataSet.funcionarios)
            MessageBox.Show("Alterações Salvas com Sucesso!")
        Catch ex As Exception
            MessageBox.Show("Houve um erro ao cadastrar o Funcionário, tente novamente.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FuncionariosBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class