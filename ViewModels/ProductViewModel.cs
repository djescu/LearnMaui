// Copyright © 2024 David Escudero. All rights reserved.

using System.ComponentModel;
using System.Windows.Input;

namespace LearnMaui.ViewModels
{
    internal class ProductViewModel : INotifyPropertyChanged
    {
        private string _name;
        public string Name {
            get => _name;
            set {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public ICommand SaveCommand { get; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
