<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articulos
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
        SplitContainer1 = New SplitContainer()
        Label12 = New Label()
        Button2 = New Button()
        Label4 = New Label()
        ComboBox2 = New ComboBox()
        Panel1 = New Panel()
        Label13 = New Label()
        Label11 = New Label()
        TextBox7 = New TextBox()
        Label10 = New Label()
        TextBox5 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        ComboBox3 = New ComboBox()
        Label7 = New Label()
        ComboBox1 = New ComboBox()
        TextBox6 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        Label1 = New Label()
        btnPaginaAnterior1 = New FontAwesome.Sharp.IconButton()
        btnPaginaSiguiente1 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        dgvCarritos = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        CODE = New DataGridViewTextBoxColumn()
        ARTICULO = New DataGridViewTextBoxColumn()
        MARCA = New DataGridViewTextBoxColumn()
        CANTIDAD = New DataGridViewTextBoxColumn()
        PRECIO = New DataGridViewTextBoxColumn()
        PESO = New DataGridViewTextBoxColumn()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvCarritos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Margin = New Padding(3, 2, 3, 2)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        SplitContainer1.Panel1.Controls.Add(Label12)
        SplitContainer1.Panel1.Controls.Add(Button2)
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(ComboBox2)
        SplitContainer1.Panel1.Controls.Add(Panel1)
        SplitContainer1.Panel1.Controls.Add(Label7)
        SplitContainer1.Panel1.Controls.Add(ComboBox1)
        SplitContainer1.Panel1.Controls.Add(TextBox6)
        SplitContainer1.Panel1.Controls.Add(Label6)
        SplitContainer1.Panel1.Controls.Add(Label5)
        SplitContainer1.Panel1.Controls.Add(TextBox4)
        SplitContainer1.Panel1.Controls.Add(TextBox3)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(TextBox2)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(TextBox1)
        SplitContainer1.Panel1.Controls.Add(CheckBox1)
        SplitContainer1.Panel1.Controls.Add(Button1)
        SplitContainer1.Panel1.Controls.Add(Label1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.White
        SplitContainer1.Panel2.Controls.Add(btnPaginaAnterior1)
        SplitContainer1.Panel2.Controls.Add(btnPaginaSiguiente1)
        SplitContainer1.Panel2.Controls.Add(IconButton3)
        SplitContainer1.Panel2.Controls.Add(IconButton2)
        SplitContainer1.Panel2.Controls.Add(IconButton1)
        SplitContainer1.Panel2.Controls.Add(dgvCarritos)
        SplitContainer1.Size = New Size(1144, 619)
        SplitContainer1.SplitterDistance = 277
        SplitContainer1.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ButtonHighlight
        Label12.Location = New Point(106, 7)
        Label12.Name = "Label12"
        Label12.Size = New Size(76, 21)
        Label12.TabIndex = 8
        Label12.Text = "EDICIÓN"
        ' 
        ' Button2
        ' 
        Button2.Enabled = False
        Button2.Location = New Point(152, 538)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 25)
        Button2.TabIndex = 19
        Button2.Text = "CANCELAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(13, 286)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 21)
        Label4.TabIndex = 8
        Label4.Text = "UNIDAD:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Enabled = False
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"hola", "ads"})
        ComboBox2.Location = New Point(13, 310)
        ComboBox2.Margin = New Padding(3, 2, 3, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(246, 23)
        ComboBox2.TabIndex = 17
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(ComboBox3)
        Panel1.Location = New Point(10, 382)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(278, 152)
        Panel1.TabIndex = 16
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12.0F)
        Label13.ForeColor = SystemColors.ButtonFace
        Label13.Location = New Point(76, 48)
        Label13.Name = "Label13"
        Label13.Size = New Size(71, 21)
        Label13.TabIndex = 23
        Label13.Text = "MEDIDA:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(146, 62)
        Label11.Name = "Label11"
        Label11.Size = New Size(0, 15)
        Label11.TabIndex = 22
        ' 
        ' TextBox7
        ' 
        TextBox7.Enabled = False
        TextBox7.Location = New Point(3, 118)
        TextBox7.Margin = New Padding(3, 2, 3, 2)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(246, 23)
        TextBox7.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12.0F)
        Label10.ForeColor = SystemColors.ButtonFace
        Label10.Location = New Point(3, 94)
        Label10.Name = "Label10"
        Label10.Size = New Size(99, 21)
        Label10.TabIndex = 20
        Label10.Text = "PRECIO KILO"
        ' 
        ' TextBox5
        ' 
        TextBox5.Enabled = False
        TextBox5.Location = New Point(3, 26)
        TextBox5.Margin = New Padding(3, 2, 3, 2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(246, 23)
        TextBox5.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F)
        Label8.ForeColor = SystemColors.ButtonFace
        Label8.Location = New Point(3, 48)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 21)
        Label8.TabIndex = 18
        Label8.Text = "UNIDAD"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12.0F)
        Label9.ForeColor = SystemColors.ButtonFace
        Label9.Location = New Point(3, 2)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 21)
        Label9.TabIndex = 18
        Label9.Text = "PESO:"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Enabled = False
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(3, 71)
        ComboBox3.Margin = New Padding(3, 2, 3, 2)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(246, 23)
        ComboBox3.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12.0F)
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(10, 333)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 21)
        Label7.TabIndex = 15
        Label7.Text = "CATEGORIA:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Enabled = False
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(13, 356)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(246, 23)
        ComboBox1.TabIndex = 14
        ' 
        ' TextBox6
        ' 
        TextBox6.Enabled = False
        TextBox6.Location = New Point(13, 218)
        TextBox6.Margin = New Padding(3, 2, 3, 2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(246, 23)
        TextBox6.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(10, 195)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 21)
        Label6.TabIndex = 12
        Label6.Text = "PRECIO:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(12, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 21)
        Label5.TabIndex = 10
        Label5.Text = "CANTIDAD:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Enabled = False
        TextBox4.Location = New Point(13, 264)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(246, 23)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Location = New Point(13, 172)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(246, 23)
        TextBox3.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(10, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 21)
        Label3.TabIndex = 6
        Label3.Text = "CONCEPTO:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(12, 127)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(246, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(12, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 21)
        Label2.TabIndex = 4
        Label2.Text = "NOMBRE:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(12, 81)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(246, 23)
        TextBox1.TabIndex = 3
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Enabled = False
        CheckBox1.Font = New Font("Segoe UI", 12.0F)
        CheckBox1.ForeColor = SystemColors.ButtonFace
        CheckBox1.Location = New Point(13, 32)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(176, 25)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "¿GENERAR CÓDIGO?"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(15, 538)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 25)
        Button1.TabIndex = 1
        Button1.Text = "AÑADIR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 21)
        Label1.TabIndex = 0
        Label1.Text = "CODE:"
        ' 
        ' btnPaginaAnterior1
        ' 
        btnPaginaAnterior1.IconChar = FontAwesome.Sharp.IconChar.AnglesLeft
        btnPaginaAnterior1.IconColor = Color.Black
        btnPaginaAnterior1.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnPaginaAnterior1.IconSize = 30
        btnPaginaAnterior1.Location = New Point(23, 568)
        btnPaginaAnterior1.Margin = New Padding(3, 2, 3, 2)
        btnPaginaAnterior1.Name = "btnPaginaAnterior1"
        btnPaginaAnterior1.Size = New Size(105, 27)
        btnPaginaAnterior1.TabIndex = 7
        btnPaginaAnterior1.UseVisualStyleBackColor = True
        ' 
        ' btnPaginaSiguiente1
        ' 
        btnPaginaSiguiente1.IconChar = FontAwesome.Sharp.IconChar.AnglesRight
        btnPaginaSiguiente1.IconColor = Color.Black
        btnPaginaSiguiente1.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnPaginaSiguiente1.IconSize = 30
        btnPaginaSiguiente1.Location = New Point(133, 568)
        btnPaginaSiguiente1.Margin = New Padding(3, 2, 3, 2)
        btnPaginaSiguiente1.Name = "btnPaginaSiguiente1"
        btnPaginaSiguiente1.Size = New Size(89, 26)
        btnPaginaSiguiente1.TabIndex = 6
        btnPaginaSiguiente1.UseVisualStyleBackColor = True
        ' 
        ' IconButton3
        ' 
        IconButton3.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        IconButton3.IconColor = Color.White
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.IconSize = 35
        IconButton3.Location = New Point(662, 2)
        IconButton3.Margin = New Padding(3, 2, 3, 2)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(56, 39)
        IconButton3.TabIndex = 5
        IconButton3.UseVisualStyleBackColor = False
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        IconButton2.IconColor = Color.White
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 35
        IconButton2.Location = New Point(724, 2)
        IconButton2.Margin = New Padding(3, 2, 3, 2)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(56, 39)
        IconButton2.TabIndex = 4
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.TrashCan
        IconButton1.IconColor = Color.White
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 35
        IconButton1.Location = New Point(785, 2)
        IconButton1.Margin = New Padding(3, 2, 3, 2)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(53, 39)
        IconButton1.TabIndex = 3
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' dgvCarritos
        ' 
        dgvCarritos.AllowUserToAddRows = False
        dgvCarritos.AllowUserToDeleteRows = False
        dgvCarritos.BackgroundColor = Color.Silver
        dgvCarritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCarritos.Columns.AddRange(New DataGridViewColumn() {ID, CODE, ARTICULO, MARCA, CANTIDAD, PRECIO, PESO})
        dgvCarritos.GridColor = SystemColors.Info
        dgvCarritos.Location = New Point(9, 46)
        dgvCarritos.Margin = New Padding(3, 2, 3, 2)
        dgvCarritos.Name = "dgvCarritos"
        dgvCarritos.ReadOnly = True
        dgvCarritos.RowHeadersWidth = 51
        dgvCarritos.Size = New Size(830, 518)
        dgvCarritos.TabIndex = 0
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.MinimumWidth = 6
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Visible = False
        ID.Width = 125
        ' 
        ' CODE
        ' 
        CODE.HeaderText = "CODE"
        CODE.MinimumWidth = 6
        CODE.Name = "CODE"
        CODE.ReadOnly = True
        CODE.Width = 125
        ' 
        ' ARTICULO
        ' 
        ARTICULO.HeaderText = "ARTICULO"
        ARTICULO.MinimumWidth = 6
        ARTICULO.Name = "ARTICULO"
        ARTICULO.ReadOnly = True
        ARTICULO.Width = 310
        ' 
        ' MARCA
        ' 
        MARCA.HeaderText = "MARCA"
        MARCA.MinimumWidth = 6
        MARCA.Name = "MARCA"
        MARCA.ReadOnly = True
        MARCA.Width = 125
        ' 
        ' CANTIDAD
        ' 
        CANTIDAD.HeaderText = "CANTIDAD"
        CANTIDAD.MinimumWidth = 6
        CANTIDAD.Name = "CANTIDAD"
        CANTIDAD.ReadOnly = True
        CANTIDAD.Width = 125
        ' 
        ' PRECIO
        ' 
        PRECIO.HeaderText = "PRECIO"
        PRECIO.MinimumWidth = 6
        PRECIO.Name = "PRECIO"
        PRECIO.ReadOnly = True
        PRECIO.Width = 125
        ' 
        ' PESO
        ' 
        PESO.HeaderText = "PESO"
        PESO.MinimumWidth = 6
        PESO.Name = "PESO"
        PESO.ReadOnly = True
        PESO.Width = 125
        ' 
        ' Articulos
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1144, 619)
        ControlBox = False
        Controls.Add(SplitContainer1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Articulos"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "Articulos"
        WindowState = FormWindowState.Maximized
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvCarritos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvCarritos As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton

    Friend WithEvents Label13 As Label
    Friend WithEvents btnPaginaAnterior1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPaginaSiguiente1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CODE As DataGridViewTextBoxColumn
    Friend WithEvents ARTICULO As DataGridViewTextBoxColumn
    Friend WithEvents MARCA As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents PESO As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Label12 As Label
End Class
