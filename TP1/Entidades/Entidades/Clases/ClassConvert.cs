using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    class ClassConvert
    {
        string valueBin="";

        public string Binary (string binary)
        {
            double numberBinary;
            double.TryParse(binary, out numberBinary);
            string resto = "";
            string binario = "";

            while ((numberBinary >= 2))
            {
                resto = resto + (numberBinary % 2).ToString();
                numberBinary = numberBinary / 2;
            }
            resto = resto + numberBinary.ToString();

            for (int i = resto.Length; i >= 1; i += -1)
            {
                binario = binario + resto.Substring(i - 1, 1);
            }

            return binario;
        }
    }
}
