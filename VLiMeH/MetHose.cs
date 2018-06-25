using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLiMeH
{
    internal class MetHose : GObject
    {
        private string flpart;
        public string FlPart
        {
            get { return flpart;}
            set { flpart = value; }
        }
        private string dv;
        public string Dv
        {
            get { return dv; }
            set { dv = value; }
        }
        private string di;
        public string Di
        {
            get { return di; }
            set { di = value; }
        }
        private string ln;
        public string Ln
        {
            get { return ln; }
            set { ln = value; }
        }
        private string th;
        public string Th
        {
            get { return th; }
            set { th = value; }
        }
        private string wp;
        public string Wp
        {
            get { return wp; }
            set { wp = value; }
        }
        public MetHose(string name, Int32 idpointer, string pointer, string stdesignation, string tsize,
            Int32 okpcode, string tproduct, string bomsection, string flpart, string dv, string di, string ln, string th, string wp) : 
            base(name, idpointer, pointer, stdesignation, tsize, okpcode, tproduct,bomsection)
        {
            FlPart = flpart;
            Dv = dv;
            Di = di;
            Ln = ln;
            Th = th;
            Wp = wp;

        }

        public override double ExArea()
        {
            throw new NotImplementedException();
        }

        public override double GArea()
        {
            throw new NotImplementedException();
        }

        public override double Mass()
        {
            throw new NotImplementedException();
        }
    }

}
