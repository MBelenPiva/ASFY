using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASFY_Proyecto.Models
{
    public class RutinasPorProgramas
    {
        private int _codigo;

        public RutinasPorProgramas(int codigo)
        {
            _codigo = codigo;
            
        }

        public int codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }
    }
}