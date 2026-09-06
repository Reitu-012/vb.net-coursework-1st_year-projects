Public Class ClassStudents
    Private _StdNo As String
    Public Property StdNo() As String
        Get
            Return _StdNo
        End Get
        Set(ByVal value As String)
            _StdNo = value
        End Set
    End Property

    Private _Surname As String
    Public Property Surname() As String
        Get
            Return _Surname
        End Get
        Set(ByVal value As String)
            _Surname = value
        End Set
    End Property

    Private _Test1 As Integer
    Public Property Test1() As Integer
        Get
            Return _Test1
        End Get
        Set(ByVal value As Integer)
            _Test1 = value
        End Set
    End Property

    Private _Test2 As Integer
    Public Property Test2() As Integer
        Get
            Return _Test2
        End Get
        Set(ByVal value As Integer)
            _Test2 = value
        End Set
    End Property

    Public Sub New()
        StdNo = ""
        Surname = ""
        Test1 = 0
        Test2 = 0
    End Sub

    Public Sub New(ByVal theStdNo As String, ByVal theSurname As String, ByVal theTest1 As Integer, ByVal theTest2 As Integer)
        StdNo = theStdNo
        Surname = theSurname
        Test1 = theTest1
        Test2 = theTest2
    End Sub

    Public Function CalcAverage() As Double
        Dim dblAverage As Double
        Dim intTotal As Integer

        intTotal = Test1 + Test2
        dblAverage = intTotal / 2

        Return dblAverage
    End Function

    Public Overrides Function ToString() As String
        Return StdNo & "," & Surname & "," & Test1.ToString & "," & Test2.ToString & "," & CalcAverage.ToString("F2")
    End Function

End Class
