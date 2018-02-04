<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlIdentification
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblValide = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.14677!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.572474!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.15593!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.11294!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.011889!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNum, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblValide, 2, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.71847!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.928154!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22764!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.72358!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.928154!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1134, 612)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(896, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Se déconnecter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(896, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 54)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Générer un code barre"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(248, 308)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(642, 62)
        Me.txtNum.TabIndex = 0
        Me.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblValide
        '
        Me.lblValide.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValide.AutoSize = True
        Me.lblValide.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValide.ForeColor = System.Drawing.Color.Red
        Me.lblValide.Location = New System.Drawing.Point(248, 375)
        Me.lblValide.Name = "lblValide"
        Me.lblValide.Size = New System.Drawing.Size(642, 39)
        Me.lblValide.TabIndex = 3
        Me.lblValide.Text = "Invalide"
        Me.lblValide.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblValide.Visible = False
        '
        'controlIdentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "controlIdentification"
        Me.Size = New System.Drawing.Size(1134, 612)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblValide As Label
End Class
