using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMAUI.Models
{
    public class Plato : INotifyPropertyChanged
    {
        private int _Id;
        public int Id {
            get { return _Id; }
            set {
                if (_Id == value)
                    return;
                _Id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            } 
        }
        private string _Nombre;
        public string Nombre {
            get => _Nombre;
            set {
                if (_Nombre == value)
                    return;
                _Nombre = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nombre)));
            }
        }

        private string _Costo;
        public string Costo
        {
            get => _Costo;
            set
            {
                if (_Costo == value)
                    return;
                _Costo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Costo)));
            }
        }
        private string _Ingrediente;
        public string Ingrediente
        {
            get => _Ingrediente;
            set
            {
                if (_Ingrediente == value)
                    return;
                _Ingrediente = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Ingrediente)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
