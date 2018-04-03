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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MultiColumnCombo4 = New MultiColumnComboBox.MultiColumnCombo()
        Me.MultiColumnCombo3 = New MultiColumnComboBox.MultiColumnCombo()
        Me.MultiColumnCombo2 = New MultiColumnComboBox.MultiColumnCombo()
        Me.MultiColumnCombo1 = New MultiColumnComboBox.MultiColumnCombo()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Two Column"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Three Column"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Default Combo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(281, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(281, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(286, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Usage : ""ColumnName:Width;Column:Width"""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Usage : ""ColumnName:Width"""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Background Color Combo"
        '
        'MultiColumnCombo4
        '
        Me.MultiColumnCombo4.BackGroundDarkColor = System.Drawing.SystemColors.Highlight
        Me.MultiColumnCombo4.BackGroundLightColor = System.Drawing.SystemColors.Highlight
        Me.MultiColumnCombo4.ColumnNameList = ""
        Me.MultiColumnCombo4.FormattingEnabled = True
        Me.MultiColumnCombo4.Location = New System.Drawing.Point(22, 249)
        Me.MultiColumnCombo4.Name = "MultiColumnCombo4"
        Me.MultiColumnCombo4.Size = New System.Drawing.Size(236, 24)
        Me.MultiColumnCombo4.TabIndex = 11
        '
        'MultiColumnCombo3
        '
        Me.MultiColumnCombo3.BackGroundDarkColor = System.Drawing.SystemColors.Highlight
        Me.MultiColumnCombo3.BackGroundLightColor = System.Drawing.SystemColors.Highlight
        Me.MultiColumnCombo3.ColumnNameList = ""
        Me.MultiColumnCombo3.FormattingEnabled = True
        Me.MultiColumnCombo3.Location = New System.Drawing.Point(19, 178)
        Me.MultiColumnCombo3.Name = "MultiColumnCombo3"
        Me.MultiColumnCombo3.Size = New System.Drawing.Size(236, 24)
        Me.MultiColumnCombo3.TabIndex = 2
        '
        'MultiColumnCombo2
        '
        Me.MultiColumnCombo2.BackGroundDarkColor = System.Drawing.SystemColors.Highlight
        Me.MultiColumnCombo2.BackGroundLightColor = System.Drawing.SystemColors.Highlight
        Me.MultiColumnCombo2.ColumnNameList = ""
        Me.MultiColumnCombo2.FormattingEnabled = True
        Me.MultiColumnCombo2.Location = New System.Drawing.Point(22, 113)
        Me.MultiColumnCombo2.Name = "MultiColumnCombo2"
        Me.MultiColumnCombo2.Size = New System.Drawing.Size(236, 24)
        Me.MultiColumnCombo2.TabIndex = 1
        '
        'MultiColumnCombo1
        '
        Me.MultiColumnCombo1.BackGroundDarkColor = System.Drawing.SystemColors.Highlight
        Me.MultiColumnCombo1.BackGroundLightColor = System.Drawing.SystemColors.Highlight
        Me.MultiColumnCombo1.ColumnNameList = ""
        Me.MultiColumnCombo1.FormattingEnabled = True
        Me.MultiColumnCombo1.Location = New System.Drawing.Point(22, 51)
        Me.MultiColumnCombo1.Name = "MultiColumnCombo1"
        Me.MultiColumnCombo1.Size = New System.Drawing.Size(236, 24)
        Me.MultiColumnCombo1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 377)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MultiColumnCombo4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MultiColumnCombo3)
        Me.Controls.Add(Me.MultiColumnCombo2)
        Me.Controls.Add(Me.MultiColumnCombo1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MultiColumnCombo1 As MultiColumnCombo
    Friend WithEvents MultiColumnCombo2 As MultiColumnCombo
    Friend WithEvents MultiColumnCombo3 As MultiColumnCombo
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MultiColumnCombo4 As MultiColumnCombo
End Class
