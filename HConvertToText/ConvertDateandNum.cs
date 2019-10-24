using System;
/// <summary>
/// Namespace que cotiene un helper para convertir a texto
/// </summary>
namespace HConvertToText
{
    /// <summary>
    /// Clase para convertir cantidad numericas,fechas, Horas y minutos a texto
    /// </summary>
    public class ConvertDateandNum
    {
        const string DECENAS = "diez      veinte    treinta   cuarenta  cincuenta sesenta   setenta   ochenta   noventa";
        const string VEINTENAS = "veintiuno     veintidos     veintitrés    veinticuatro  veinticinco   veintiséis    veintisiete   veintiocho    veintinueve   ";
        const string UNIDADES = "uno       dos       tres      cuatro    cinco     seis      siete     ocho      nueve      ";
        const string ESPECIALES = "once          doce          trece         catorce       quince        dieciséis     diecisiete    dieciocho     diecinueve    ";
        static readonly string[] MESES = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

        /// <summary>
        /// Convierte de numero a texto
        /// </summary>
        /// <param name="Valor">valor a convertir</param>
        /// <returns>Numero en texto</returns>
        public string NumberToText(decimal Valor)
        {
            var Convertir = string.Empty;
            var Letras = Valor.ToString();

            try
            {

                if (Valor == 0)
                {
                    throw new Exception("Ingrese Valor > 0 ");
                }

                var Decimales = decimal.Zero;
                while (Letras.Length > 0)
                {

                    if (Letras.Length == 4 || Letras.Length == 1 || Letras.Length == 7)
                    {
                        if (Letras.Substring(0, 1) != "0")
                        {
                            if (Letras.Length == 1 || Letras.Substring(0, 1) != "1")
                            {
                                var NumLet = (int.Parse(Letras.Substring(0, 1)) * 10 - 10);
                                var position = UNIDADES.Length - NumLet;

                                Convertir = Convertir + UNIDADES.Substring(NumLet, 10).TrimEnd();

                                if (Letras.Length == 4)
                                {
                                    Convertir = Convertir + ((Letras.Substring(0, 1) == "1") ? " un mil " : " mil ");
                                }
                                else if (Letras.Length == 7)
                                {
                                    Convertir = Convertir + ((Letras.Substring(0, 1) == "1") ? " un millon " : " millones ");
                                }
                            }
                        }
                    }
                    else if (Letras.Length == 5 || Letras.Length == 2 || Letras.Length == 8)
                    {
                        var NumLet = (int.Parse(Letras.Substring(0, 1)) * 10 - 10);
                        if (Letras.Substring(0, 1) != "0")
                        {
                            if (Letras.Substring(0, 1) != "1" && Letras.Substring(0, 1) != "2")
                            {
                                if (Letras.Substring(1, 1) == "0")
                                {
                                    Convertir = Convertir + DECENAS.Substring(NumLet, 10).TrimEnd();

                                    if (Letras.Length == 5)
                                    {
                                        Convertir = Convertir + " mil ";
                                    }
                                    else if (Letras.Length == 8)
                                    {
                                        Convertir = Convertir + " millones ";
                                        Letras = Letras.Substring(1, Letras.Length - 1);
                                    }
                                }
                                else
                                {
                                    Convertir = Convertir + DECENAS.Substring(NumLet, 10).TrimEnd() + " y ";
                                }

                            }
                            else if (Letras.Substring(0, 1) == "1")
                            {

                                if (Letras.Substring(1, 1) == "0")
                                {
                                    Convertir = Convertir + DECENAS.Substring(NumLet, 10).TrimEnd();
                                }
                                else
                                {
                                    var NumLet2 = (int.Parse(Letras.Substring(1, 1)) * 14 - 14);
                                    Convertir = Convertir + ESPECIALES.Substring(NumLet2, 14).TrimEnd();
                                    if (Letras.Length == 5)
                                    {
                                        Convertir = Convertir + " mil ";
                                    }
                                    else if (Letras.Length == 8)
                                    {
                                        Convertir = Convertir + " millones ";
                                    }
                                    Letras = Letras.Substring(1, Letras.Length - 1);
                                }
                            }
                            else
                            {
                                if (Letras.Substring(1, 1) == "0")
                                {
                                    Convertir = Convertir + DECENAS.Substring(NumLet, 10).TrimEnd();
                                }
                                else
                                {
                                    var NumLet2 = (int.Parse(Letras.Substring(1, 1)) * 14 - 14);
                                    Convertir = Convertir + VEINTENAS.Substring(NumLet2, 14).TrimEnd();
                                }

                                if (Letras.Length == 5)
                                {
                                    Convertir = Convertir + " mil ";
                                }
                                else if (Letras.Length == 8)
                                {
                                    Convertir = Convertir + " millones ";
                                }
                            }
                        }
                    }
                    else if (Letras.Length == 6 || Letras.Length == 3 || Letras.Length == 9)
                    {
                        if (Letras.Substring(0, 1) != "0")
                        {
                            if (Letras.Substring(0, 1) == "1")
                            {
                                if (Letras.Substring(1, 2) == "00")
                                {
                                    if (Letras.Length == 6)
                                    {
                                        Convertir = Convertir + "cien mil ";
                                    }
                                    else if (Letras.Length == 3)
                                    {
                                        Convertir = Convertir + "cien ";
                                    }
                                    else if (Letras.Length == 9)
                                    {
                                        Convertir = Convertir + "cien millones ";
                                    }
                                }
                                else
                                {
                                    Convertir = Convertir + "ciento ";
                                }
                            }
                            else if (Letras.Substring(0, 1) == "5")
                            {
                                if (Letras.Substring(1, 2) == "00")
                                {
                                    if (Letras.Length == 6)
                                    {
                                        Convertir = Convertir + "quinientos mil ";
                                    }
                                    else if (Letras.Length == 3)
                                    {
                                        Convertir = Convertir + "quinientos ";
                                    }
                                    else if (Letras.Length == 9)
                                    {
                                        Convertir = Convertir + "quinientos millones ";
                                    }
                                    else
                                    {
                                        Convertir = Convertir + "quinientos ";
                                    }
                                }


                            }
                            else if (Letras.Substring(1, 2) == "00")
                            {
                                var NumLet = (int.Parse(Letras.Substring(0, 1)) * 10 - 10);
                                if (Letras.Length == 6)
                                {
                                    Convertir = Convertir + UNIDADES.Substring(NumLet, 10).TrimEnd() + " cientos mil ";
                                }
                                else if (Letras.Length == 3)
                                {
                                    Convertir = Convertir + UNIDADES.Substring(NumLet, 10).TrimEnd() + " cientos ";
                                }
                                else if (Letras.Length == 9)
                                {
                                    Convertir = Convertir + UNIDADES.Substring(NumLet, 10).TrimEnd() + " cientos millones ";
                                }
                            }
                            else
                            {
                                var NumLet = (int.Parse(Letras.Substring(0, 1)) * 10 - 10);
                                Convertir = Convertir + UNIDADES.Substring(NumLet, 10).TrimEnd() + " cientos ";
                            }
                        }
                    }
                    Letras = Letras.Substring(1, Letras.Length - 1);
                }
                Decimales = (Valor - int.Parse(Valor.ToString())) * 100;
                if (Decimales > 0)
                {
                    Convertir = Convertir + " con " + Decimales.ToString().TrimEnd();
                }
                else
                {
                    Convertir = Convertir + "";
                    Convertir = Convertir.Substring(0, 1).ToLower() + Convertir.Substring(1, Convertir.Length - 1);
                }

            }
            catch (Exception e)
            {
                throw new Exception("Se genero un error en la Conversion de Numero");
            }
            return Convertir;

        }
        /// <summary>
        /// Convierte hora a texto
        /// </summary>
        /// <param name="date">Fecha con horas y minutos</param>
        /// <returns>Hora en texto - ejemplo: ( a las 'dos' hora con 'treinta' minutos  'de la tarde ò de la mañana' )</returns>
        public string HoursToText(DateTime date)
        {
            string Convertir = string.Empty;
            var Hora = date.Hour;
            var Minutos = date.Minute;
            var TardeManiana = string.Empty;

            try
            {
                TardeManiana = (Hora > 12 && Minutos > 0) ? " de la tarde " : " de la mañana ";
                Hora = (Hora > 12) ? @Hora - 12 : @Hora;

                Convertir = " a las " + NumberToText(Hora) + " horas con " + NumberToText(Minutos) + " minutos" + TardeManiana;
            }
            catch (Exception)
            {
                throw new Exception("Se genero un error en la Conversion de Hora");
            }



            return Convertir;
        }
        /// <summary>
        /// Convierte fecha a texto
        /// </summary>
        /// <param name="date">Fecha</param>
        /// <returns>Fecha en texto - ejemplo: ( a los 'siete' días del mes de 'Mayo'  del año 'mil novecientos noventa y uno' )</returns>
        public string DateToText(DateTime date)
        {
            string Convertir = string.Empty;
            var Dia = date.Day;
            var Mes = string.Empty;
            var Anio = date.Year;
            var TardeManiana = string.Empty;
            try
            {
                Mes = MESES[date.Month - 1];
                Convertir = " a los " + NumberToText(Dia) + " días del mes de " + Mes + " del año " + NumberToText(Anio);
            }
            catch (Exception)
            {
                throw new Exception("Se genero un error en la Conversion de Fecha");
            }
            return Convertir;
        }
    }
}
