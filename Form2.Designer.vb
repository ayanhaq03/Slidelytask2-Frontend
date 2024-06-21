<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label5 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        Nextbtn = New Button()
        Prevbtn = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Indigo
        Label5.Location = New Point(173, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 40)
        Label5.TabIndex = 39
        Label5.Text = "Stopwatch" & vbCrLf & "timer"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Gainsboro
        TextBox5.Location = New Point(295, 303)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(334, 27)
        TextBox5.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(153, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(507, 26)
        Label6.TabIndex = 37
        Label6.Text = "Mohd Ayan Haque , Slidely Task 2 - View Submission"
        ' 
        ' Nextbtn
        ' 
        Nextbtn.BackColor = Color.DarkViolet
        Nextbtn.ForeColor = Color.White
        Nextbtn.Location = New Point(452, 363)
        Nextbtn.Name = "Nextbtn"
        Nextbtn.Size = New Size(177, 47)
        Nextbtn.TabIndex = 36
        Nextbtn.Text = "NEXT"
        Nextbtn.UseVisualStyleBackColor = False
        ' 
        ' Prevbtn
        ' 
        Prevbtn.BackColor = Color.White
        Prevbtn.ForeColor = Color.Indigo
        Prevbtn.Location = New Point(171, 363)
        Prevbtn.Name = "Prevbtn"
        Prevbtn.Size = New Size(167, 47)
        Prevbtn.TabIndex = 35
        Prevbtn.Text = "PREVIOUS"
        Prevbtn.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Gainsboro
        TextBox4.Location = New Point(295, 244)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(334, 27)
        TextBox4.TabIndex = 34
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Gainsboro
        TextBox3.Location = New Point(295, 187)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(334, 27)
        TextBox3.TabIndex = 33
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gainsboro
        TextBox2.Location = New Point(295, 132)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(334, 27)
        TextBox2.TabIndex = 32
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Indigo
        Label4.Location = New Point(171, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 40)
        Label4.TabIndex = 31
        Label4.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Indigo
        Label3.Location = New Point(171, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 30
        Label3.Text = "Phone Num."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Indigo
        Label2.Location = New Point(171, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 29
        Label2.Text = "Email "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Indigo
        Label1.Location = New Point(171, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 28
        Label1.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gainsboro
        TextBox1.Location = New Point(295, 75)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(334, 27)
        TextBox1.TabIndex = 27
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(Nextbtn)
        Controls.Add(Prevbtn)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Nextbtn As Button
    Friend WithEvents Prevbtn As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
