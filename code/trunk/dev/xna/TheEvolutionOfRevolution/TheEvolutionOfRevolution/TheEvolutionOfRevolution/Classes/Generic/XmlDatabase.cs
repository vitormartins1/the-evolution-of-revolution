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

using Foxpaw.Xml.Generic;

namespace Foxpaw.Xml
{
    class XmlDatabase
    {
        private string path; // Caminho para leitor.

        private XmlTextReader xmlReader; // Leitor.

        private List<string> elementList; // Lista de TAG's.

        public XmlDatabase(string path) 
        {
            NewPath(path);
            xmlReader = new XmlTextReader(path); 
            elementList = new List<string>();
        }

        public void NewPath(string path) { this.path = path; } // Novo caminho.

        /// <param name="elementPath">Exemplo: Caixa/Item/</param>
        public int GetIntValue(string elementPath) { return Convert.ToInt32(GetValue(elementPath)); } // Retorna string.

        /// <param name="elementPath">Exemplo: Caixa/Item/</param>
        public string GetStringValue(string elementPath) { return GetValue(elementPath); } // Retorna int.

        public void GetPackageValue(GenericPackage package) // Coloca os valores na caixa usando os parâmetros da mesma.
        {
            if (PathMatcher(package.path)) // Caso o caminho seja encontrado.
            {
                package.ReadLine(ref xmlReader); // Leitura.
            }
        }

        /// <summary>Reseta o leitor para o mesmo arquivo.</summary>
        public void ResetDatabase() { ResetDatabase(path); }
        /// <summary>Reseta o leitor para outro arquivo.</summary>
        /// <param name="elementPath">Exemplo: Caixa/Item/</param>
        public void ResetDatabase(string path) { xmlReader = new XmlTextReader(path); }

        /// <summary>Torna o leitor nulo.</summary>
        public void DisposeDatabase() { xmlReader = null; }

        // Vericador de caminho.
        private bool PathMatcher(string elementPath)
        {
            xmlReader = new XmlTextReader(path); // Reseta o leitor.

            elementList.Clear(); // Limpar a lista.

            string tempElement = null; // String de armazenamento temporário.
            for (int index = 0; index < elementPath.Length; index++)
            {
                if (elementPath[index] == '/') // Separador de strings.
                {
                    elementList.Add(tempElement); // Adiciona a string à lista.
                    tempElement = null; // Anular a string.
                }
                else { tempElement += elementPath[index]; } // Adicionar caráctere à string.
            }

            string[] currentPlace = new string[elementList.Count]; // Informações do local atual.
            while (xmlReader.Read())
            {
                int depth = xmlReader.Depth; // A profundidade da TAG.
                if (depth < elementList.Count) { currentPlace[depth] = xmlReader.Name; } // Substituir TAG's.

                if (Match(currentPlace)) // Verifica a combinação.
                {
                    return true; // Retorna o valor requisitado.
                }
            }
            return false; // O caminho não existe.
        }

        // Retorna caminho encontrado.
        private bool Match(string[] elementArray)
        {
            for (int index = 0; index < elementList.Count; index++) // Verifica a igualdade.
            {
                if (elementList[index] != elementArray[index]) { return false; } // Diferente.
            }
            return true; // Igual.
        }

        // Retorna o valor do nódulo atual.
        private string GetValue(string elementPath) { return xmlReader.ReadString(); }
    }
}