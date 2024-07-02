<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Animales
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtEdadAnimal = New System.Windows.Forms.TextBox()
        Me.txtEspecieAnimal = New System.Windows.Forms.TextBox()
        Me.txtPesoAnimal = New System.Windows.Forms.TextBox()
        Me.txtNombreAnimal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtClienteAnimal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 259)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar Animal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtEdadAnimal
        '
        Me.txtEdadAnimal.Location = New System.Drawing.Point(254, 124)
        Me.txtEdadAnimal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEdadAnimal.Name = "txtEdadAnimal"
        Me.txtEdadAnimal.Size = New System.Drawing.Size(86, 20)
        Me.txtEdadAnimal.TabIndex = 1
        '
        'txtEspecieAnimal
        '
        Me.txtEspecieAnimal.Location = New System.Drawing.Point(254, 160)
        Me.txtEspecieAnimal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEspecieAnimal.Name = "txtEspecieAnimal"
        Me.txtEspecieAnimal.Size = New System.Drawing.Size(86, 20)
        Me.txtEspecieAnimal.TabIndex = 2
        '
        'txtPesoAnimal
        '
        Me.txtPesoAnimal.Location = New System.Drawing.Point(254, 89)
        Me.txtPesoAnimal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPesoAnimal.Name = "txtPesoAnimal"
        Me.txtPesoAnimal.Size = New System.Drawing.Size(86, 20)
        Me.txtPesoAnimal.TabIndex = 3
        '
        'txtNombreAnimal
        '
        Me.txtNombreAnimal.Location = New System.Drawing.Point(254, 54)
        Me.txtNombreAnimal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreAnimal.Name = "txtNombreAnimal"
        Me.txtNombreAnimal.Size = New System.Drawing.Size(86, 20)
        Me.txtNombreAnimal.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Peso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(174, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Especie"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 205)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cliente"
        '
        'txtClienteAnimal
        '
        Me.txtClienteAnimal.Location = New System.Drawing.Point(254, 202)
        Me.txtClienteAnimal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtClienteAnimal.Name = "txtClienteAnimal"
        Me.txtClienteAnimal.Size = New System.Drawing.Size(86, 20)
        Me.txtClienteAnimal.TabIndex = 10
        '
        'Animales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.txtClienteAnimal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreAnimal)
        Me.Controls.Add(Me.txtPesoAnimal)
        Me.Controls.Add(Me.txtEspecieAnimal)
        Me.Controls.Add(Me.txtEdadAnimal)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Animales"
        Me.Text = "Animales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtEdadAnimal As TextBox
    Friend WithEvents txtEspecieAnimal As TextBox
    Friend WithEvents txtPesoAnimal As TextBox
    Friend WithEvents txtNombreAnimal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtClienteAnimal As TextBox
End Class
