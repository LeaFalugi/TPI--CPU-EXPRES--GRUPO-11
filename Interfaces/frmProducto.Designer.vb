<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
        Me.cbxmodificar = New System.Windows.Forms.CheckBox()
        Me.btncategoria = New System.Windows.Forms.Button()
        Me.btnproveedor = New System.Windows.Forms.Button()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtcategoria = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtproveedores = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbxeliminar = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btrguardar = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxmodificar
        '
        Me.cbxmodificar.AutoSize = True
        Me.cbxmodificar.BackColor = System.Drawing.Color.Transparent
        Me.cbxmodificar.Location = New System.Drawing.Point(357, 94)
        Me.cbxmodificar.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxmodificar.Name = "cbxmodificar"
        Me.cbxmodificar.Size = New System.Drawing.Size(87, 21)
        Me.cbxmodificar.TabIndex = 51
        Me.cbxmodificar.Text = "Modificar"
        Me.cbxmodificar.UseVisualStyleBackColor = False
        Me.cbxmodificar.UseWaitCursor = True
        '
        'btncategoria
        '
        Me.btncategoria.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategoria.Location = New System.Drawing.Point(357, 180)
        Me.btncategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.btncategoria.Name = "btncategoria"
        Me.btncategoria.Size = New System.Drawing.Size(100, 28)
        Me.btncategoria.TabIndex = 50
        Me.btncategoria.Text = "..."
        Me.btncategoria.UseVisualStyleBackColor = True
        Me.btncategoria.UseWaitCursor = True
        '
        'btnproveedor
        '
        Me.btnproveedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproveedor.Location = New System.Drawing.Point(357, 141)
        Me.btnproveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnproveedor.Name = "btnproveedor"
        Me.btnproveedor.Size = New System.Drawing.Size(100, 28)
        Me.btnproveedor.TabIndex = 49
        Me.btnproveedor.Text = "..."
        Me.btnproveedor.UseVisualStyleBackColor = True
        Me.btnproveedor.UseWaitCursor = True
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(158, 417)
        Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(320, 226)
        Me.txtdescripcion.TabIndex = 48
        Me.txtdescripcion.UseWaitCursor = True
        '
        'txtcategoria
        '
        Me.txtcategoria.Location = New System.Drawing.Point(158, 184)
        Me.txtcategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(160, 22)
        Me.txtcategoria.TabIndex = 47
        Me.txtcategoria.UseWaitCursor = True
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(158, 233)
        Me.txtmarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(160, 22)
        Me.txtmarca.TabIndex = 46
        Me.txtmarca.UseWaitCursor = True
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(158, 278)
        Me.txtmodelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(160, 22)
        Me.txtmodelo.TabIndex = 45
        Me.txtmodelo.UseWaitCursor = True
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(158, 324)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(160, 22)
        Me.txtprecio.TabIndex = 44
        Me.txtprecio.UseWaitCursor = True
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(158, 367)
        Me.txtstock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(160, 22)
        Me.txtstock.TabIndex = 43
        Me.txtstock.UseWaitCursor = True
        '
        'txtproveedores
        '
        Me.txtproveedores.Location = New System.Drawing.Point(158, 141)
        Me.txtproveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.txtproveedores.Name = "txtproveedores"
        Me.txtproveedores.Size = New System.Drawing.Size(160, 22)
        Me.txtproveedores.TabIndex = 42
        Me.txtproveedores.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(83, 370)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Stock"
        Me.Label8.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(72, 281)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Modelo"
        Me.Label7.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(79, 233)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Marca"
        Me.Label6.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(78, 327)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Precio"
        Me.Label5.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(46, 417)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "descripcion"
        Me.Label4.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(57, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Categoria"
        Me.Label3.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(52, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Proveedor"
        Me.Label2.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(41, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "N° Producto"
        Me.Label1.UseWaitCursor = True
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(158, 94)
        Me.txtproducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(160, 22)
        Me.txtproducto.TabIndex = 33
        Me.txtproducto.UseWaitCursor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(519, 600)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(100, 28)
        Me.btneliminar.TabIndex = 57
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(486, 124)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(748, 469)
        Me.DataGridView1.TabIndex = 56
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(627, 77)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(259, 22)
        Me.txtbuscar.TabIndex = 55
        '
        'cbxeliminar
        '
        Me.cbxeliminar.AutoSize = True
        Me.cbxeliminar.BackColor = System.Drawing.Color.Transparent
        Me.cbxeliminar.Location = New System.Drawing.Point(1126, 91)
        Me.cbxeliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxeliminar.Name = "cbxeliminar"
        Me.cbxeliminar.Size = New System.Drawing.Size(80, 21)
        Me.cbxeliminar.TabIndex = 53
        Me.cbxeliminar.Text = "Eliminar"
        Me.cbxeliminar.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"n° producto", "proveedor", "categoria", "marca", "modelo"})
        Me.ComboBox1.Location = New System.Drawing.Point(486, 77)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(107, 24)
        Me.ComboBox1.TabIndex = 52
        Me.ComboBox1.Text = "categoria"
        '
        'btrguardar
        '
        Me.btrguardar.Location = New System.Drawing.Point(873, 601)
        Me.btrguardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btrguardar.Name = "btrguardar"
        Me.btrguardar.Size = New System.Drawing.Size(108, 38)
        Me.btrguardar.TabIndex = 60
        Me.btrguardar.Text = "Guardar"
        Me.btrguardar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(989, 601)
        Me.btnaceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(108, 38)
        Me.btnaceptar.TabIndex = 59
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(1126, 601)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(108, 38)
        Me.btncancelar.TabIndex = 58
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(22, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 70)
        Me.Button1.TabIndex = 75
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(893, 34)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 64)
        Me.Button6.TabIndex = 77
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(1133, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 58)
        Me.Button2.TabIndex = 78
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1256, 666)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btrguardar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.cbxeliminar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cbxmodificar)
        Me.Controls.Add(Me.btncategoria)
        Me.Controls.Add(Me.btnproveedor)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtcategoria)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.txtmodelo)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txtproveedores)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtproducto)
        Me.Name = "frmProducto"
        Me.Text = "frmProducto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxmodificar As CheckBox
    Friend WithEvents btncategoria As Button
    Friend WithEvents btnproveedor As Button
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtcategoria As TextBox
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtproveedores As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbxeliminar As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btrguardar As Button
    Friend WithEvents btnaceptar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
End Class
