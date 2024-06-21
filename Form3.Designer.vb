<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Resumebtn = New Button()
        Stopbtn = New Button()
        Startbtn = New Button()
        TextBox5 = New TextBox()
        Label6 = New Label()
        Submitbtn = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Resumebtn
        ' 
        Resumebtn.BackColor = Color.White
        Resumebtn.ForeColor = Color.Indigo
        Resumebtn.Location = New Point(271, 310)
        Resumebtn.Name = "Resumebtn"
        Resumebtn.Size = New Size(94, 29)
        Resumebtn.TabIndex = 30
        Resumebtn.Text = "Resume"
        Resumebtn.UseVisualStyleBackColor = False
        ' 
        ' Stopbtn
        ' 
        Stopbtn.BackColor = Color.DarkViolet
        Stopbtn.ForeColor = Color.White
        Stopbtn.Location = New Point(371, 310)
        Stopbtn.Name = "Stopbtn"
        Stopbtn.Size = New Size(94, 29)
        Stopbtn.TabIndex = 29
        Stopbtn.Text = "Stop"
        Stopbtn.UseVisualStyleBackColor = False
        ' 
        ' Startbtn
        ' 
        Startbtn.BackColor = Color.DarkViolet
        Startbtn.ForeColor = Color.White
        Startbtn.Location = New Point(171, 310)
        Startbtn.Name = "Startbtn"
        Startbtn.Size = New Size(94, 29)
        Startbtn.TabIndex = 28
        Startbtn.Text = "Start"
        Startbtn.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(488, 310)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(141, 27)
        TextBox5.TabIndex = 27
        TextBox5.Text = "00 : 00 : 00"
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(143, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(523, 26)
        Label6.TabIndex = 26
        Label6.Text = "Mohd Ayan Haque , Slidely Task 2 - Create Submission"
        ' 
        ' Submitbtn
        ' 
        Submitbtn.BackColor = Color.DarkViolet
        Submitbtn.ForeColor = Color.White
        Submitbtn.Location = New Point(327, 357)
        Submitbtn.Name = "Submitbtn"
        Submitbtn.Size = New Size(177, 47)
        Submitbtn.TabIndex = 25
        Submitbtn.Text = "SUBMIT"
        Submitbtn.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(295, 238)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(334, 27)
        TextBox4.TabIndex = 24
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(295, 181)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(334, 27)
        TextBox3.TabIndex = 23
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(295, 126)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(334, 27)
        TextBox2.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Indigo
        Label4.Location = New Point(171, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 40)
        Label4.TabIndex = 21
        Label4.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Indigo
        Label3.Location = New Point(171, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 20
        Label3.Text = "Phone Num."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Indigo
        Label2.Location = New Point(171, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 19
        Label2.Text = "Email "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Indigo
        Label1.Location = New Point(171, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 18
        Label1.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(295, 69)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(334, 27)
        TextBox1.TabIndex = 17
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(800, 450)
        Controls.Add(Resumebtn)
        Controls.Add(Stopbtn)
        Controls.Add(Startbtn)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(Submitbtn)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Resumebtn As Button
    Friend WithEvents Stopbtn As Button
    Friend WithEvents Startbtn As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Submitbtn As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
End Class
