Public Class frm_map

    Public Sub frm_map_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' this seems to crash/break after 99x99... I can't do this sadly... too bad...

        Dim cur_x As Integer = 0
        Dim cur_y As Integer = 0

        For b_y As Integer = 0 To 98

            For b_x As Integer = 0 To 98

                Dim b As New Button
                b.Name = "btn_" + b_x.ToString + "_" + b_y.ToString
                b.Size = New Size(16, 16)
                b.Image = New System.Drawing.Bitmap(My.Resources._invalid)
                ' b.FlatStyle = FlatStyle.Flat
                b.Text = New String("")
                b.Location = New Point(cur_x, cur_y)
                pnl_main.Controls.Add(b)
                If b_x = 98 Then
                    cur_x = 0
                    cur_y += 16
                Else
                    cur_x += 16
                End If

            Next
        Next
    End Sub

End Class