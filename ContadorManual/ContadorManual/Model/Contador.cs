﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContadorManual.Model
{
    public class Contador
    {
        private int _Conteo;

        public int Conteo 
        {
            get => _Conteo;

            set
            {
                if (_Conteo != value)
                {
                    _Conteo = value;
                }
            }
        }

        public Contador()
        {
                        
        }

        public void Contar()
        {
            Conteo++;
        }

        public void ReiniciarConteo()
        {
            Conteo = 0;
        }
    }
}
