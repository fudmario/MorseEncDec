
## Morse Encode/Decode

 Options:

 * Encode 
 * Decode 

 

###Example:
```vbnet
Dim TextEnc As String = MorseEncDec.Morse(word:="EXAMPLE MORSE ENCODE DECODE FUNCTION",
                                    mode:=Morse.Mode.Encode)

Dim TextDec As String = MorseEncDec.Morse(word:=". -..- .- -- .--. .-.. .  -- --- .-. ... .  . -. -.-. --- -.. .  -.. . -.-. --- -.. .  ..-. ..- -. -.-. - .. --- -.",
                                    mode:=Morse.Mode.Decode)

```
