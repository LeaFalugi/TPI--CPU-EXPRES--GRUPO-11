<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoria))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cmbbuscar = New System.Windows.Forms.ComboBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbxeliminar = New System.Windows.Forms.CheckBox()
        Me.cmbcategoria = New System.Windows.Forms.ComboBox()
        Me.txtncategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxmodificar = New System.Windows.Forms.CheckBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 220)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 22)
        Me.TextBox1.TabIndex = 64
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(486, 35)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(192, 22)
        Me.txtbuscar.TabIndex = 62
        '
        'cmbbuscar
        '
        Me.cmbbuscar.FormattingEnabled = True
        Me.cmbbuscar.Items.AddRange(New Object() {"n° categoria", "equipo completo", "insumos", "Hardware"})
        Me.cmbbuscar.Location = New System.Drawing.Point(338, 34)
        Me.cmbbuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbbuscar.Name = "cmbbuscar"
        Me.cmbbuscar.Size = New System.Drawing.Size(139, 24)
        Me.cmbbuscar.TabIndex = 61
        Me.cmbbuscar.Text = "selecionar :"
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(892, 413)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(100, 30)
        Me.btneliminar.TabIndex = 59
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(336, 65)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(655, 341)
        Me.DataGridView1.TabIndex = 56
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'cbxeliminar
        '
        Me.cbxeliminar.AutoSize = True
        Me.cbxeliminar.BackColor = System.Drawing.Color.Transparent
        Me.cbxeliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbxeliminar.Location = New System.Drawing.Point(892, 29)
        Me.cbxeliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxeliminar.Name = "cbxeliminar"
        Me.cbxeliminar.Size = New System.Drawing.Size(80, 21)
        Me.cbxeliminar.TabIndex = 55
        Me.cbxeliminar.Text = "Eliminar"
        Me.cbxeliminar.UseVisualStyleBackColor = False
        '
        'cmbcategoria
        '
        Me.cmbcategoria.FormattingEnabled = True
        Me.cmbcategoria.Items.AddRange(New Object() {"equipo completo", "insumos", "Hardware"})
        Me.cmbcategoria.Location = New System.Drawing.Point(110, 188)
        Me.cmbcategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbcategoria.Name = "cmbcategoria"
        Me.cmbcategoria.Size = New System.Drawing.Size(167, 24)
        Me.cmbcategoria.TabIndex = 54
        Me.cmbcategoria.Text = "categoria"
        '
        'txtncategoria
        '
        Me.txtncategoria.Location = New System.Drawing.Point(110, 124)
        Me.txtncategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtncategoria.Name = "txtncategoria"
        Me.txtncategoria.Size = New System.Drawing.Size(167, 22)
        Me.txtncategoria.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(13, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "N° Categoria"
        '
        'cbxmodificar
        '
        Me.cbxmodificar.AutoSize = True
        Me.cbxmodificar.BackColor = System.Drawing.Color.Transparent
        Me.cbxmodificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbxmodificar.Location = New System.Drawing.Point(192, 265)
        Me.cbxmodificar.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxmodificar.Name = "cbxmodificar"
        Me.cbxmodificar.Size = New System.Drawing.Size(87, 21)
        Me.cbxmodificar.TabIndex = 65
        Me.cbxmodificar.Text = "Modificar"
        Me.cbxmodificar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(17, 368)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(89, 38)
        Me.btnguardar.TabIndex = 72
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(114, 368)
        Me.btnaceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(97, 38)
        Me.btnaceptar.TabIndex = 71
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(219, 368)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(97, 38)
        Me.btncancelar.TabIndex = 70
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
        Me.Button1.Location = New System.Drawing.Point(20, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 70)
        Me.Button1.TabIndex = 73
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(703, 19)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 38)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 448)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.cbxmodificar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.cmbbuscar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbxeliminar)
        Me.Controls.Add(Me.cmbcategoria)
        Me.Controls.Add(Me.txtncategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCategoria"
        Me.Text = "Categoria"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cmbbuscar As ComboBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents cbxeliminar As CheckBox
    Friend WithEvents cmbcategoria As ComboBox
    Friend WithEvents txtncategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxmodificar As CheckBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnaceptar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
