Module Program

    Sub Main()

        'Displays Hello, World
        Console.WriteLine("  \x1bc\x1b[42;30m\n {0}",Maxs(20,40))

    End Sub
    
    Function Maxs(a as Integer,b as Integer)as Integer
       dim aa as Integer=a
       If aa<b Then aa=b
       Return aa
    End Function

End Module
