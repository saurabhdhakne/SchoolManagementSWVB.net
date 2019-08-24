Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\acer\documents\visual studio 2013\Projects\SchoolLogin\SchoolLogin\Database1.mdf';Integrated Security=True")
        'Dim cmd As SqlCommand = New SqlCommand("Select * From login where username ='" & txtUser.Text & "'  and password = '" & txtPassword.Text & "' and usertype = '" & cmbUserType.SelectedItem & "' ", con)
        'Dim Sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        'Dim dt As DataTable = New DataTable()
        'Sda.Fill(dt)
        ' If (dt.Rows.Count > 0) Then
        'MsgBox("You are Login as ", +dt.Rows(0)(2))
        'Else
        'MsgBox("Error")

        'End If
        If txtUser.Text = "user" And txtPassword.Text = "123" Then
            MsgBox("Login as User.")
            Dim a As New mainInterface
            a.Show()
            Me.Hide()

        ElseIf txtUser.Text = "admin" And txtPassword.Text = "123" Then
            MsgBox("Login As Admin")
            Dim a As New adminPanel
            a.Show()
            Me.Hide()

        Else
            MsgBox("Check Username and Password")

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtPassword.Text = ""
        txtUser.Text = ""
    End Sub
End Class
