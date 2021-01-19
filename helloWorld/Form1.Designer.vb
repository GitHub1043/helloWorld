<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnEnglish = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnGreek = New System.Windows.Forms.Button()
        Me.btnFrench = New System.Windows.Forms.Button()
        Me.picFlag = New System.Windows.Forms.PictureBox()
        CType(Me.picFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnglish
        '
        Me.btnEnglish.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEnglish.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnglish.Location = New System.Drawing.Point(0, 0)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(134, 75)
        Me.btnEnglish.TabIndex = 0
        Me.btnEnglish.Text = "English"
        Me.btnEnglish.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(429, 103)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(95, 31)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Label1"
        '
        'btnGreek
        '
        Me.btnGreek.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGreek.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGreek.Location = New System.Drawing.Point(0, 162)
        Me.btnGreek.Name = "btnGreek"
        Me.btnGreek.Size = New System.Drawing.Size(134, 75)
        Me.btnGreek.TabIndex = 2
        Me.btnGreek.Text = "Greek"
        Me.btnGreek.UseVisualStyleBackColor = False
        '
        'btnFrench
        '
        Me.btnFrench.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnFrench.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrench.Location = New System.Drawing.Point(0, 81)
        Me.btnFrench.Name = "btnFrench"
        Me.btnFrench.Size = New System.Drawing.Size(134, 75)
        Me.btnFrench.TabIndex = 3
        Me.btnFrench.Text = "French"
        Me.btnFrench.UseVisualStyleBackColor = False
        '
        'picFlag
        '
        Me.picFlag.Location = New System.Drawing.Point(900, 12)
        Me.picFlag.Name = "picFlag"
        Me.picFlag.Size = New System.Drawing.Size(247, 132)
        Me.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFlag.TabIndex = 4
        Me.picFlag.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 446)
        Me.Controls.Add(Me.picFlag)
        Me.Controls.Add(Me.btnFrench)
        Me.Controls.Add(Me.btnGreek)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnEnglish)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnglish As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnGreek As System.Windows.Forms.Button
    Friend WithEvents btnFrench As System.Windows.Forms.Button
    Friend WithEvents picFlag As System.Windows.Forms.PictureBox

End Class
