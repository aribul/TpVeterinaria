<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.btnCrearUsuarioNuevo = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.txtIngresarUsuario = New System.Windows.Forms.TextBox()
        Me.lblIngresarUsuario = New System.Windows.Forms.Label()
        Me.MenuPrinicpal = New System.Windows.Forms.MenuStrip()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarNuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarListaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelLogin.SuspendLayout()
        Me.MenuPrinicpal.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.Controls.Add(Me.btnCrearUsuarioNuevo)
        Me.PanelLogin.Controls.Add(Me.lblLogin)
        Me.PanelLogin.Controls.Add(Me.TextBox1)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.btnIniciarSesion)
        Me.PanelLogin.Controls.Add(Me.txtIngresarUsuario)
        Me.PanelLogin.Controls.Add(Me.lblIngresarUsuario)
        Me.PanelLogin.Location = New System.Drawing.Point(455, 91)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(324, 338)
        Me.PanelLogin.TabIndex = 0
        '
        'btnCrearUsuarioNuevo
        '
        Me.btnCrearUsuarioNuevo.Location = New System.Drawing.Point(90, 198)
        Me.btnCrearUsuarioNuevo.Name = "btnCrearUsuarioNuevo"
        Me.btnCrearUsuarioNuevo.Size = New System.Drawing.Size(127, 23)
        Me.btnCrearUsuarioNuevo.TabIndex = 6
        Me.btnCrearUsuarioNuevo.Text = "Crear usuario nuevo"
        Me.btnCrearUsuarioNuevo.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(104, 16)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(101, 39)
        Me.lblLogin.TabIndex = 5
        Me.lblLogin.Text = "Login"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(163, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingresar Constraseña:"
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Location = New System.Drawing.Point(111, 169)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciarSesion.TabIndex = 2
        Me.btnIniciarSesion.Text = "Iniciar"
        Me.btnIniciarSesion.UseVisualStyleBackColor = True
        '
        'txtIngresarUsuario
        '
        Me.txtIngresarUsuario.Location = New System.Drawing.Point(133, 93)
        Me.txtIngresarUsuario.Name = "txtIngresarUsuario"
        Me.txtIngresarUsuario.Size = New System.Drawing.Size(163, 20)
        Me.txtIngresarUsuario.TabIndex = 1
        '
        'lblIngresarUsuario
        '
        Me.lblIngresarUsuario.AutoSize = True
        Me.lblIngresarUsuario.Location = New System.Drawing.Point(40, 96)
        Me.lblIngresarUsuario.Name = "lblIngresarUsuario"
        Me.lblIngresarUsuario.Size = New System.Drawing.Size(87, 13)
        Me.lblIngresarUsuario.TabIndex = 0
        Me.lblIngresarUsuario.Text = "Ingresar Usuario:"
        '
        'MenuPrinicpal
        '
        Me.MenuPrinicpal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuPrinicpal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuPrinicpal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrinicpal.Name = "MenuPrinicpal"
        Me.MenuPrinicpal.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuPrinicpal.Size = New System.Drawing.Size(1299, 24)
        Me.MenuPrinicpal.TabIndex = 1
        Me.MenuPrinicpal.Text = "MenuStrip1"
        Me.MenuPrinicpal.Visible = False
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarNuevoClienteToolStripMenuItem, Me.MostrarListaDeClientesToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'CargarNuevoClienteToolStripMenuItem
        '
        Me.CargarNuevoClienteToolStripMenuItem.Name = "CargarNuevoClienteToolStripMenuItem"
        Me.CargarNuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CargarNuevoClienteToolStripMenuItem.Text = "Cargar Nuevo Cliente"
        '
        'MostrarListaDeClientesToolStripMenuItem
        '
        Me.MostrarListaDeClientesToolStripMenuItem.Name = "MostrarListaDeClientesToolStripMenuItem"
        Me.MostrarListaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.MostrarListaDeClientesToolStripMenuItem.Text = "Mostrar lista de clientes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 559)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.MenuPrinicpal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuPrinicpal
        Me.Name = "FormularioPrincipal"
        Me.Text = "FormularioPrincipal"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.MenuPrinicpal.ResumeLayout(False)
        Me.MenuPrinicpal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents txtIngresarUsuario As TextBox
    Friend WithEvents lblIngresarUsuario As Label
    Friend WithEvents MenuPrinicpal As MenuStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarNuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarListaDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblLogin As Label
    Friend WithEvents btnCrearUsuarioNuevo As Button
End Class
