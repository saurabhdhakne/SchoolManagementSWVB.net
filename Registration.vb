Imports System.Data.SqlClient


Public Class Registration

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Try
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\acer\documents\visual studio 2013\Projects\SchoolLogin\SchoolLogin\Students.mdf;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from student where username='" & txtUser.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Username  is  Already Registered", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()

            cmd = New SqlCommand("insert into student (name, username, mobile, email, password) values ('" & txtName.Text & "','" & txtUser.Text & "','" & txtMobile.Text & "','" & txtEmail.Text & "','" & txtPass.Text & "')", con)

            If (txtName.Text = "" And txtUser.Text = "" And txtMobile.Text = "" And txtMobile.Text = "" And txtPass.Text = "") Then
                MessageBox.Show("Please enter the details")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                Me.Hide()

                txtName.Clear()
                txtUser.Clear()
                txtMobile.Clear()
                txtEmail.Clear()
                txtPass.Clear()

            End If
            con.Close()
        End If
        con.Close()
        'Catch ex As Exception
        'MsgBox("Error")
        'End Try
    End Sub

    Private Sub txtMobile_TextChanged(sender As Object, e As EventArgs) Handles txtMobile.TextChanged

    End Sub

    Private Sub txtClear_Click(sender As Object, e As EventArgs) Handles txtClear.Click

        txtName.Clear()
        txtUser.Clear()
        txtMobile.Clear()
        txtEmail.Clear()
        txtPass.Clear()

    End Sub
End Class