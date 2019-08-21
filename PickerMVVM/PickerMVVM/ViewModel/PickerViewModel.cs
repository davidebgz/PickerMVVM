using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace PickerMVVM.ViewModel
{
   public class PickerViewModel : INotifyPropertyChanged
    {
        public List<ciudades> ListaCiudades { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertchanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private ciudades _selecionarCiudad;

        public ciudades SelecionarCiudad
        {
            get { return _selecionarCiudad; }
            set
            {
                     if (_selecionarCiudad != value)
                     {
                         _selecionarCiudad = value;

                    miciudad = "Ciudad Selecionada :" + _selecionarCiudad.valor;  

                     }
            }
        }
        private string _miCiudad;

        public string miciudad
        {
            get { return _miCiudad; }
            set
            {
                if (_miCiudad != value)
                {
                    _miCiudad = value;
                    OnPropertchanged();
                }
            }
        }


        public PickerViewModel()
        {
            ListaCiudades = GetCiudades().OrderBy(t => t.valor).ToList();
        }

       

        public List<ciudades> GetCiudades()
        {
            var ciudad = new List<ciudades>()
            {
                new ciudades() {llave = 1, valor= "Mumbai"},
                new ciudades() {llave = 2, valor= "Dubai"},
                new ciudades() {llave = 3, valor= "Tokio"},
                new ciudades() {llave = 4, valor= "Paris"},
                new ciudades() {llave = 5, valor= "Berlin"},
                new ciudades() {llave = 6, valor= "SanSalvador"},
            };
            return ciudad;
        }
    }
    public class ciudades
    {
        public int llave { get; set; }
        public string valor { get; set; }
    }
}
