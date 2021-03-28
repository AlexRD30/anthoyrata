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
        Me.cmdcalcular = New System.Windows.Forms.Button()
        Me.cmdlimpiar = New System.Windows.Forms.Button()
        Me.cmdsalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSueldo = New System.Windows.Forms.TextBox()
        Me.Txtsueldoneto = New System.Windows.Forms.TextBox()
        Me.TxtpresioH = New System.Windows.Forms.TextBox()
        Me.Txthora = New System.Windows.Forms.TextBox()
        Me.rbndiurno = New System.Windows.Forms.RadioButton()
        Me.rbnnocturno = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAFP = New System.Windows.Forms.TextBox()
        Me.ChkAFP = New System.Windows.Forms.CheckBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.ChkARS = New System.Windows.Forms.CheckBox()
        Me.ChKOtros = New System.Windows.Forms.CheckBox()
        Me.TxtARS = New System.Windows.Forms.TextBox()
        Me.TxtOtros = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'cmdcalcular
        '
        Me.cmdcalcular.Font = New System.Drawing.Font("Calibri", 9!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdcalcular.Location = New System.Drawing.Point(46, 415)
        Me.cmdcalcular.Name = "cmdcalcular"
        Me.cmdcalcular.Size = New System.Drawing.Size(75, 23)
        Me.cmdcalcular.TabIndex = 0
        Me.cmdcalcular.Text = "Calcular"
        Me.cmdcalcular.UseVisualStyleBackColor = true
        '
        'cmdlimpiar
        '
        Me.cmdlimpiar.Font = New System.Drawing.Font("Calibri", 9!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdlimpiar.Location = New System.Drawing.Point(195, 415)
        Me.cmdlimpiar.Name = "cmdlimpiar"
        Me.cmdlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdlimpiar.TabIndex = 1
        Me.cmdlimpiar.Text = "Limpiar"
        Me.cmdlimpiar.UseVisualStyleBackColor = true
        '
        'cmdsalir
        '
        Me.cmdsalir.Font = New System.Drawing.Font("Calibri", 9!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdsalir.Location = New System.Drawing.Point(330, 415)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdsalir.TabIndex = 2
        Me.cmdsalir.Text = "Salir"
        Me.cmdsalir.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sueldo Base"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hora Extra"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio Hora"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 379)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Sueldo Neto"
        '
        'TxtSueldo
        '
        Me.TxtSueldo.Font = New System.Drawing.Font("Calibri", 11.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.World, CType(0, Byte), True)
        Me.TxtSueldo.Location = New System.Drawing.Point(93, 36)
        Me.TxtSueldo.Name = "TxtSueldo"
        Me.TxtSueldo.Size = New System.Drawing.Size(100, 22)
        Me.TxtSueldo.TabIndex = 11
        '
        'Txtsueldoneto
        '
        Me.Txtsueldoneto.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsueldoneto.Location = New System.Drawing.Point(114, 376)
        Me.Txtsueldoneto.Name = "Txtsueldoneto"
        Me.Txtsueldoneto.Size = New System.Drawing.Size(100, 23)
        Me.Txtsueldoneto.TabIndex = 12
        '
        'TxtpresioH
        '
        Me.TxtpresioH.Font = New System.Drawing.Font("Calibri", 11.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.TxtpresioH.Location = New System.Drawing.Point(93, 104)
        Me.TxtpresioH.Name = "TxtpresioH"
        Me.TxtpresioH.Size = New System.Drawing.Size(100, 22)
        Me.TxtpresioH.TabIndex = 17
        '
        'Txthora
        '
        Me.Txthora.Font = New System.Drawing.Font("Calibri", 11.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Txthora.Location = New System.Drawing.Point(93, 69)
        Me.Txthora.Name = "Txthora"
        Me.Txthora.Size = New System.Drawing.Size(100, 22)
        Me.Txthora.TabIndex = 18
        '
        'rbndiurno
        '
        Me.rbndiurno.AutoSize = True
        Me.rbndiurno.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbndiurno.ForeColor = System.Drawing.Color.Black
        Me.rbndiurno.Location = New System.Drawing.Point(323, 36)
        Me.rbndiurno.Name = "rbndiurno"
        Me.rbndiurno.Size = New System.Drawing.Size(101, 19)
        Me.rbndiurno.TabIndex = 19
        Me.rbndiurno.TabStop = True
        Me.rbndiurno.Text = "Sueldo Diurno"
        Me.rbndiurno.UseVisualStyleBackColor = True
        '
        'rbnnocturno
        '
        Me.rbnnocturno.AutoSize = True
        Me.rbnnocturno.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnnocturno.ForeColor = System.Drawing.Color.Black
        Me.rbnnocturno.Location = New System.Drawing.Point(323, 71)
        Me.rbnnocturno.Name = "rbnnocturno"
        Me.rbnnocturno.Size = New System.Drawing.Size(113, 19)
        Me.rbnnocturno.TabIndex = 20
        Me.rbnnocturno.TabStop = True
        Me.rbnnocturno.Text = "Precio Nocturno"
        Me.rbnnocturno.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtAFP)
        Me.GroupBox1.Controls.Add(Me.ChkAFP)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.ChkARS)
        Me.GroupBox1.Controls.Add(Me.ChKOtros)
        Me.GroupBox1.Controls.Add(Me.TxtARS)
        Me.GroupBox1.Controls.Add(Me.TxtOtros)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Location = New System.Drawing.Point(34, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 190)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descuentos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(9, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 14)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Total Desc"
        '
        'TxtAFP
        '
        Me.TxtAFP.Font = New System.Drawing.Font("Calibri", 11.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.TxtAFP.Location = New System.Drawing.Point(80, 19)
        Me.TxtAFP.Name = "TxtAFP"
        Me.TxtAFP.Size = New System.Drawing.Size(100, 22)
        Me.TxtAFP.TabIndex = 16
        '
        'ChkAFP
        '
        Me.ChkAFP.AutoSize = True
        Me.ChkAFP.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAFP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ChkAFP.Location = New System.Drawing.Point(15, 22)
        Me.ChkAFP.Name = "ChkAFP"
        Me.ChkAFP.Size = New System.Drawing.Size(45, 18)
        Me.ChkAFP.TabIndex = 21
        Me.ChkAFP.Text = "AFP"
        Me.ChkAFP.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Calibri", 11.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(80, 142)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotal.TabIndex = 13
        '
        'ChkARS
        '
        Me.ChkARS.AutoSize = True
        Me.ChkARS.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkARS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ChkARS.Location = New System.Drawing.Point(12, 61)
        Me.ChkARS.Name = "ChkARS"
        Me.ChkARS.Size = New System.Drawing.Size(46, 18)
        Me.ChkARS.TabIndex = 22
        Me.ChkARS.Text = "ARS"
        Me.ChkARS.UseVisualStyleBackColor = True
        '
        'ChKOtros
        '
        Me.ChKOtros.AutoSize = True
        Me.ChKOtros.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChKOtros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ChKOtros.Location = New System.Drawing.Point(12, 96)
        Me.ChKOtros.Name = "ChKOtros"
        Me.ChKOtros.Size = New System.Drawing.Size(53, 18)
        Me.ChKOtros.TabIndex = 23
        Me.ChKOtros.Text = "Otros"
        Me.ChKOtros.UseVisualStyleBackColor = True
        '
        'TxtARS
        '
        Me.TxtARS.Font = New System.Drawing.Font("Calibri", 11.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.TxtARS.Location = New System.Drawing.Point(80, 58)
        Me.TxtARS.Name = "TxtARS"
        Me.TxtARS.Size = New System.Drawing.Size(100, 22)
        Me.TxtARS.TabIndex = 15
        '
        'TxtOtros
        '
        Me.TxtOtros.Font = New System.Drawing.Font("Calibri", 11.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.TxtOtros.Location = New System.Drawing.Point(80, 93)
        Me.TxtOtros.Name = "TxtOtros"
        Me.TxtOtros.Size = New System.Drawing.Size(100, 22)
        Me.TxtOtros.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbndiurno)
        Me.GroupBox2.Controls.Add(Me.rbnnocturno)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtpresioH)
        Me.GroupBox2.Controls.Add(Me.Txthora)
        Me.GroupBox2.Controls.Add(Me.TxtSueldo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 142)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Ingresos"
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(510, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Txtsueldoneto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdlimpiar)
        Me.Controls.Add(Me.cmdcalcular)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Calculo de Nomina"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmdcalcular As System.Windows.Forms.Button
    Friend WithEvents cmdlimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdsalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSueldo As System.Windows.Forms.TextBox
    Friend WithEvents Txtsueldoneto As System.Windows.Forms.TextBox
    Friend WithEvents TxtpresioH As System.Windows.Forms.TextBox
    Friend WithEvents Txthora As System.Windows.Forms.TextBox
    Friend WithEvents rbndiurno As System.Windows.Forms.RadioButton
    Friend WithEvents rbnnocturno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtAFP As System.Windows.Forms.TextBox
    Friend WithEvents ChkAFP As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents ChkARS As System.Windows.Forms.CheckBox
    Friend WithEvents ChKOtros As System.Windows.Forms.CheckBox
    Friend WithEvents TxtARS As System.Windows.Forms.TextBox
    Friend WithEvents TxtOtros As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
