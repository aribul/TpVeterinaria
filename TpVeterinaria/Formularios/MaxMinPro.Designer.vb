<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaxMinPro
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
        Me.TxtBoxEdadMin = New System.Windows.Forms.TextBox()
        Me.TxtBoxEdadMax = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridReporte = New System.Windows.Forms.DataGridView()
        Me.btnMostrar = New System.Windows.Forms.Button()
        CType(Me.DataGridReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBoxEdadMin
        '
        Me.TxtBoxEdadMin.Location = New System.Drawing.Point(157, 89)
        Me.TxtBoxEdadMin.Name = "TxtBoxEdadMin"
        Me.TxtBoxEdadMin.Size = New System.Drawing.Size(110, 22)
        Me.TxtBoxEdadMin.TabIndex = 0
        '
        'TxtBoxEdadMax
        '
        Me.TxtBoxEdadMax.Location = New System.Drawing.Point(157, 158)
        Me.TxtBoxEdadMax.Name = "TxtBoxEdadMax"
        Me.TxtBoxEdadMax.Size = New System.Drawing.Size(110, 22)
        Me.TxtBoxEdadMax.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Edad minima"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Edad maxima"
        '
        'DataGridReporte
        '
        Me.DataGridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridReporte.Location = New System.Drawing.Point(313, 30)
        Me.DataGridReporte.Name = "DataGridReporte"
        Me.DataGridReporte.RowHeadersWidth = 51
        Me.DataGridReporte.RowTemplate.Height = 24
        Me.DataGridReporte.Size = New System.Drawing.Size(240, 333)
        Me.DataGridReporte.TabIndex = 4
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(157, 227)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(110, 50)
        Me.btnMostrar.TabIndex = 5
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'MaxMinPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 315)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.DataGridReporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxEdadMax)
        Me.Controls.Add(Me.TxtBoxEdadMin)
        Me.Name = "MaxMinPro"
        Me.Text = "MaxMinPro"
        CType(Me.DataGridReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBoxEdadMin As TextBox
    Friend WithEvents TxtBoxEdadMax As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridReporte As DataGridView
    Friend WithEvents btnMostrar As Button
End Class
