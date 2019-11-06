# HConvertToText
Libereria que convierte de numero, fecha, hora, minuto a letras

# Metodos

### NumberToText(decimal Valor)

###  HoursToText(DateTime date)

### DateToText(DateTime date)


1. Instancie la clase 'ConvertDateandNum'

1.1 De Numero a letras
```cs
 var Convert = new ConvertDateandNum();
 
 var Texto = Convert.NumberToText(2019);
 
 Console.WriteLine(Texto);
 // Salida: dos mil diecienueve
```

1.2 De Hora a letras
```cs
 var Date = DateTime.Now;
 var Convert = new ConvertDateandNum();
 
 var Texto = Convert.HoursToText(Date);
 
 Console.WriteLine(Texto);
 // Salida:  a las dos hora con treinta minutos de la tarde ò de la mañana
```
1.3 De Hora a letras
```cs
 var Date = DateTime.Now;
 var Convert = new ConvertDateandNum();
 
 var Texto = Convert.DateToText(Date);
 
 Console.WriteLine(Texto);
 // Salida:  a los veinte días del mes de Junio  del año mil novecientos noventa y uno
```
