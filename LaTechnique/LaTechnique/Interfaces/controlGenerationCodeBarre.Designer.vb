<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlGenerationCodeBarre
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.codeBarre = New System.Windows.Forms.PictureBox()
        Me.txtSaisie = New System.Windows.Forms.TextBox()
        Me.btnGenererCode = New System.Windows.Forms.Button()
        Me.lblIDCode = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.codeBarre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'codeBarre
        '
        Me.codeBarre.BackColor = System.Drawing.Color.White
        Me.codeBarre.Location = New System.Drawing.Point(197, 98)
        Me.codeBarre.Name = "codeBarre"
        Me.codeBarre.Size = New System.Drawing.Size(647, 133)
        Me.codeBarre.TabIndex = 0
        Me.codeBarre.TabStop = False
        '
        'txtSaisie
        '
        Me.txtSaisie.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaisie.Location = New System.Drawing.Point(197, 288)
        Me.txtSaisie.Name = "txtSaisie"
        Me.txtSaisie.Size = New System.Drawing.Size(647, 62)
        Me.txtSaisie.TabIndex = 1
        Me.txtSaisie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGenererCode
        '
        Me.btnGenererCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenererCode.Location = New System.Drawing.Point(197, 356)
        Me.btnGenererCode.Name = "btnGenererCode"
        Me.btnGenererCode.Size = New System.Drawing.Size(647, 62)
        Me.btnGenererCode.TabIndex = 2
        Me.btnGenererCode.Text = "Générer le code"
        Me.btnGenererCode.UseVisualStyleBackColor = True
        '
        'lblIDCode
        '
        Me.lblIDCode.AutoSize = True
        Me.lblIDCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblIDCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDCode.Location = New System.Drawing.Point(3, 16)
        Me.lblIDCode.Name = "lblIDCode"
        Me.lblIDCode.Size = New System.Drawing.Size(0, 39)
        Me.lblIDCode.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblIDCode)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 65)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'controlGenerationCodeBarre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGenererCode)
        Me.Controls.Add(Me.txtSaisie)
        Me.Controls.Add(Me.codeBarre)
        Me.Name = "controlGenerationCodeBarre"
        Me.Size = New System.Drawing.Size(1021, 600)
        CType(Me.codeBarre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents codeBarre As PictureBox
    Friend WithEvents txtSaisie As TextBox
    Friend WithEvents btnGenererCode As Button
    Friend WithEvents lblIDCode As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
