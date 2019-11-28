﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException(string mensaje) : this(mensaje, null)
        {

        }
        public ErrorArchivoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}