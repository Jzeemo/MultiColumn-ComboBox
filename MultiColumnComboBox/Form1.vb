Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Country1, Country2, Country3, Country4 As New DataTable
        Country1.Columns.Add("ID", GetType(String))
        Country1.Columns.Add("Country", GetType(String))
        Country1.Columns.Add("City", GetType(String))
        Country1.Rows.Add("M", "Myanmar", "Yangon")
        Country1.Rows.Add("T", "Thailand", "Bankok")
        Country1.Rows.Add("U", "USA", "NY")
        Country1.Rows.Add("S", "Singapore", "Shit")


        MultiColumnCombo1.DataSource = Country1
        MultiColumnCombo1.DrawMode = DrawMode.OwnerDrawVariable
        MultiColumnCombo1.ColumnNameList = "ID:50;Country:120"
        MultiColumnCombo1.ValueMember = "ID"

        Country2 = Country1.Copy
        MultiColumnCombo2.DataSource = Country2
        MultiColumnCombo2.DrawMode = DrawMode.OwnerDrawVariable
        MultiColumnCombo2.ColumnNameList = "ID:50;Country:120;City:200"
        MultiColumnCombo2.ValueMember = "ID"

        Country3 = Country1.Copy
        MultiColumnCombo3.DataSource = Country3
        MultiColumnCombo3.DisplayMember = "Country"
        MultiColumnCombo3.ValueMember = "ID"

        Country4 = Country1.Copy
        MultiColumnCombo4.DataSource = Country4
        MultiColumnCombo4.DrawMode = DrawMode.OwnerDrawVariable
        MultiColumnCombo4.BackGroundDarkColor = Color.Blue
        MultiColumnCombo4.BackGroundLightColor = Color.BlueViolet
        MultiColumnCombo4.ColumnNameList = "ID:50;Country:120"
        MultiColumnCombo4.ValueMember = "ID"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(MultiColumnCombo1.SelectedValue)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(MultiColumnCombo2.SelectedValue)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(MultiColumnCombo3.SelectedValue)
    End Sub
End Class