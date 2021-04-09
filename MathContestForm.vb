'Spencer Gilchrist
'RCET 0265
'8:03 am 3-5-20
'Math Contest
Public Class MathContestForm
    Dim CorrectAnswer As Integer = 0
    Dim WrongAnswer As Integer = 0
    Sub Startup() Handles Me.Activated
        AgeNumericUpDown.Minimum = 4
        GradeNumericUpDown.Minimum = 1
        AgeNumericUpDown.Maximum = 11
        GradeNumericUpDown.Maximum = 7
        AddRadioButton.Checked = True
        FirstNumberTextBox.Enabled = False
        SecondNumberTextBox.Enabled = False
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    Function Validation() As Boolean
        Dim Status As Boolean = False

        'This looks to see if there is any empty fields and promts the user
        'I know this looks bad but it works so... yeah.
        If StudentNameTextBox.Text = "" Then
            Status = False
        Else
            Status = True
        End If
        Return Status
    End Function

    Private Sub OutputFormatForm_Load(Sender As Object, e As EventArgs) Handles Me.Load
        If Validation() = False Then
            SubmitButton.Enabled = False
        Else
            SubmitButton.Enabled = True
        End If
    End Sub

    Private Sub StudentNameTextBox_Leave(sender As Object, e As EventArgs) Handles StudentNameTextBox.Leave
        If Validation() = False Then
            SubmitButton.Enabled = False
        Else
            SubmitButton.Enabled = True
        End If
    End Sub

    Private Sub StrudentAnswerTextBox_Leave(sender As Object, e As EventArgs)
        If Validation() = False Then
            SubmitButton.Enabled = False
        Else
            SubmitButton.Enabled = True
        End If
    End Sub

    Private Sub FirstNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNumberTextBox.TextChanged
        FirstNumberTextBox.Text = CInt(Int((12 * Rnd() * +1)))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FirstNumberTextBox.Text = CInt(Int((12 * Rnd() * +1)))
        SecondNumberTextBox.Text = CInt(Int((12 * Rnd() * +1)))
        Button1.Enabled = False

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        Dim StudentAnswer As Integer
        FirstNumber = FirstNumberTextBox.Text
        SecondNumber = SecondNumberTextBox.Text
        StudentAnswer = StudentAnswerNumericUpDown.Value

        If AddRadioButton.Checked = True Then
            If StudentAnswer = (FirstNumber + SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber + SecondNumber}")
                CorrectAnswer = (CorrectAnswer + 1)
                Button1.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber + SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber + SecondNumber}")
                WrongAnswer = (WrongAnswer + 1)
                Button1.Enabled = True
            Else
                MsgBox("Something wierd happened")
            End If

        End If

        If SubtractRadioButton.Checked = True Then
            If StudentAnswer = (FirstNumber - SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber - SecondNumber}")
                CorrectAnswer = (CorrectAnswer + 1)
                Button1.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber - SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber - SecondNumber}")
                WrongAnswer = (WrongAnswer + 1)
                Button1.Enabled = True
            Else
                MsgBox("Something wierd happened")
            End If
        End If

        If MultiplyRadioButton.Checked = True Then
            If StudentAnswer = (FirstNumber * SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber * SecondNumber}")
                CorrectAnswer = (CorrectAnswer + 1)
                Button1.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber * SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber * SecondNumber}")
                WrongAnswer = (WrongAnswer + 1)
                Button1.Enabled = True
            Else
                MsgBox("Something wierd happened")
            End If
        End If

        If DivideRadioButton.Checked = True Then
            If StudentAnswer = (FirstNumber / SecondNumber) Then
                MsgBox($"Correct! the answer was {FirstNumber / SecondNumber}")
                CorrectAnswer = (CorrectAnswer + 1)
                Button1.Enabled = True
            ElseIf StudentAnswer <> (FirstNumber / SecondNumber) Then
                MsgBox($"Sorry, But the answer was {FirstNumber / SecondNumber}")
                WrongAnswer = (WrongAnswer + 1)
                Button1.Enabled = True
            Else
                MsgBox("Something wierd happened")
            End If
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        StudentNameTextBox.Text = ""
        FirstNumberTextBox.Text = 0
        SecondNumberTextBox.Text = 0
        StudentAnswerNumericUpDown.Value = 0
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

        MsgBox($"You got {CorrectAnswer} correct and {WrongAnswer} Wrong.")


    End Sub
End Class