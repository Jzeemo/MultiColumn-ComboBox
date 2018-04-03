Imports System.Windows
Imports System.Drawing.Drawing2D
Public Class MultiColumnCombo
    Inherits ComboBox
    Private DoNotReact As Boolean = False
    Private TextHasChanged As Boolean = False
    Private _ColumnNameArray As ArrayList = New ArrayList()
    Private _ColumnNameString As String = ""
    Private _BackGroundDarkColor As Color = SystemColors.Highlight
    Private _BackGroundLightColor As Color = SystemColors.Highlight


    Sub New()
        MyBase.New()
        MyBase.DrawMode = Forms.DrawMode.Normal
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
        _ColumnNameArray = New ArrayList()
    End Sub

    Public Property BackGroundDarkColor As Color
        Get
            Return _BackGroundDarkColor
        End Get
        Set(value As Color)
            _BackGroundDarkColor = value
        End Set
    End Property

    Public Property BackGroundLightColor As Color
        Get
            Return _BackGroundLightColor
        End Get
        Set(value As Color)
            _BackGroundLightColor = value
        End Set
    End Property


    Public Property ColumnNameList() As String
        Get
            Return _ColumnNameString
        End Get
        Set(value As String)
            If value.Contains(";") Then
                Dim temparray As String() = value.Split(CType(";", Char))
                Dim FinalWidth As Integer = 0
                For Each temp As String In temparray
                    If temp.Length <= 0 Or Not temp.Contains(":") Then
                        Continue For
                    End If
                    Dim testarray As String() = temp.Split(":")
                    If testarray.Length = 2 Then
                        FinalWidth += CInt(testarray(1))
                        _ColumnNameArray.Add(temp)
                    End If

                Next
                MyBase.DropDownWidth = FinalWidth + 10
            Else
                If value.Contains(":") Then
                    Dim testarray As String() = value.Split(":")
                    If testarray.Length = 2 Then
                        _ColumnNameArray.Add(value)
                    End If
                End If
            End If

        End Set
    End Property


    <System.Diagnostics.DebuggerStepThrough()>
    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)

        Dim myBrush As Brush
        Dim LightColor As Color = _BackGroundLightColor
        Dim DarkColor As Color = _BackGroundDarkColor
        Dim GradBrush As Brush = New LinearGradientBrush(e.Bounds,
                                                         LightColor,
                                                         DarkColor,
                                                         LinearGradientMode.Horizontal)
        Select Case CInt((e.State And DrawItemState.Selected))
            Case DrawItemState.Selected
                myBrush = New SolidBrush(BackColor)
                e.Graphics.FillRectangle(GradBrush, e.Bounds)
            Case Else
                myBrush = New SolidBrush(ForeColor)
                e.Graphics.FillRectangle(New SolidBrush(BackColor), e.Bounds)
        End Select
        Dim str As String
        ' Draw the current item text based on the current Font and the custom brush settings.
        Dim row As DataRowView = (CType(MyBase.Items(e.Index), DataRowView))
        Dim newpos As Integer = e.Bounds.X
        Dim endpos As Integer = e.Bounds.X

        If _ColumnNameArray Is Nothing Or (_ColumnNameArray.Count <= 0) Then
            Dim rr As RectangleF = New RectangleF(e.Bounds.X,
                                                         e.Bounds.Y,
                                                         e.Bounds.Width,
                                                         e.Bounds.Height)

            Dim displaymember As String = row.Item(MyBase.DisplayMember).ToString()
            e.Graphics.DrawString(displaymember, e.Font, myBrush, rr)

        Else
            Dim columncount As Integer = 1
            For Each index As String In _ColumnNameArray
                Dim columnarray As String() = index.Split(":")
                Dim ColLength As Integer = CType(columnarray(1), Integer)
                endpos += ColLength
                Dim Charaant As Integer = CInt(Math.Round(CDbl(ColLength) / 6.2))
                Dim rawitem As String = row.Item(columnarray(0).ToString()).ToString()

                If ColLength <> 0 Then
                    If Charaant > rawitem.Length Then
                        str = rawitem
                    Else
                        str = rawitem.Substring(0, Charaant)
                    End If
                    Dim r As RectangleF = New RectangleF(newpos + 2,
                                                         e.Bounds.Y,
                                                         endpos - 1,
                                                         e.Bounds.Height)
                    e.Graphics.DrawString(str, e.Font, myBrush, r)

                    If columncount < _ColumnNameArray.Count Then
                        e.Graphics.DrawLine(New Pen(Color.Gray),
                                            endpos + 1,
                                            e.Bounds.Y, endpos + 1,
                                            Me.ItemHeight * Me.MaxDropDownItems
                                            )
                    End If
                End If
                columncount = columncount + 1
                newpos = endpos
            Next
        End If
        '  e.DrawFocusRectangle()
        myBrush.Dispose()
        GradBrush.Dispose()
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        Dim foundIndex As Integer, textlngth As Integer

        Try
            If DoNotReact = False Then
                DoNotReact = False
            End If

            If TextHasChanged = False Then
                TextHasChanged = False
            End If

            If DoNotReact = False Then
                If Me.AccessibilityObject.Value Is Nothing Then
                    textlngth = 0
                    Exit Sub
                Else
                    textlngth = Me.AccessibilityObject.Value.Length
                End If
                If textlngth = 0 Then
                    MyBase.OnTextChanged(e)
                    DoNotReact = False
                    TextHasChanged = False
                    Exit Sub
                End If
                If textlngth <> 0 Then
                    DoNotReact = True
                    foundIndex = FindString(Me.AccessibilityObject.Value)
                    If foundIndex > -1 Then
                        Me.SelectedIndex = foundIndex
                        Me.Select(textlngth, Me.Text.Length - textlngth)
                        'Me.SelectionStart = textlngth
                        TextHasChanged = True
                    Else
                        TextHasChanged = False
                    End If
                    DoNotReact = False
                End If
                MyBase.OnTextChanged(e)
            End If
            DoNotReact = False
        Catch ex As Exception
            DoNotReact = False
            TextHasChanged = False
        End Try



    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Back, Keys.Enter, Keys.Delete
                DoNotReact = True
            Case Keys.Down
                Me.DroppedDown = True
                Invalidate()
        End Select
        MyBase.OnKeyDown(e)
    End Sub

End Class
