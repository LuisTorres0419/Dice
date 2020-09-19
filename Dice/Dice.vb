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
            randomNumber = getRandomNumber(1, 15)
            Console.Write(randomNumber)
            Console.Read()
            Console.Clear()
        Loop
    End Sub

    Function getRandomNumber(ByVal minimum As Integer, ByVal Maximum As Integer) As Integer
        Dim value As Single
        Randomize()
        value = CInt(Int((6 * Rnd()) + 1))
        Console.Write(value)
        Console.WriteLine(Int(value))
        Return CInt((value))
    End Function
End Module
