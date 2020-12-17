Imports System
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace ChartLineRendering
	Partial Public Class MainWindow
		Inherits Window

		Private Const count As Integer = 20000
		Private ReadOnly rnd As New Random()

		Public Property LineData() As ObservableCollection(Of Point)
		Public Property SplineData() As ObservableCollection(Of Point)

		Public Sub New()
			InitializeComponent()
			GenerateData(count)
			Me.DataContext = Me
		End Sub

		Private Sub GenerateData(ByVal count As Integer)
'INSTANT VB NOTE: The variable lineData was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim lineData_Conflict As New ObservableCollection(Of Point)()
'INSTANT VB NOTE: The variable splineData was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim splineData_Conflict As New ObservableCollection(Of Point)()
			For i As Integer = 0 To count - 1
				lineData_Conflict.Add(New Point(i, Math.Sin(i \ 20)))
				If i Mod 25 = 0 Then
					splineData_Conflict.Add(New Point(i, rnd.Next(10, 20)))
				End If
			Next i
			LineData = lineData_Conflict
			SplineData = splineData_Conflict
		End Sub
	End Class
End Namespace
