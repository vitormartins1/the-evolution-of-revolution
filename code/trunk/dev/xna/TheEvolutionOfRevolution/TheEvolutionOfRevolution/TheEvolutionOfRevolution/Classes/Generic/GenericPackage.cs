/*
|--------------------------------------------------------------------|
|Programado por Willian Silva (Kipip) - williansilva.nave@gmail.com  |
|--------------------------------------------------------------------|
*/

#region Microsoft
using System;
using System.Xml;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
#endregion

namespace Foxpaw.Xml.Generic
{
    abstract class GenericPackage
    {
        public string path = "Animations/";
        public Point PointValue { get; protected set; }
        public List<Point> PointList { get; protected set; }
        public int FrameCount;

        protected GenericPackage(string target) { path += target + "/"; }
        
        public virtual void ReadLine(ref XmlTextReader reader) { } // Faz a leitura. *Método para override*

        // Retorna valor inteiro convertendo string.
        protected int ToIntValue(string value) { return int.Parse(value); }

        // Retorna valor de ponto flutuante convertendo string.
        protected float ToFloatValue(string value) { return float.Parse(value); }

        // Retorna valor de Point convertendo string.
        protected Point ToPointValue(string data)
        {
            Point tempPoint = Point.Zero; // Ponto temporário.
            string value = null; // Valor temporário.

            for (int index = 0; index < data.Length; index++)
            {
                if (data[index] == ' ') // Ponto de separação.
                {
                    // Se o ponto for nulo, logo é seu primeiro valor.
                    if (tempPoint == Point.Zero)
                    {
                        // Converte e coloca o primeiro valor.
                        tempPoint.X = ToIntValue(value);
                        value = null; // Zerar valor.
                    }
                    else { tempPoint.Y = ToIntValue(value); } // Segundo e último valor.
                }
                else { value += data[index]; } // Adiciona o caractere à string de valores.
            }
            return tempPoint; // Retorno e fim do método.
        }

        //Retorna uma lista com os valores do array de strings. * [0] = X e [1] = Y *
        /// <summary>Usa o array de strings interno.</summary>
        protected List<Point> ToPointListValue(string[] data)
        {
            List<Point> valueList = new List<Point>(); // Lista temporária.

            string[] tempValues = new string[2]; // Array de valores temporários.

            for (int index = 0; index < data[0].Length; index++) // Ambos loops devem ter o mesmo tamanho.
            {
                if (data[0][index] == ' ') // Ao encontrar ponto de separação.
                {
                    Point point = new Point(ToIntValue(tempValues[0]), ToIntValue(tempValues[1])); // Conversão para inteiro.
                    tempValues = new string[2];
                    valueList.Add(point);
                }
                else
                {
                    // Adição de char às strings.
                    tempValues[0] += data[0][index];
                    tempValues[1] += data[1][index];
                }
            }
            return valueList; // Retorna a lista completa.
        }
    }
}