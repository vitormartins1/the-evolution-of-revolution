/*
|--------------------------------------------------------------------|
|Programado por Willian Silva (Kipip) - williansilva.nave@gmail.com  |
|--------------------------------------------------------------------|
*/

#region Microsoft
using System;
using System.Xml;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
#endregion

namespace Foxpaw.Xml.Generic
{
    class Animation3DPackage : GenericPackage
    {
        //Construtor.
        public Animation3DPackage(string target) : base(target) { }

        //Leitura.
        public override void ReadLine(ref XmlTextReader xmlReader)
        {
            EndTag(ref xmlReader);
            base.FrameCount = ToIntValue(xmlReader.ReadString());
            base.PointList = GetPointList(ref xmlReader);
        }

        private Point GetPoint(ref XmlTextReader xmlReader)
        {
            EndTag(ref xmlReader);
            Point temp = base.ToPointValue(xmlReader.ReadString());
            return temp;
        }

        private List<Point> GetPointList(ref XmlTextReader xmlReader)
        {
            string[] tempValues = new string[2];

            EndTag(ref xmlReader);
            tempValues[0] = xmlReader.ReadString();

            EndTag(ref xmlReader);
            tempValues[1] = xmlReader.ReadString();

            return base.ToPointListValue(tempValues);
        }

        private void EndTag(ref XmlTextReader xmlReader)
        {
            xmlReader.Read();
            xmlReader.Read();
        }
    }
}
