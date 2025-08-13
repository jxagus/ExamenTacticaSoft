Public Class frmSalir
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSI.Click
        Me.DialogResult = DialogResult.Yes
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.DialogResult = DialogResult.No
    End Sub

End Class