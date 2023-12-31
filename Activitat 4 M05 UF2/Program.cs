﻿using System;

namespace M05UF2
{
    public class Pt4
    {
        public static void Main()
        {
            bool error = true;
            string option = "";
            double area = 0, height = 0, width = 0, radius = 0, apotema = 0, side = 0;
            const string MsgOption = "De que vols calcular l'àrea? \na. Quadrat \nb. Rectangle \nc. Cercle \nd. Pentàgon";
            const string MsgInputHeight = "Introdueix l'alçada en m: ";
            const string MsgInputWidth = "Introdueix l'amplada en m: ";
            const string MsgInputRadius = "Introdueix el radi en m: ";
            const string MsgInputApotema = "Introdueix l'apotema en m: ";
            const string MsgInputSide = "Introdueix quant mesura un costat en m: ";
            const string MsgOutputArea = "L'area d'aquesta figura és {0} m.";
            const string MsgError = "Aquest valor no és vàlid.";

            do
            {
                error = false;
                Console.WriteLine(MsgOption);
                option = Console.ReadLine().ToLower();
                if (!ValidateOption(option))
                {
                    Console.WriteLine(MsgError);
                    error = true;
                }
            } while (error);
            Console.WriteLine();
            switch (option)
            {
                case "a":
                    do
                    {
                        error = false;
                        Console.Write(MsgInputHeight);
                        height = Convert.ToDouble(Console.ReadLine());
                        if (!ValidateNumber(height))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    } while (error);
                    do
                    {
                        error = false;
                        Console.Write(MsgInputWidth);
                        width = Convert.ToDouble(Console.ReadLine());
                        if (!ValidateNumber(width))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    } while (error);
                    area = AreaSquareRectangle(height, width);
                    break;
                case "b":
                    do
                    {
                        error = false;
                        Console.Write(MsgInputHeight);
                        height = Convert.ToDouble(Console.ReadLine());
                        if (!ValidateNumber(height))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    } while (error);
                    do
                    {
                        error = false;
                        Console.Write(MsgInputWidth);
                        width = Convert.ToDouble(Console.ReadLine());
                        if (!ValidateNumber(width))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    } while (error) ;
                    area = AreaSquareRectangle(height, width);
                    break;
                case "c":
                    do
                    {
                        error = false;
                        Console.Write(MsgInputRadius);
                        radius = Convert.ToDouble(Console.ReadLine());
                        if (!ValidateNumber(radius))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    } while (error);
                    area = AreaCircle(radius);
                    break;
                case "d":
                    do
                    {
                        error = false;
                        Console.Write(MsgInputApotema);
                        apotema = Convert.ToDouble(Console.ReadLine());
                        if (!ValidateNumber(apotema))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    } while (error);
                    do
                    {
                        error = false;
                        Console.Write(MsgInputSide);
                        side = Convert.ToDouble(Console.ReadLine());
                        if (!ValidateNumber(side))
                        {
                            Console.WriteLine(MsgError);
                            error = true;
                        }
                    } while (error);
                    area = AreaPentagon(apotema, side);
                    break;
            }
            Console.WriteLine(MsgOutputArea, area);
        }
        public static bool ValidateOption(string option)
        {
            return ((option == "a") || (option == "b") || (option == "c") || (option == "d")) ? true : false;
        }
        public static bool ValidateNumber(double number)
        {
            return number > 0 ? true : false;
        }
        public static double AreaSquareRectangle(double height, double width)
        {
            return height * width;
        }
        public static double AreaCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }
        public static double AreaPentagon(double apotema, double side)
        {
            return ((side * 5) * apotema) / 2;
        }
    }
}