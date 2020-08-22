using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExampleMVVM.ViewModels
{
    class OperacionesViewModel: ViewModelBase
    {
        //TwoWay InotifyPropertyChange
        #region Propieades
        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }

        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }


        int resultado;
        public int Resultado
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoResta;
        public int ResultadoResta
        {
            get { return resultadoResta; }
            set
            {
                if (resultadoResta != value)
                {
                    resultadoResta = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        //Declarar comando
        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }

        public OperacionesViewModel()
        {
            Sumar = new Command(() =>
            {
                Resultado = Valor1 + Valor2;
            });

            Restar = new Command(() =>
            {
                ResultadoResta = Valor1 - Valor2;
            });

        }
      
    }
}
