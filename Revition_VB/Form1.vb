Imports System.Threading.Tasks.Sources

Module ArrayNames
    Public arrnames() As String = {"Alice", "Bob", "Charlie", "Diana", "Eve", "Frank", "Grace", "Hannah", "Ivy", "Jack"}
End Module



Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arrNum() As Integer = {3, 7, 2, 6, 1, 8, 3, 8, 3}
        Dim iTotal As Integer

        iTotal = 0

        For i = 0 To (arrNum.Length - 1)
            iTotal = iTotal + arrNum(i)
        Next

        Label1.Text = "Total : " + iTotal.ToString


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        For i = 0 To (arrnames.Length - 1)
            ListBox1.Items.Add(arrnames(i))

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        For i = (arrnames.Length - 1) To 0 Step -1
            ListBox1.Items.Add(arrnames(i))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim arrNum(,) As Integer = {{1, 4, 7, 9}, {2, 6, 8, 2}, {7, 2, 8, 6}}
        Dim iTotal As Integer
        iTotal = 0

        For i = 0 To 2
            For j = 0 To 3
                iTotal = iTotal + arrNum(i, j)
            Next
        Next

        TextBox1.Text = "Toatal : " + iTotal.ToString

    End Sub


    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        ListBox1.Items.Clear()
        For i = 0 To (arrnames.Length - 1)
            ListBox2.Items.Add(arrnames(i))

        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sname As String
        Dim Flag As Boolean
        sname = TextBox2.Text
        Flag = False

        For i = 0 To (arrnames.Length - 1)
            If sname.ToUpper = arrnames(i).ToUpper Then
                MessageBox.Show("Name Found")
                Flag = True
                Exit For
            End If
        Next

        If Flag = False Then
            MessageBox.Show("Name Not Found")
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListBox3.Items.Clear()
        For i = 0 To (arrnames.Length - 1)
            ListBox3.Items.Add(arrnames(i))

        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        ListBox3.Items.Clear()
        Array.Sort(arrnames)
        For i = (arrnames.Length - 1) To 0 Step -1
            ListBox3.Items.Add(arrnames(i))
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim inum, leng As Integer

        inum = NumericUpDown1.Value
        leng = NumericUpDown2.Value

        ListBox4.Items.Clear()
        ListBox4.Items.Add("MY MULTIPLICATION TABLE")
        ListBox4.Items.Add("")

        For i = 1 To leng
            ListBox4.Items.Add(inum.ToString() & " x " & i.ToString() & " = " & (inum * i).ToString())
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim inum As Integer
        Dim Fac As Integer
        Dim i As Integer

        inum = Val(TextBox3.Text)
        Fac = 1
        i = 1

        While i < inum
            i = i + 1
            Fac = Fac * i
        End While


        TextBox4.Text = Fac.ToString

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim age As Integer

        age = Val(TextBox6.Text)
        If age > 18 Then
            Label2.Text = "Egible age"
        Else
            Label2.Text = "Not Egible"
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim inum As Integer
        inum = Val(TextBox5.Text)

        Select Case inum
            Case Is > 0
                Label3.Text = "Positive number"
            Case Is < 0
                Label3.Text = "Neggative number"
            Case = 0
                Label3.Text = "Number is 0"
        End Select



    End Sub

    Private Sub CalculateAverage(arr() As Integer, ByRef sum As Integer)
        For i = 0 To (arr.Length - 1)
            sum = sum + arr(i)
        Next
    End Sub


    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim arrNum() As Integer = {3, 7, 2, 6, 1, 8, 3, 8, 3}
        Dim sum As Integer = 0
        Dim average As Double

        CalculateAverage(arrNum, sum)

        average = sum / arrNum.Length

        MessageBox.Show("The average is: " & average)
    End Sub

    Function Swap(sword As String) As String
        Dim snew As String = ""

        For i As Integer = sword.Length - 1 To 0 Step -1
            snew &= sword(i)
        Next

        Return snew
    End Function

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim sinput As String
        sinput = TextBox8.Text
        TextBox7.Text = Swap(sinput)
    End Sub


End Class
