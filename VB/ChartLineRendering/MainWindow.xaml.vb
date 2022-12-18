Imports System
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace ChartLineRendering

    Public Partial Class MainWindow
        Inherits Window

        Const count As Integer = 20000

        Private ReadOnly rnd As Random = New Random()

        Public Property LineData As ObservableCollection(Of Point)

        Public Property SplineData As ObservableCollection(Of Point)

        Public Sub New()
            Me.InitializeComponent()
            GenerateData(count)
            DataContext = Me
        End Sub

        Private Sub GenerateData(ByVal count As Integer)
            Dim lineData As ObservableCollection(Of Point) = New ObservableCollection(Of Point)()
            Dim splineData As ObservableCollection(Of Point) = New ObservableCollection(Of Point)()
            For i As Integer = 0 To count - 1
                lineData.Add(New Point(i, Math.Sin(i \ 20)))
                If i Mod 25 = 0 Then splineData.Add(New Point(i, rnd.Next(10, 20)))
            Next

            Me.LineData = lineData
            Me.SplineData = splineData
        End Sub
    End Class
End Namespace
