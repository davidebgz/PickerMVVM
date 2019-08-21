using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PickerMVVM.ViewModel
{
   public class PickerViewModel
    {
        public List<ciudades> ListaCiudades { get; set; }
        public PickerViewModel()
        {
            ListaCiudades = GetCiudades().OrderBy(t => t.valor).ToList();
        }
        public List<ciudades> GetCiudades()
        {
            var ciudades = new List<ciudades>()
            {
                new ciudades() {llave = 1, valor= "Mumbai"},
                new ciudades() {llave = 2, valor= "Dubai"},
                new ciudades() {llave = 3, valor= "Tokio"},
                new ciudades() {llave = 4, valor= "Paris"},
                new ciudades() {llave = 5, valor= "Berlin"},
                new ciudades() {llave = 6, valor= "SanSalvador"},
            };
            return ciudades;
        }
    }
    public class ciudades
    {
        public int llave { get; set; }
        public string valor { get; set; }
    }
}
