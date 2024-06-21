<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Createsubmission = New Button()
        ViewSubmission = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(165, 142)
        Label1.Name = "Label1"
        Label1.Size = New Size(505, 26)
        Label1.TabIndex = 5
        Label1.Text = "Mohd Ayan Haque , Slidely Task 2 - Slidely Form App"
        ' 
        ' Createsubmission
        ' 
        Createsubmission.BackColor = Color.DarkViolet
        Createsubmission.FlatStyle = FlatStyle.Popup
        Createsubmission.Font = New Font("Yu Gothic", 12F)
        Createsubmission.ForeColor = Color.White
        Createsubmission.Location = New Point(211, 270)
        Createsubmission.Name = "Createsubmission"
        Createsubmission.Size = New Size(404, 52)
        Createsubmission.TabIndex = 4
        Createsubmission.Text = "Create Submission"
        Createsubmission.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmission
        ' 
        ViewSubmission.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ViewSubmission.BackColor = Color.White
        ViewSubmission.FlatStyle = FlatStyle.Popup
        ViewSubmission.Font = New Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ViewSubmission.ForeColor = Color.Indigo
        ViewSubmission.Location = New Point(211, 202)
        ViewSubmission.Name = "ViewSubmission"
        ViewSubmission.Size = New Size(404, 48)
        ViewSubmission.TabIndex = 3
        ViewSubmission.Text = "View Submission"
        ViewSubmission.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.Lavender
        ClientSize = New Size(858, 450)
        Controls.Add(Label1)
        Controls.Add(Createsubmission)
        Controls.Add(ViewSubmission)
        ForeColor = SystemColors.ControlLightLight
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Public WithEvents Createsubmission As Button
    Friend WithEvents ViewSubmission As Button
    Friend WithEvents Panel1 As Panel

End Class
