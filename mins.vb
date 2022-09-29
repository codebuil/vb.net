Module Program

    Sub Main()

        'Displays Hello, World
        Console.WriteLine(chr(27)+"[42;30m\n {0}",Mins(20,40))

    End Sub
    
    Function Mins(a as Integer,b as Integer)as Integer
       dim aa as Integer=a
       If aa>b Then aa=b
       Return aa
    End Function

End Module
