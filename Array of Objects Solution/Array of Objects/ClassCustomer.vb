Public Class ClassCustomer
    Private _IDnumber As String
    Public Property IDnumber() As String
        Get
            Return _IDnumber
        End Get
        Set(ByVal value As String)
            _IDnumber = value
        End Set
    End Property

    Private _FulleName As String
    Public Property FullName() As String
        Get
            Return _FulleName
        End Get
        Set(ByVal value As String)
            _FulleName = value
        End Set
    End Property

    Private _UnitsUsed As Integer
    Public Property UnitUsed() As Integer
        Get
            Return _UnitsUsed
        End Get
        Set(ByVal value As Integer)
            _UnitsUsed = value
        End Set
    End Property

    Public Sub New()
        IDnumber = ""
        FullName = ""
        UnitUsed = 0
    End Sub

    Public Sub New(ByVal theIDnumber As String, ByVal theFullName As String, ByVal theUnitsUsed As Integer)
        IDnumber = theIDnumber
        FullName = theFullName
        UnitUsed = theUnitsUsed
    End Sub

    Public Function CalcPayment() As Double
        Dim dblAmountDue As Double
        Dim dblRate As Double

        If UnitUsed <= 100 Then
            dblRate = 2
        Else
            If UnitUsed <= 250 Then
                dblRate = 2.5
            Else
                dblRate = 2.85
            End If
        End If

        dblAmountDue = UnitUsed * dblRate

        Return dblAmountDue
    End Function

    Public Overrides Function ToString() As String
        Return IDnumber & "," & FullName & "," & UnitUsed.ToString & "," & CalcPayment.ToString("F2")
    End Function

End Class
