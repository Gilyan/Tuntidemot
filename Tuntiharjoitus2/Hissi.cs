﻿/* **************************************
Harjoitellaan get- ja set -aksessorien käyttöä.

Luotu 18.1.2017

Minttu Mäkäläinen K8517 @ JAMK
************************************** */

using System;

namespace JAMK.IT
{
    public class Hissi
    {
        int kerros;
        public int Kerros
        {
            get
            { return kerros; }
            set
            {
                if (value > 0 && value < 6)
                { kerros = value; }
            }
        }
    }
}
