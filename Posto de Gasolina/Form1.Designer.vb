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
        Me.LblAlcool = New System.Windows.Forms.Label()
        Me.LblGasolina = New System.Windows.Forms.Label()
        Me.btncaldesc = New System.Windows.Forms.Button()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.Txtalcool = New System.Windows.Forms.TextBox()
        Me.Txtgasolina = New System.Windows.Forms.TextBox()
        Me.Lbldesconto = New System.Windows.Forms.Label()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.Lbldesc = New System.Windows.Forms.Label()
        Me.LblvalorTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblAlcool
        '
        Me.LblAlcool.AutoSize = True
        Me.LblAlcool.Location = New System.Drawing.Point(40, 28)
        Me.LblAlcool.Name = "LblAlcool"
        Me.LblAlcool.Size = New System.Drawing.Size(36, 13)
        Me.LblAlcool.TabIndex = 0
        Me.LblAlcool.Text = "Álcool"
        '
        'LblGasolina
        '
        Me.LblGasolina.AutoSize = True
        Me.LblGasolina.Location = New System.Drawing.Point(40, 84)
        Me.LblGasolina.Name = "LblGasolina"
        Me.LblGasolina.Size = New System.Drawing.Size(48, 13)
        Me.LblGasolina.TabIndex = 1
        Me.LblGasolina.Text = "Gasolina"
        '
        'btncaldesc
        '
        Me.btncaldesc.Location = New System.Drawing.Point(40, 273)
        Me.btncaldesc.Name = "btncaldesc"
        Me.btncaldesc.Size = New System.Drawing.Size(119, 23)
        Me.btncaldesc.TabIndex = 4
        Me.btncaldesc.Text = "Calcular Desconto"
        Me.btncaldesc.UseVisualStyleBackColor = True
        '
        'btnlimpar
        '
        Me.btnlimpar.Location = New System.Drawing.Point(40, 302)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(53, 23)
        Me.btnlimpar.TabIndex = 5
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = True
        '
        'btnsair
        '
        Me.btnsair.Location = New System.Drawing.Point(99, 302)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(60, 23)
        Me.btnsair.TabIndex = 6
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'Txtalcool
        '
        Me.Txtalcool.Location = New System.Drawing.Point(43, 45)
        Me.Txtalcool.Name = "Txtalcool"
        Me.Txtalcool.Size = New System.Drawing.Size(100, 20)
        Me.Txtalcool.TabIndex = 7
        '
        'Txtgasolina
        '
        Me.Txtgasolina.Location = New System.Drawing.Point(43, 101)
        Me.Txtgasolina.Name = "Txtgasolina"
        Me.Txtgasolina.Size = New System.Drawing.Size(100, 20)
        Me.Txtgasolina.TabIndex = 8
        '
        'Lbldesconto
        '
        Me.Lbldesconto.AutoSize = True
        Me.Lbldesconto.Location = New System.Drawing.Point(40, 152)
        Me.Lbldesconto.Name = "Lbldesconto"
        Me.Lbldesconto.Size = New System.Drawing.Size(53, 13)
        Me.Lbldesconto.TabIndex = 9
        Me.Lbldesconto.Text = "Desconto"
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.Location = New System.Drawing.Point(43, 208)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(31, 13)
        Me.Lbltotal.TabIndex = 12
        Me.Lbltotal.Text = "Total"
        '
        'Lbldesc
        '
        Me.Lbldesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbldesc.Location = New System.Drawing.Point(40, 176)
        Me.Lbldesc.Name = "Lbldesc"
        Me.Lbldesc.Size = New System.Drawing.Size(103, 20)
        Me.Lbldesc.TabIndex = 13
        '
        'LblvalorTotal
        '
        Me.LblvalorTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblvalorTotal.Location = New System.Drawing.Point(40, 233)
        Me.LblvalorTotal.Name = "LblvalorTotal"
        Me.LblvalorTotal.Size = New System.Drawing.Size(103, 20)
        Me.LblvalorTotal.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 341)
        Me.Controls.Add(Me.LblvalorTotal)
        Me.Controls.Add(Me.Lbldesc)
        Me.Controls.Add(Me.Lbltotal)
        Me.Controls.Add(Me.Lbldesconto)
        Me.Controls.Add(Me.Txtgasolina)
        Me.Controls.Add(Me.Txtalcool)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.btncaldesc)
        Me.Controls.Add(Me.LblGasolina)
        Me.Controls.Add(Me.LblAlcool)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Posto de Gasolina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblAlcool As System.Windows.Forms.Label
    Friend WithEvents LblGasolina As System.Windows.Forms.Label
    Friend WithEvents btncaldesc As System.Windows.Forms.Button
    Friend WithEvents btnlimpar As System.Windows.Forms.Button
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents Txtalcool As System.Windows.Forms.TextBox
    Friend WithEvents Txtgasolina As System.Windows.Forms.TextBox
    Friend WithEvents Lbldesconto As System.Windows.Forms.Label
    Friend WithEvents Lbltotal As System.Windows.Forms.Label
    Friend WithEvents Lbldesc As System.Windows.Forms.Label
    Friend WithEvents LblvalorTotal As System.Windows.Forms.Label

End Class
