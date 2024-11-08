Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Public Shared Username As String
    Public Shared Password As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Username = ValidUsername.Text
        Password = ValidPassword.Text
        CreatePass = ValidPassword



        If Not String.IsNullOrEmpty(ValidUsername.Text) AndAlso
           Not String.IsNullOrEmpty(ValidPassword.Text) AndAlso
           Not String.IsNullOrEmpty(LastName.Text) AndAlso
           Not String.IsNullOrEmpty(Firstname.Text) AndAlso
           Not String.IsNullOrEmpty(CreatePass.Text) Then


            If CreatePass.Text = ValidPassword.Text Then
                MessageBox.Show("Sign-up Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                LastName.Clear()
                Firstname.Clear()
                ValidUsername.Clear()
                CreatePass.Clear()
                ValidPassword.Clear()


                Form1.Show()
                Me.Hide()
            Else

                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                CreatePass.Clear()
                ValidPassword.Clear()
            End If

        Else

            MessageBox.Show("Please fill out the entire form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            LastName.Clear()
            Firstname.Clear()
            ValidUsername.Clear()
            CreatePass.Clear()
            ValidPassword.Clear()
        End If





    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class