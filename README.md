# HConvertToText
Libereria que convierte de numero, fecha, hora, minuto a texto
# Metodos
### NumberToText(decimal Valor)
```cs
NumberToText(decimal Valor);

//Convierte de numero a texto
```

###  HoursToText(DateTime date)
```cs
HoursToText(DateTime date);

Convierte hora a texto. -
 ejemplo: ( a las 'dos' hora con 'treinta' minutos  'de la tarde ò de la mañana' )
```

### DateToText(DateTime date)
```cs
DateToText(DateTime date);

ejemplo: ( a los 'veinte' días del mes de 'Junio'  del año 'mil novecientos noventa y uno' )
```
Convierte fecha a texto

## Ejemplo

Para obtener la DLL descargue el fuente y copile, vaya a la carpeta bin del proyecto.

1. Agregue la referencia(dll) en su proyecto.

2. importe la libreria en la clase donde la usara.
```cs
    using HConvertToText;
```

3. Instancie la clase 'ConvertDateandNum'

3.1 De Numero a letras
```cs
 var Convert = new ConvertDateandNum();
 
 var Texto = Convert.NumberToText(2019);
 
 Console.WriteLine(Texto);
 // Salida: dos mil diecienueve
```

3.2 De Hora a letras
```cs
 var Date = DateTime.Now;
 var Convert = new ConvertDateandNum();
 
 var Texto = Convert.HoursToText(Date);
 
 Console.WriteLine(Texto);
 // Salida:  a las dos hora con treinta minutos de la tarde ò de la mañana
```
3.3 De Hora a letras
```cs
 var Date = DateTime.Now;
 var Convert = new ConvertDateandNum();
 
 var Texto = Convert.DateToText(Date);
 
 Console.WriteLine(Texto);
 // Salida:  a los veinte días del mes de Junio  del año mil novecientos noventa y uno
```
