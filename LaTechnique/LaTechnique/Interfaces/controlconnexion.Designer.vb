<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class controlconnexion
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAssuranceMaladie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDossierHopital = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_erreur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 26)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Nom d'utilisateur :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAssuranceMaladie
        '
        Me.txtAssuranceMaladie.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssuranceMaladie.Location = New System.Drawing.Point(376, 171)
        Me.txtAssuranceMaladie.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAssuranceMaladie.Name = "txtAssuranceMaladie"
        Me.txtAssuranceMaladie.Size = New System.Drawing.Size(216, 32)
        Me.txtAssuranceMaladie.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(217, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 26)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Mot de passe :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDossierHopital
        '
        Me.txtDossierHopital.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDossierHopital.Location = New System.Drawing.Point(376, 221)
        Me.txtDossierHopital.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDossierHopital.Name = "txtDossierHopital"
        Me.txtDossierHopital.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDossierHopital.Size = New System.Drawing.Size(216, 32)
        Me.txtDossierHopital.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 26)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Connexion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 42)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Se connecter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_erreur
        '
        Me.lbl_erreur.AutoSize = True
        Me.lbl_erreur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_erreur.ForeColor = System.Drawing.Color.Red
        Me.lbl_erreur.Location = New System.Drawing.Point(266, 149)
        Me.lbl_erreur.Name = "lbl_erreur"
        Me.lbl_erreur.Size = New System.Drawing.Size(391, 20)
        Me.lbl_erreur.TabIndex = 62
        Me.lbl_erreur.Text = "Le mdp ou le nom d'utilisateur peuvent être mal entrer."
        Me.lbl_erreur.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_erreur.Visible = False
        '
        'controlconnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_erreur)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAssuranceMaladie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDossierHopital)
        Me.Name = "controlconnexion"
        Me.Size = New System.Drawing.Size(813, 433)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtAssuranceMaladie As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDossierHopital As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_erreur As Label
End Class
