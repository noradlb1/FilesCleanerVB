Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FileClinerGuna2GradientButton2.Click
        If FileClinertempcheckbox.Checked = True Then
            Try
                CleanTemp()
                CleanAppDataTemp()
            Catch

            End Try
        End If

        If FileClinerprefetchcheckbox.Checked = True Then
            Try
                CleanPrefetch()
            Catch
            End Try
        End If
        If FileClinerjavacachecheckbox.Checked = True Then
            Try
                CleanJava()
            Catch
            End Try
        End If
        If FileClinerrecyclebincheckbox.Checked = True Then
            Try
                EmptyRecycleBin()
            Catch
            End Try
        End If
    End Sub
End Class
