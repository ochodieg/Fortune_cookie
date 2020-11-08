'D. Ivan Ochoa
'RCET0265
'Fall 2020
'Multiplication_Table
'https://github.com/ochodieg/Fortune_cookie
Option Strict On
Option Compare Text
Option Explicit On
Module Fortune_Cookie 'PascalCase - TJR
    Sub Main()
        Dim randomNumber As Integer
        Randomize() ' This should be in the random number method - TJR
        Do
            Console.WriteLine("Press Enter for ~FORTUNE~.")
            Console.ReadLine()
            randomNumber = GetRandomNumber(1, 2)
            If randomNumber = 1 Then
                Console.WriteLine("Your fortune.....YOU WILL PASS")
            ElseIf randomNumber = 2 Then
                Console.WriteLine("Your fortune.....YOU SHALL NOT PASS")
            ElseIf randomNumber = 3 Then
                Console.WriteLine("Avoid high calorie foods...... don't you love when fortune cookies are really just 
advice cookies?") ' long line - TJR
            End If
            Console.ReadLine()
            Console.Clear()
        Loop
    End Sub
    Function GetRandomNumber(ByVal minimum As Integer, ByVal maximum As Integer) As Integer
        Dim value As Single
        value = ((maximum - minimum + 1) * Rnd()) + minimum
        Return CInt(value)
    End Function
End Module
