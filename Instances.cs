using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Instances
    {

      private static EsofitEntities _db=null;
        public static EsofitEntities getInstances() 
        {

            if (_db == null) {
            
                _db=new EsofitEntities();
            
            
            }
            return _db;


        }


    }
}
