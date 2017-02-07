<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnTirar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtJugador = New System.Windows.Forms.TextBox()
        Me.TxtMaquina = New System.Windows.Forms.TextBox()
        Me.TxtDado = New System.Windows.Forms.TextBox()
        Me.TxtAcumula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTirar
        '
        Me.BtnTirar.Location = New System.Drawing.Point(26, 170)
        Me.BtnTirar.Name = "BtnTirar"
        Me.BtnTirar.Size = New System.Drawing.Size(75, 23)
        Me.BtnTirar.TabIndex = 0
        Me.BtnTirar.Text = "Tirar"
        Me.BtnTirar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Parar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtJugador
        '
        Me.TxtJugador.Location = New System.Drawing.Point(12, 24)
        Me.TxtJugador.Name = "TxtJugador"
        Me.TxtJugador.Size = New System.Drawing.Size(100, 20)
        Me.TxtJugador.TabIndex = 2
        '
        'TxtMaquina
        '
        Me.TxtMaquina.Location = New System.Drawing.Point(172, 24)
        Me.TxtMaquina.Name = "TxtMaquina"
        Me.TxtMaquina.Size = New System.Drawing.Size(100, 20)
        Me.TxtMaquina.TabIndex = 3
        '
        'TxtDado
        '
        Me.TxtDado.Location = New System.Drawing.Point(92, 74)
        Me.TxtDado.Name = "TxtDado"
        Me.TxtDado.Size = New System.Drawing.Size(100, 20)
        Me.TxtDado.TabIndex = 4
        '
        'TxtAcumula
        '
        Me.TxtAcumula.Location = New System.Drawing.Point(92, 119)
        Me.TxtAcumula.Name = "TxtAcumula"
        Me.TxtAcumula.Size = New System.Drawing.Size(100, 20)
        Me.TxtAcumula.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAcumula)
        Me.Controls.Add(Me.TxtDado)
        Me.Controls.Add(Me.TxtMaquina)
        Me.Controls.Add(Me.TxtJugador)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnTirar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTirar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtJugador As TextBox
    Friend WithEvents TxtMaquina As TextBox
    Friend WithEvents TxtDado As TextBox
    Friend WithEvents TxtAcumula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
