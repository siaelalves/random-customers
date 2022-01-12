<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.txtQtd = New System.Windows.Forms.NumericUpDown()
        Me.colNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(12, 12)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "Iniciar"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'dgvCustomers
        '
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNm, Me.colCpf, Me.colSexo, Me.colDt, Me.colRua, Me.colNum, Me.colBa, Me.colCid, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19})
        Me.dgvCustomers.Location = New System.Drawing.Point(12, 41)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.Size = New System.Drawing.Size(915, 403)
        Me.dgvCustomers.TabIndex = 1
        '
        'txtQtd
        '
        Me.txtQtd.Location = New System.Drawing.Point(93, 15)
        Me.txtQtd.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtQtd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(120, 20)
        Me.txtQtd.TabIndex = 2
        Me.txtQtd.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'colNm
        '
        Me.colNm.HeaderText = "Nome"
        Me.colNm.Name = "colNm"
        '
        'colCpf
        '
        Me.colCpf.HeaderText = "CPF"
        Me.colCpf.Name = "colCpf"
        '
        'colSexo
        '
        Me.colSexo.HeaderText = "Sexo"
        Me.colSexo.Name = "colSexo"
        '
        'colDt
        '
        Me.colDt.HeaderText = "Data"
        Me.colDt.Name = "colDt"
        '
        'colRua
        '
        Me.colRua.HeaderText = "Rua"
        Me.colRua.Name = "colRua"
        '
        'colNum
        '
        Me.colNum.HeaderText = "Número"
        Me.colNum.Name = "colNum"
        '
        'colBa
        '
        Me.colBa.HeaderText = "Bairro"
        Me.colBa.Name = "colBa"
        '
        'colCid
        '
        Me.colCid.HeaderText = "Cidade"
        Me.colCid.Name = "colCid"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Column9"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Column10"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Column11"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Column12"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Column13"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Column14"
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        Me.Column15.HeaderText = "Column15"
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        Me.Column16.HeaderText = "Column16"
        Me.Column16.Name = "Column16"
        '
        'Column17
        '
        Me.Column17.HeaderText = "Column17"
        Me.Column17.Name = "Column17"
        '
        'Column18
        '
        Me.Column18.HeaderText = "Column18"
        Me.Column18.Name = "Column18"
        '
        'Column19
        '
        Me.Column19.HeaderText = "Column19"
        Me.Column19.Name = "Column19"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 456)
        Me.Controls.Add(Me.txtQtd)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.cmdStart)
        Me.DoubleBuffered = True
        Me.Name = "main"
        Me.Text = "S-Random Records"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents dgvCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents txtQtd As System.Windows.Forms.NumericUpDown
    Friend WithEvents colNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCpf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
