<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AgeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.MathGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.ControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.StudentInfoGroupBox.SuspendLayout()
        CType(Me.GradeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MathGroupBox.SuspendLayout()
        CType(Me.StudentAnswerNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProblemGroupBox.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeNumericUpDown)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeNumericUpDown)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.StudentNameTextBox)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(18, 12)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(438, 96)
        Me.StudentInfoGroupBox.TabIndex = 0
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'GradeNumericUpDown
        '
        Me.GradeNumericUpDown.Location = New System.Drawing.Point(384, 64)
        Me.GradeNumericUpDown.Name = "GradeNumericUpDown"
        Me.GradeNumericUpDown.Size = New System.Drawing.Size(48, 26)
        Me.GradeNumericUpDown.TabIndex = 7
        '
        'AgeNumericUpDown
        '
        Me.AgeNumericUpDown.Location = New System.Drawing.Point(308, 63)
        Me.AgeNumericUpDown.Name = "AgeNumericUpDown"
        Me.AgeNumericUpDown.Size = New System.Drawing.Size(57, 26)
        Me.AgeNumericUpDown.TabIndex = 6
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(380, 37)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(54, 20)
        Me.GradeLabel.TabIndex = 5
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(320, 37)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 40)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(112, 20)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Student Name"
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.Location = New System.Drawing.Point(6, 63)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(248, 26)
        Me.StudentNameTextBox.TabIndex = 0
        '
        'MathGroupBox
        '
        Me.MathGroupBox.Controls.Add(Me.StudentAnswerNumericUpDown)
        Me.MathGroupBox.Controls.Add(Me.AnswerLabel)
        Me.MathGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.MathGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.MathGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.MathGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.MathGroupBox.Location = New System.Drawing.Point(18, 127)
        Me.MathGroupBox.Name = "MathGroupBox"
        Me.MathGroupBox.Size = New System.Drawing.Size(259, 296)
        Me.MathGroupBox.TabIndex = 1
        Me.MathGroupBox.TabStop = False
        Me.MathGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerNumericUpDown
        '
        Me.StudentAnswerNumericUpDown.DecimalPlaces = 2
        Me.StudentAnswerNumericUpDown.Location = New System.Drawing.Point(6, 208)
        Me.StudentAnswerNumericUpDown.Name = "StudentAnswerNumericUpDown"
        Me.StudentAnswerNumericUpDown.Size = New System.Drawing.Size(248, 26)
        Me.StudentAnswerNumericUpDown.TabIndex = 6
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(13, 185)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(123, 20)
        Me.AnswerLabel.TabIndex = 5
        Me.AnswerLabel.Text = "Student Answer"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(13, 107)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(96, 20)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(13, 34)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(91, 20)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(7, 130)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(247, 26)
        Me.SecondNumberTextBox.TabIndex = 1
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(9, 56)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(243, 26)
        Me.FirstNumberTextBox.TabIndex = 0
        '
        'ProblemGroupBox
        '
        Me.ProblemGroupBox.Controls.Add(Me.Label1)
        Me.ProblemGroupBox.Controls.Add(Me.Button1)
        Me.ProblemGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.ProblemGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.ProblemGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.ProblemGroupBox.Controls.Add(Me.AddRadioButton)
        Me.ProblemGroupBox.Location = New System.Drawing.Point(289, 135)
        Me.ProblemGroupBox.Name = "ProblemGroupBox"
        Me.ProblemGroupBox.Size = New System.Drawing.Size(167, 288)
        Me.ProblemGroupBox.TabIndex = 2
        Me.ProblemGroupBox.TabStop = False
        Me.ProblemGroupBox.Text = "Math Problem Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Get Numbers"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(17, 138)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(77, 24)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(17, 108)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(86, 24)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(17, 78)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(95, 24)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(17, 48)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(63, 24)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'ControlsGroupBox
        '
        Me.ControlsGroupBox.Controls.Add(Me.ExitButton)
        Me.ControlsGroupBox.Controls.Add(Me.SummaryButton)
        Me.ControlsGroupBox.Controls.Add(Me.ClearButton)
        Me.ControlsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ControlsGroupBox.Location = New System.Drawing.Point(474, 12)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(306, 410)
        Me.ControlsGroupBox.TabIndex = 3
        Me.ControlsGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(29, 311)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(244, 88)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(29, 217)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(244, 88)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(29, 123)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(244, 88)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(29, 27)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(244, 88)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'MathContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ControlsGroupBox)
        Me.Controls.Add(Me.ProblemGroupBox)
        Me.Controls.Add(Me.MathGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Name = "MathContestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Math Contest"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        CType(Me.GradeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MathGroupBox.ResumeLayout(False)
        Me.MathGroupBox.PerformLayout()
        CType(Me.StudentAnswerNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProblemGroupBox.ResumeLayout(False)
        Me.ProblemGroupBox.PerformLayout()
        Me.ControlsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents StudentNameTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents MathGroupBox As GroupBox
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents ProblemGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents ControlsGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents AgeNumericUpDown As NumericUpDown
    Friend WithEvents GradeNumericUpDown As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents StudentAnswerNumericUpDown As NumericUpDown
End Class
