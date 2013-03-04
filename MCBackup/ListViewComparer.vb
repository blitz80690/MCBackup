Class ListViewComparer
    Implements IComparer

    Private m_ColumnNumber As Integer
    Private m_SortOrder As SortOrder

    Public Sub New(ByVal ColumnNumber As Integer, ByVal SortOrder As SortOrder)
        m_ColumnNumber = ColumnNumber
        m_SortOrder = SortOrder
    End Sub

    Public Function Compare(ByVal X As Object, ByVal Y As Object) As Integer Implements _
        System.Collections.IComparer.Compare
        Dim item_X As ListViewItem = DirectCast(X, ListViewItem)
        Dim item_Y As ListViewItem = DirectCast(Y, ListViewItem)

        Dim String_X As String
        If item_X.SubItems.Count <= m_ColumnNumber Then
            String_X = ""
        Else
            String_X = item_X.SubItems(m_ColumnNumber).Text
        End If

        Dim String_Y As String
        If item_Y.SubItems.Count <= m_ColumnNumber Then
            String_Y = ""
        Else
            String_Y = item_Y.SubItems(m_ColumnNumber).Text
        End If

        If m_SortOrder = SortOrder.Ascending Then
            If IsNumeric(String_X) And IsNumeric(String_Y) Then
                Return Val(String_X).CompareTo(Val(String_Y))
            ElseIf IsDate(String_X) And IsDate(String_Y) Then
                Return DateTime.Parse(String_X).CompareTo(DateTime.Parse(String_Y))
            Else
                Return String.Compare(String_X, String_Y)
            End If
        Else
            If IsNumeric(String_X) And IsNumeric(String_Y) Then
                Return Val(String_Y).CompareTo(Val(String_X))
            ElseIf IsDate(String_X) And IsDate(String_Y) Then
                Return DateTime.Parse(String_Y).CompareTo(DateTime.Parse(String_X))
            Else
                Return String.Compare(String_Y, String_X)
            End If
        End If
    End Function
End Class