'Luis Torres
'RCET0265
'Fall 2020
'Roll of the Dice
'https://github.com/LuisTorres0419/Dice.git
Module Dice

    Sub Main()

        Dim userInput As String
        Dim randomNumber As Integer
        Dim data(12) As Integer
        Dim column, row As Integer

        Console.WriteLine("Press enter to roll if you DARE!!")
        Console.Read()

        Do While userInput <> "Q"
            For i = 1 To 1000
                randomNumber = getRandomNumber(1, 12)
                data(randomNumber) += 1
            Next

            For i = 2 To UBound(data)
                Console.Write("---------")
            Next
            Console.WriteLine()

            For i = 2 To UBound(data)
                Console.Write(i & "|" & vbTab)
            Next
            Console.WriteLine()

            For i = 2 To UBound(data)
                Console.Write("---------")
            Next
            Console.WriteLine()

            For i = 2 To UBound(data)
                Console.Write(data(i) & "|" & vbTab)
            Next

            Console.WriteLine(vbNewLine)
            Console.WriteLine($"Press enter to roll if you DARE!!")
            Console.ReadLine()

            For column = 1 To 12
                data(column) = Nothing
            Next

            'randomNumber = getRandomNumber(3, 10)
            'Console.WriteLine(randomNumber)
            'Console.Read()
            'Console.Clear()
        Loop
    End Sub

    Function getRandomNumber(ByVal minimum As Integer, ByVal maximum As Integer) As Integer
        Dim value As Single
        Randomize()

        Do While value < minimum Or value > maximum
            value = ((maximum - minimum + 1) * Rnd() + minimum)
        Loop
        Return CInt((value))
        'value = CInt(Int((6 * Rnd()) + 1))
        '    Console.WriteLine(value)
        '    Console.WriteLine(Int(value))
        '    Return CInt((value))
    End Function
End Module
