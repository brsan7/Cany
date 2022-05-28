using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopCany.Entidades
{
    class Login
    {
            private string _usuario;
            public string Usuario
            {
                get
                {
                    return _usuario;
                }
                set
                {
                    _usuario = value;
                }
            }

            private string _senha;
            public string Senha
            {
                get
                {
                    return _senha;
                }

                set
                {
                    _senha = value;
                }
            }

        private bool _autenticado;
        public bool Autenticado
        {
            get
            {
                return _autenticado;
            }

            set
            {
                _autenticado = value;
            }
        }     

        }
    }

