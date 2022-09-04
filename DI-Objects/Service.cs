using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Objects
{
    internal class Service : IService
    {
        string _currentDateTime;
        public Service()
        {   
            this._currentDateTime = DateTime.Now.ToString("MMMM-dd hh.mm.ss.ffffff");
        }

        public string GetObjectCreationDateTime { get { return this._currentDateTime; } }
       
    }
}
