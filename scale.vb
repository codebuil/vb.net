Module Program

    Function scale0_20(a As Double)As Double
        Dim b As Double=a
        If a<0.00 Then b=0.00
        If b>20.00 Then b=20.00
        b=b*5.00
        Return b  
    End Function
    Sub Main()

        Dim n as Double
        For n = 0.00 To 20.00
           Console.WriteLine(Chr(27)+"[42;30m {0} ",scale0_20(n))
        Next
       

    End Sub
    

End Module
