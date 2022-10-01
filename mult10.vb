Module Program
    Function mults(a As Long,b As Long)
        Return a*b
    End Function
    Sub Main()
        Dim n As Integer
        Dim m As Long=1
        
        'Displays Hello, World
        Console.WriteLine(chr(27)+"[42;30m]Hello, World!")
        For n=0 to 17
            Console.WriteLine("d{0}",m)
            Console.WriteLine("h{0:x}",m)
            m=mults(m,10)
        Next

    End Sub
    

End Module
