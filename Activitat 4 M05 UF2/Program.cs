using System;

namespace M05UF2
{
    public class Pt4
    {
        public static void Main()
        {
            bool error = false;
            string option = "";
            double area, height, width, radius, apotema, side;
            const string MsgOption = "De que vols calcular l'àrea? \na. Quadrat \nb. Rectangle \nc. Cercle \nd.Pentàgon";
            const string MsgInputHeight = "Introdueix l'alçada en m: ";
            const string MsgInputWidth = "Introdueix l'amplada en m: ";
            const string MsgInputRadius = "Introdueix el radi en m: ";
            const string MsgInputApotema = "Introdueix l'apotema en m: ";
            const string MsgInputSide = "Introdueix quant mesura un costat en m: ";
            const string MsgOutputArea = "L'area d'aquesta figura és {0} m.";
            const string MsgError = "Valor no vàlid.";
            const string MsgNoMoreAttempts = "No et queden més intents";

            while (error)
            {
                error = false;
                Console.WriteLine(MsgOption);
                option = Console.ReadLine().ToLower();
                if (ValidateOption(option))
                {
                    Console.WriteLine(MsgError);
                    error = true;
                }
            }
            Console.WriteLine();
            switch (option)
            {
                case "a":
                    while (error)
                    {
                        error = false;
                        Console.Write(MsgInputHeight);
                        height = Convert.ToDouble(Console.ReadLine());
                        if (ValidateNumber(height))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    }
                    while (error)
                    {
                        error = false;
                        Console.Write(MsgInputWidth);
                        width = Convert.ToDouble(Console.ReadLine());
                        if (ValidateNumber(width))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    }
                    area = AreaSqareRectangle(height, width);
                    break;
                case "b":
                    while (error)
                    {
                        error = false;
                        Console.Write(MsgInputHeight);
                        height = Convert.ToDouble(Console.ReadLine());
                        if (ValidateNumber(height))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    }
                    while (error)
                    {
                        error = false;
                        Console.Write(MsgInputWidth);
                        width = Convert.ToDouble(Console.ReadLine());
                        if (ValidateNumber(width))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    }
                    area = AreaSqareRectangle(height, width);
                    break;
                case "c":
                    while (error)
                    {
                        error = false;
                        Console.Write(MsgInputRadius);
                        radius = Convert.ToDouble(Console.ReadLine());
                    }

            }

        }
    }
}