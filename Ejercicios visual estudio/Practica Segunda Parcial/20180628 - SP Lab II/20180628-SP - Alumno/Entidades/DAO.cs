using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DAO
    {
        string stringConecction;

        public DAO()
        {
            this.stringConecction = "Data Source=.\\SQLEXPRESS;" +
                "Initial Catalog=votacion-sp-2018;Integrated Security=True";
        }
    }
}
