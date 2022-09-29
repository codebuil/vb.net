Module Program

    Sub Main()

        'Displays Hello, World
        Console.WriteLine(chr(27)+"[42;30m\n {0}",Rets())

    End Sub
    
    Function Rets()as String
       Return "hello world....."
    End Function

End Module
