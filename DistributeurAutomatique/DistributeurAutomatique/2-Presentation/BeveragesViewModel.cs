using DistributeurAutomatique.DataAccess;
using DistributeurAutomatique.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurAutomatique.viewModel
{
    public class BeveragesViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// beverage list
        /// </summary>
        private IEnumerable<Beverage> _beverages;
        private IBeverageReader _pageReader;
        private Beverage _selectedBeverage;

        public IEnumerable<Beverage> Beverages
        {
            get { return _beverages; }
            set { _beverages = value;}
        }
        public Beverage SelectedBeverage
        {
            get { return _selectedBeverage; }
            set {
                _selectedBeverage = value;
                RaisePropertyChanged("SelectedBeverage");
            }
        }

        public BeveragesViewModel ()
        {
            loadPage();
        }

        private void loadPage()
        {
            this._pageReader = new ServiceReader();
            this._beverages = _pageReader.GetBeverages();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged (string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
