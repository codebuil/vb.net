Module Program

    Sub Main()
    Dim n As Integer

        'Displays Hello, World
        for n=0 to 16
        Console.WriteLine(chr(27)+"[42;30m\n {0}",power(2,n))
        Next
         
    End Sub
    
    Function power(a as Integer,b as Integer)as Integer
       Dim aa as Integer=a
       Dim n As Integer
       If b=0 Then Return 1
       If b=1 Then Return a
       For n=1 to b
       aa=aa*a
       Next
      
       Return aa
    End Function

End Module
