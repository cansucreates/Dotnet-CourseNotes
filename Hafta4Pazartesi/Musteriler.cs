using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Pazartesi
{
    internal class Musteriler
    {
        private string _ad;
        private string _soyad;
        private int _yas;

        public string Ad // Property Büyük Harfle başlar.
        {
            get
            {
                return _ad;
            }
            set
            {
                _ad = value;
            }
        }

        public string Soyad // Property Büyük Harfle başlar.
        {
            get
            {
                return _soyad;
            }
            set
            {
                _soyad = value;
            }
        }

        public int Yas // Property Büyük Harfle başlar.
        {
            get
            {
                return _yas;
            }
            set
            {
                _yas = value;
            }
        }
    }
}
