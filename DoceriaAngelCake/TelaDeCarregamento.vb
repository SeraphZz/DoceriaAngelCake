Public Class TelaDeCarregamento

    Private Sub TelaDeCarregamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With ProgressBar1
            If .Value < 100 Then
                .Value += 5
            Else
                .Value = 100
            End If
            If .Value = 100 Then
                Timer1.Enabled = False
                Me.Close()
            End If
        End With
    End Sub

End Class