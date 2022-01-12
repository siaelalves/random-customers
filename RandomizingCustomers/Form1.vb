Public Class main
    ' Fórmula para número randômico:
    ' CInt(Math.Floor([valor máximo] - [valor mínimo] + 1) * Rnd() + 1)
    Private qtd As String
    Public Property Quantidade() As Integer
        Get
            Return qtd
        End Get
        Set(ByVal value As Integer)
            qtd = value
        End Set
    End Property

    Function ObterNome() As String
        Dim n As Integer = 0
        n = CInt(Math.Ceiling(Rnd() * 999)) + 0
        Return My.Settings.names(n)
    End Function
    Function ObterCPF() As String
        Dim soma As Integer = 0, resto As Integer = 0
        Dim multiplicador1 As Integer() = New Integer(8) {10, 9, 8, 7, 6, 5,
            4, 3, 2}
        Dim multiplicador2 As Integer() = New Integer(9) {11, 10, 9, 8, 7, 6,
            5, 4, 3, 2}

        Dim semente As String = Math.Floor((999999999 - 100000000 + 1) * Rnd() + 100000000).ToString
        'Dim semente As String = rnd.[Next](100000000, 999999999).ToString()

        For i As Integer = 0 To 8
            soma += Integer.Parse(semente(i).ToString()) * multiplicador1(i)
        Next

        resto = soma Mod 11
        If resto < 2 Then
            resto = 0
        Else
            resto = 11 - resto
        End If

        semente = semente & resto
        soma = 0

        For i As Integer = 0 To 9
            soma += Integer.Parse(semente(i).ToString()) * multiplicador2(i)
        Next

        resto = soma Mod 11

        If resto < 2 Then
            resto = 0
        Else
            resto = 11 - resto
        End If

        semente = semente & resto

        Return semente
    End Function
    Function ObterSexo() As String
        Dim s As Integer = CInt(Math.Floor((2 - 0 + 1) * Rnd())) + 0
        Return My.Settings.sexos(s)
    End Function
    Public Function ObterData(ByVal StartDate) As Date
        'returns random date between start date and now
        If Not IsDate(StartDate) Then Return Today
        Dim dt = CDate(StartDate)
        Dim iDifferential = DateDiff(DateInterval.Day, _
               dt, System.DateTime.Now)
        iDifferential = New Random(System.DateTime.Now.Millisecond). _
                         Next(0, iDifferential)
        dt = DateAdd(DateInterval.Day, iDifferential, dt)
        Return dt.ToString("dd/MM/yy")
    End Function
    Function ObterNúmero() As Integer
        Return CInt(Math.Floor(9999 - 1 + 1) * Rnd() + 1)
    End Function
    Function ObterCidade() As String
        Dim c As Integer = CInt(Math.Floor((2401 - 0 + 1) * Rnd())) + 0
        Return My.Settings.cidades(c)
    End Function
    Function ObterEstado() As String
        Dim e As Integer = CInt(Math.Floor(((My.Settings.estados.Count - 1) - 0 + 1) * Rnd())) + 0
        Return My.Settings.estados(e)
    End Function
    Function ObterCep() As Integer
        Dim e As Integer = CInt(Math.Floor((99999999 - 10000000 + 1) * Rnd())) + 0
        Return e
    End Function
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        dgvCustomers.Rows.Clear()
        Quantidade = txtQtd.Value
        Dim counter As Integer = 0
        Dim p As Integer = 0
        Do Until counter = Quantidade
            Me.Cursor = Cursors.WaitCursor
            dgvCustomers.Rows.Add(ObterNome(), ObterCPF(), ObterSexo(), ObterData(New Date(1980, 1, 1)), _
                                  "Rua " & ObterNome(), ObterNúmero(), ObterNome().Split(" ")(1), ObterCidade(), _
                                  ObterEstado(), ObterCep())
            Me.Cursor = Cursors.Default
            counter += 1
        Loop
    End Sub
End Class
