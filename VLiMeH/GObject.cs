using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLiMeH
{
    abstract class GObject
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Int32 idpointer;
        public Int32 IDPointer
        {
            get { return idpointer;}
            set { idpointer = value; }
        }
        private string pointer;
        public string Pointer
        {
            get { return pointer; }
            set { pointer = value; }
        }
        private string stdesignation;
        public string StDesignation
        {
            get { return stdesignation; }
            set { stdesignation = value; }
        }
        private string tsize;
        public string TSize
        {
            get { return tsize;}
            set { tsize = value; }
        }
        private Int32 okpcode;
        public Int32 OKPCode
        {
            get { return okpcode; }
            set { okpcode = value; }
        }
        private string tproduct;
        public string TProduct
        {
            get { return tproduct; }
            set { tproduct = value; }
        }
        private string bomsection;
        public string BOMSection
        {
            get { return bomsection; }
            set { bomsection = value; }
        }
        public GObject(string name, Int32 idpointer, string pointer, string stdesignation, string tsize,
            Int32 okpcode, string tproduct, string bomsection)
        {
            Name = name;
            IDPointer = idpointer;
            Pointer = pointer;
            StDesignation = stdesignation;
            TSize = tsize;
            OKPCode = okpcode;
            TProduct = tproduct;
            BOMSection = bomsection;
        }
        public abstract double ExArea(); // площадь наружной поверхности
        public abstract double GArea();  //общая площадь поверхности
        public abstract double Mass();   //масса
        public abstract double Val();  //объем

    }
}
