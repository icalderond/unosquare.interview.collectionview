using System;
using System.Collections.ObjectModel;
using System.Linq;
using MarcaApp.Interfaces;
using MarcaApp.Models;
using Xamarin.Forms;

namespace MarcaApp.ViewModels
{
    public class AutoPageViewModel : NotificationEnabledObject
    {
        public AutoPageViewModel()
        {
            PackageName = DependencyService.Get<IPackageName>().GetPackageName();

            ListaAutoModel = new ObservableCollection<AutoModel>
            {
                new AutoModel
                {
                    Marca=Guid.NewGuid().ToString(),
                    Modelo=Guid.NewGuid().ToString(),
                    Anio="2020"
                },
                new AutoModel
                {
                    Marca=Guid.NewGuid().ToString(),
                    Modelo=Guid.NewGuid().ToString(),
                    Anio="2019"
                }
            };
        }

        private string _PackageName;
        public string PackageName
        {
            get => _PackageName;
            set
            {
                _PackageName = value;
                OnPropertyChanged();
            }
        }

        private AutoModel _AutoModelActual;
        public AutoModel AutoModelActual
        {
            get => _AutoModelActual = _AutoModelActual ?? new AutoModel();
            set
            {
                _AutoModelActual = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<AutoModel> _ListaAutoModel;
        public ObservableCollection<AutoModel> ListaAutoModel
        {
            get => _ListaAutoModel;
            set
            {
                _ListaAutoModel = value;
                OnPropertyChanged();
            }
        }

        private Command _GuardarCommand;
        public Command GuardarCommand
        {
            get => _GuardarCommand = _GuardarCommand ?? new Command(() =>
            {
                if (!ListaAutoModel.Any(x => x.Marca == AutoModelActual.Marca && x.Modelo == AutoModelActual.Modelo && x.Anio == AutoModelActual.Anio))
                {
                    ListaAutoModel.Add(AutoModelActual);
                    AutoModelActual = new AutoModel();
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("MarcaApp", "Este item ya esta repetido", "Entendido");
                }
            });
            set
            {
                _GuardarCommand = value;
            }
        }
    }
}
