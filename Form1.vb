Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim enteredUser As String = txtUN.Text
        Dim enteredPass As String = txtPW.Text

        Dim validUsername As String = Form2.Username
        Dim validPass As String = Form2.Password



        If String.IsNullOrEmpty(enteredUser) OrElse String.IsNullOrEmpty(enteredPass) Then
            MessageBox.Show("Please Input both Username and Password!", "Try Again", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtUN.Clear()
            txtPW.Clear()

        ElseIf enteredUser = validUsername AndAlso enteredPass = validPass Then

            MessageBox.Show("Successfully Login!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form3.Show() ' Show next form on successful login
            Me.Hide()
            txtUN.Clear()
            txtPW.Clear()
        Else
            MessageBox.Show("Invalid Username or Password", "Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUN.Clear()
            txtPW.Clear()

        End If


    End Sub

    Private Sub txtUN_TextChanged(sender As Object, e As EventArgs) Handles txtUN.TextChanged

    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class
