<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        AgregarToolStripMenuItem = New ToolStripMenuItem()
        Panel2 = New Panel()
        TextBox3 = New TextBox()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        Label12 = New Label()
        Label11 = New Label()
        Label5 = New Label()
        IconButton5 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        VENDER = New FontAwesome.Sharp.IconButton()
        DataGridView2 = New DataGridView()
        FOLIO = New DataGridViewTextBoxColumn()
        TOTAL = New DataGridViewTextBoxColumn()
        IMPORTE = New DataGridViewTextBoxColumn()
        HORA = New DataGridViewTextBoxColumn()
        CARGAR = New DataGridViewTextBoxColumn()
        DataGridView1 = New DataGridView()
        CODE = New DataGridViewTextBoxColumn()
        CONCEPTO = New DataGridViewTextBoxColumn()
        CANTIDAD = New DataGridViewTextBoxColumn()
        PRECIO = New DataGridViewTextBoxColumn()
        SUBTOTAL = New DataGridViewTextBoxColumn()
        ID = New DataGridViewTextBoxColumn()
        Eliminar = New DataGridViewButtonColumn()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        SplitContainer1 = New SplitContainer()
        IconButton8 = New FontAwesome.Sharp.IconButton()
        IconButton7 = New FontAwesome.Sharp.IconButton()
        IconButton6 = New FontAwesome.Sharp.IconButton()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        MenuStrip1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(4, 1, 0, 1)
        MenuStrip1.Size = New Size(1243, 24)
        MenuStrip1.TabIndex = 16
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(50, 22)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' AgregarToolStripMenuItem
        ' 
        AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        AgregarToolStripMenuItem.Size = New Size(116, 22)
        AgregarToolStripMenuItem.Text = "Agregar"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Snow
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(IconButton2)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(IconButton5)
        Panel2.Controls.Add(IconButton1)
        Panel2.Controls.Add(VENDER)
        Panel2.Controls.Add(DataGridView2)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(1, 1, 1, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1144, 605)
        Panel2.TabIndex = 17
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.InfoText
        TextBox3.Font = New Font("Microsoft Sans Serif", 24F)
        TextBox3.ForeColor = Color.Chartreuse
        TextBox3.Location = New Point(906, 43)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(227, 44)
        TextBox3.TabIndex = 44
        TextBox3.Text = "$0.00"
        ' 
        ' IconButton2
        ' 
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.Cancel
        IconButton2.IconColor = Color.Red
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 35
        IconButton2.Location = New Point(1058, 309)
        IconButton2.Margin = New Padding(3, 2, 3, 2)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(74, 47)
        IconButton2.TabIndex = 43
        IconButton2.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 18F)
        Label12.ForeColor = SystemColors.ActiveCaptionText
        Label12.Location = New Point(13, 7)
        Label12.Margin = New Padding(1, 0, 1, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(111, 29)
        Label12.TabIndex = 42
        Label12.Text = "BUSCAR"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 18F)
        Label11.ForeColor = SystemColors.ControlLightLight
        Label11.Location = New Point(13, 357)
        Label11.Name = "Label11"
        Label11.Size = New Size(277, 29)
        Label11.TabIndex = 41
        Label11.Text = "TICKETS PENDIENTES"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 18F)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(909, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 29)
        Label5.TabIndex = 35
        Label5.Text = "TOTAL"
        ' 
        ' IconButton5
        ' 
        IconButton5.ForeColor = SystemColors.HotTrack
        IconButton5.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer
        IconButton5.IconColor = Color.CadetBlue
        IconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton5.Location = New Point(909, 309)
        IconButton5.Margin = New Padding(3, 2, 3, 2)
        IconButton5.Name = "IconButton5"
        IconButton5.Size = New Size(76, 47)
        IconButton5.TabIndex = 33
        IconButton5.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Hourglass2
        IconButton1.IconColor = Color.DarkOrange
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 35
        IconButton1.Location = New Point(990, 309)
        IconButton1.Margin = New Padding(3, 2, 3, 2)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(64, 47)
        IconButton1.TabIndex = 29
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' VENDER
        ' 
        VENDER.IconChar = FontAwesome.Sharp.IconChar.HandHoldingDollar
        VENDER.IconColor = Color.ForestGreen
        VENDER.IconFont = FontAwesome.Sharp.IconFont.Auto
        VENDER.Location = New Point(907, 235)
        VENDER.Margin = New Padding(3, 2, 3, 2)
        VENDER.Name = "VENDER"
        VENDER.Size = New Size(225, 69)
        VENDER.TabIndex = 28
        VENDER.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridViewCellStyle1.BackColor = Color.Yellow
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight
        DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView2.BackgroundColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {FOLIO, TOTAL, IMPORTE, HORA, CARGAR})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView2.Location = New Point(13, 385)
        DataGridView2.Margin = New Padding(1, 1, 1, 1)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 62
        DataGridView2.Size = New Size(511, 198)
        DataGridView2.TabIndex = 5
        ' 
        ' FOLIO
        ' 
        FOLIO.HeaderText = "FOLIO"
        FOLIO.MinimumWidth = 6
        FOLIO.Name = "FOLIO"
        FOLIO.ReadOnly = True
        FOLIO.Width = 80
        ' 
        ' TOTAL
        ' 
        TOTAL.HeaderText = "TOTAL"
        TOTAL.MinimumWidth = 6
        TOTAL.Name = "TOTAL"
        TOTAL.ReadOnly = True
        TOTAL.Width = 80
        ' 
        ' IMPORTE
        ' 
        IMPORTE.HeaderText = "IMPORTE"
        IMPORTE.MinimumWidth = 6
        IMPORTE.Name = "IMPORTE"
        IMPORTE.Width = 80
        ' 
        ' HORA
        ' 
        HORA.HeaderText = "HORA"
        HORA.MinimumWidth = 6
        HORA.Name = "HORA"
        HORA.ReadOnly = True
        HORA.Width = 80
        ' 
        ' CARGAR
        ' 
        CARGAR.HeaderText = "CARGAR"
        CARGAR.MinimumWidth = 6
        CARGAR.Name = "CARGAR"
        CARGAR.ReadOnly = True
        CARGAR.Width = 70
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CODE, CONCEPTO, CANTIDAD, PRECIO, SUBTOTAL, ID, Eliminar})
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.Black
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle7.ForeColor = Color.Chartreuse
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        DataGridView1.Location = New Point(13, 62)
        DataGridView1.Margin = New Padding(1, 1, 1, 1)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(820, 294)
        DataGridView1.TabIndex = 4
        ' 
        ' CODE
        ' 
        CODE.Frozen = True
        CODE.HeaderText = "CODE"
        CODE.MinimumWidth = 8
        CODE.Name = "CODE"
        CODE.ReadOnly = True
        CODE.Width = 150
        ' 
        ' CONCEPTO
        ' 
        CONCEPTO.Frozen = True
        CONCEPTO.HeaderText = "CONCEPTO"
        CONCEPTO.MinimumWidth = 8
        CONCEPTO.Name = "CONCEPTO"
        CONCEPTO.ReadOnly = True
        CONCEPTO.Width = 300
        ' 
        ' CANTIDAD
        ' 
        CANTIDAD.Frozen = True
        CANTIDAD.HeaderText = "CANTIDAD"
        CANTIDAD.MinimumWidth = 8
        CANTIDAD.Name = "CANTIDAD"
        CANTIDAD.ReadOnly = True
        CANTIDAD.Width = 150
        ' 
        ' PRECIO
        ' 
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        PRECIO.DefaultCellStyle = DataGridViewCellStyle5
        PRECIO.Frozen = True
        PRECIO.HeaderText = "PRECIO"
        PRECIO.MinimumWidth = 8
        PRECIO.Name = "PRECIO"
        PRECIO.ReadOnly = True
        PRECIO.Width = 125
        ' 
        ' SUBTOTAL
        ' 
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle6
        SUBTOTAL.Frozen = True
        SUBTOTAL.HeaderText = "SUBTOTAL"
        SUBTOTAL.MinimumWidth = 8
        SUBTOTAL.Name = "SUBTOTAL"
        SUBTOTAL.ReadOnly = True
        SUBTOTAL.Width = 125
        ' 
        ' ID
        ' 
        ID.Frozen = True
        ID.HeaderText = "ID"
        ID.MinimumWidth = 6
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Visible = False
        ID.Width = 125
        ' 
        ' Eliminar
        ' 
        Eliminar.Frozen = True
        Eliminar.HeaderText = "ELIMINAR"
        Eliminar.MinimumWidth = 6
        Eliminar.Name = "Eliminar"
        Eliminar.Width = 90
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(134, 3)
        ComboBox1.Margin = New Padding(1, 1, 1, 1)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(273, 40)
        ComboBox1.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(906, 181)
        TextBox1.Margin = New Padding(1, 1, 1, 1)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(227, 39)
        TextBox1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 18F)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(907, 152)
        Label3.Margin = New Padding(1, 0, 1, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 29)
        Label3.TabIndex = 11
        Label3.Text = "CODIGO"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 24)
        SplitContainer1.Margin = New Padding(3, 2, 3, 2)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.White
        SplitContainer1.Panel1.Controls.Add(IconButton8)
        SplitContainer1.Panel1.Controls.Add(IconButton7)
        SplitContainer1.Panel1.Controls.Add(IconButton6)
        SplitContainer1.Panel1.Controls.Add(IconButton4)
        SplitContainer1.Panel1.Controls.Add(IconButton3)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Size = New Size(1243, 605)
        SplitContainer1.SplitterDistance = 95
        SplitContainer1.TabIndex = 18
        ' 
        ' IconButton8
        ' 
        IconButton8.BackColor = Color.White
        IconButton8.IconChar = FontAwesome.Sharp.IconChar.Receipt
        IconButton8.IconColor = Color.Black
        IconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton8.Location = New Point(6, 290)
        IconButton8.Margin = New Padding(3, 2, 3, 2)
        IconButton8.Name = "IconButton8"
        IconButton8.Size = New Size(85, 65)
        IconButton8.TabIndex = 8
        IconButton8.Text = "Registro"
        IconButton8.TextAlign = ContentAlignment.BottomCenter
        IconButton8.UseVisualStyleBackColor = False
        ' 
        ' IconButton7
        ' 
        IconButton7.BackColor = Color.White
        IconButton7.IconChar = FontAwesome.Sharp.IconChar.Tags
        IconButton7.IconColor = Color.Black
        IconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton7.Location = New Point(6, 221)
        IconButton7.Margin = New Padding(3, 2, 3, 2)
        IconButton7.Name = "IconButton7"
        IconButton7.Size = New Size(85, 65)
        IconButton7.TabIndex = 7
        IconButton7.Text = "Categorias"
        IconButton7.TextAlign = ContentAlignment.BottomCenter
        IconButton7.UseVisualStyleBackColor = False
        ' 
        ' IconButton6
        ' 
        IconButton6.BackColor = Color.White
        IconButton6.IconChar = FontAwesome.Sharp.IconChar.NotesMedical
        IconButton6.IconColor = Color.Black
        IconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton6.Location = New Point(6, 152)
        IconButton6.Margin = New Padding(3, 2, 3, 2)
        IconButton6.Name = "IconButton6"
        IconButton6.Size = New Size(85, 65)
        IconButton6.TabIndex = 6
        IconButton6.Text = "Ingresar"
        IconButton6.TextAlign = ContentAlignment.BottomCenter
        IconButton6.UseVisualStyleBackColor = False
        ' 
        ' IconButton4
        ' 
        IconButton4.BackColor = Color.White
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.Barcode
        IconButton4.IconColor = Color.Black
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.Location = New Point(6, 83)
        IconButton4.Margin = New Padding(3, 2, 3, 2)
        IconButton4.Name = "IconButton4"
        IconButton4.Size = New Size(85, 65)
        IconButton4.TabIndex = 5
        IconButton4.Text = "Inventario"
        IconButton4.TextAlign = ContentAlignment.BottomCenter
        IconButton4.UseVisualStyleBackColor = False
        ' 
        ' IconButton3
        ' 
        IconButton3.BackColor = Color.White
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        IconButton3.IconColor = Color.Black
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.Location = New Point(6, 13)
        IconButton3.Margin = New Padding(3, 2, 3, 2)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(85, 65)
        IconButton3.TabIndex = 4
        IconButton3.Text = "Caja"
        IconButton3.TextAlign = ContentAlignment.BottomCenter
        IconButton3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1243, 629)
        Controls.Add(SplitContainer1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(1, 1, 1, 1)
        Name = "Form1"
        Text = "  "
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Nivel2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Nivel3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents VENDER As FontAwesome.Sharp.IconButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents FOLIO As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As DataGridViewTextBoxColumn
    Friend WithEvents HORA As DataGridViewTextBoxColumn
    Friend WithEvents CARGAR As DataGridViewTextBoxColumn
    Friend WithEvents CODE As DataGridViewTextBoxColumn
    Friend WithEvents CONCEPTO As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn

End Class
