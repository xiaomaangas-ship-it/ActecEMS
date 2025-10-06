Public Class SplashScreen

    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProgressBar1.Value = 0
        Timerprgbar.Interval = 1000 ' 1 second
        Timerprgbar.Start()
    End Sub
    Private Sub Timerprgbar_Tick(sender As Object, e As EventArgs) Handles Timerprgbar.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 20
        Else
            Timerprgbar.Stop()
            Me.Hide()
            Formlgn.Show()
        End If
    End Sub

End Class
