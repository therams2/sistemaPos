<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cambio
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
        Panel1 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOliveGreen
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(IconButton1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 500)
        Panel1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 36F)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(148, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(531, 81)
        Label3.TabIndex = 7
        Label3.Text = "VENTA REALIZADA"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(101, 233)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(607, 124)
        Panel2.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Segoe UI", 36F)
        Label2.ForeColor = Color.Chartreuse
        Label2.Location = New Point(216, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 81)
        Label2.TabIndex = 5
        Label2.Text = "$500"
        ' 
        ' IconButton1
        ' 
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 58
        IconButton1.Location = New Point(257, 378)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(273, 88)
        IconButton1.TabIndex = 3
        IconButton1.Text = "NUEVA VENTA"
        IconButton1.TextAlign = ContentAlignment.BottomCenter
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(257, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(273, 81)
        Label1.TabIndex = 0
        Label1.Text = "CAMBIO:"
        ' 
        ' Cambio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 500)
        ControlBox = False
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Cambio"
        ShowIcon = False
        ShowInTaskbar = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cambio"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
End Class
