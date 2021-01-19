Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMessage.Text = "Ayden Holgate"
        lblMessage.Text = "Hello World"
        'Hello World replaces the name
        lblMessage.ForeColor = Color.Blue
        lblMessage.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btnEnglish.Click
        lblMessage.Text = "Ayden Holgate"
        lblMessage.Text = "Hello World"
        'Hello World replaces the name
        lblMessage.ForeColor = Color.Blue
        lblMessage.BackColor = Color.BlanchedAlmond
        picFlag.Image = My.Resources.canadianFlag
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGreek.Click
        lblMessage.Text = "Ayden Holgate"
        lblMessage.Text = "Γειά σου Κόσμε"
        'Hello World replaces the name
        lblMessage.ForeColor = Color.Blue
        lblMessage.BackColor = Color.BlanchedAlmond
        picFlag.Image = My.Resources.greekFlag
    End Sub

    Private Sub btnFrench_Click(sender As Object, e As EventArgs) Handles btnFrench.Click
        lblMessage.Text = "Ayden Holgate"
        lblMessage.Text = "Bonjour le monde"
        'Hello World replaces the name
        lblMessage.ForeColor = Color.Blue
        lblMessage.BackColor = Color.BlanchedAlmond
        picFlag.Image = My.Resources.franceFlag
    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub
End Class
