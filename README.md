
## Morse Encode/Decode

 Options:

 * Encode :+1:
 * Decode :+1:

 

###Example:
```vbnet
Dim TextEnc As String = Morse.Morse(word:="EXAMPLE MORSE ENCODE DECODE FUNCTION",
                                    mode:=Morse.Mode.Encode)

Dim TextDec As String = Morse.Morse(word:=". -..- .- -- .--. .-.. .  -- --- .-. ... .  . -. -.-. --- -.. .  -.. . -.-. --- -.. .  ..-. ..- -. -.-. - .. --- -.",
                                    mode:=Morse.Mode.Decode)

```
