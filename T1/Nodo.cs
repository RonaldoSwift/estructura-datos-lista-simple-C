using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class Nodo: IComparable<Nodo>, IEquatable<Nodo>
    {
        private Estudiante dato;

        public Estudiante Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public int CompareTo(Nodo x)
        {
            if(this.Dato.codigo < x.Dato.codigo)
            {
                return -1;
            }
            else if(this.Dato.codigo > x.Dato.codigo)
            {
                return 1;
            }
            return 0;
        }

        public bool Equals(Nodo x)
        {
            if (this.Dato.codigo == x.Dato.codigo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
