Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If RadioButton1.Checked Then
            TextBox1.Text = "2KQT8-HV27P-GTTV9-2WBVV-M7X96"
        ElseIf RadioButton2.Checked Then
            TextBox1.Text = "PQT8W-68YB2-MPY6C-9JV9X-42WJV"
        ElseIf RadioButton3.Checked Then
            TextBox1.Text = "6VPJ7-H3CXH-HBTPT-X4T74-3YVY7"
        ElseIf RadioButton4.Checked Then
            TextBox1.Text = "CY8XP-83P66-WCF9D-G3P42-K2VG3"
        End If
    End Sub

End Class
