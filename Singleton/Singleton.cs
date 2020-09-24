using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public  class Singleton
    {
        private static Singleton _instance;

        public Guid DinhDanh { get;  }
        public int GiaTriHienTai { get; set; }

        protected  Singleton( Guid uid)
        {
            DinhDanh = uid;
        }

        public static Singleton GetInstance()
        {
            if(_instance==null)
            {
                _instance = new Singleton(Guid.NewGuid());
            }
            return _instance;
        }

        public static Singleton GetNewInstance()
        {
            return new Singleton(Guid.NewGuid());
        }

    }
}
