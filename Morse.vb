Public NotInheritable Class MorseEncDec
    Public Enum Mode As Integer
        [Encode] = 0I
        [Decode] = 1I
    End Enum
    Public Shared Function Morse(ByVal word As String, mode As Mode) As String
        Dim res As String = String.Empty
        Dim dic As Dictionary(Of String, String)
        dic = New Dictionary(Of String, String) From
                    {
                        {"A", ".-"},
                        {"B", "-..."},
                        {"C", "-.-."},
                        {"D", "-.."},
                        {"E", "."},
                        {"F", "..-."},
                        {"G", "--."},
                        {"H", "...."},
                        {"I", ".."},
                        {"J", ".---"},
                        {"K", "-.-"},
                        {"L", ".-.."},
                        {"M", "--"},
                        {"N", "-."},
                        {"Ñ", "--.--"},
                        {"O", "---"},
                        {"P", ".--."},
                        {"Q", "--.-"},
                        {"R", ".-."},
                        {"S", "..."},
                        {"T", "-"},
                        {"U", "..-"},
                        {"V", "...-"},
                        {"W", ".--"},
                        {"X", "-..-"},
                        {"Y", "-.--"},
                        {"Z", "--.."},
                        {"Ä", ".-.-"},
                        {"Ö", "---."},
                        {"Ü", "..--"},
                        {" ", ""},
                        {"0", "-----"},
                        {"1", ".----"},
                        {"2", "..---"},
                        {"3", "...--"},
                        {"4", "....-"},
                        {"5", "....."},
                        {"6", "-...."},
                        {"7", "--..."},
                        {"8", "---.."},
                        {"9", "----."},
                        {".", ".-.-.-"},
                        {",", "--..--"},
                        {"?", "..--.."},
                        {"!", "..--."},
                        {":", "---..."},
                        {"""", ".-..-."},
                        {"'", ".----."},
                        {"-", "-....-"},
                        {"=", "-...-"}
                    }
        Select Case mode
            Case Mode.Encode
                Dim arrWord As IEnumerable(Of Char) = word.ToUpper().ToCharArray()
                Return ((From mStr In arrWord Where dic.ContainsKey(mStr)).Aggregate(res, Function(x, mStr) String.Format("{0} {1}", x, dic.Item(mStr)))).Trim()
            Case Mode.Decode
                Return ((From letter In word.Split(" "c) Select dic.Where(Function(pair) pair.Value = letter).Select(Function(pair) pair.Key).FirstOrDefault()).Aggregate(res, Function(x, key) String.Format("{0}{1}", x, key))).Trim()
        End Select
        Return String.Empty
    End Function

End Class
