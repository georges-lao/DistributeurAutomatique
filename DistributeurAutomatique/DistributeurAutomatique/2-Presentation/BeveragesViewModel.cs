using DistributeurAutomatique.Shared;
using System.Collections.Generic;
using System.ComponentModel;

namespace DistributeurAutomatique.viewModel
{
    /// <summary>
    /// Main window viewModel
    /// </summary>
    public class BeveragesViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// beverage list
        /// </summary>
        private IEnumerable<Beverage> _beverages;
        private IBeverageReader _pageReader;
        private Beverage _selectedBeverage;

        /// <summary>
        /// Beverage list available
        /// </summary>
        public IEnumerable<Beverage> Beverages
        {
            get { return _beverages; }
            set { _beverages = value;}
        }

        /// <summary>
        /// selected Beverage on UI
        /// </summary>
        public Beverage SelectedBeverage
        {
            get { return _selectedBeverage; }
            set {
                _selectedBeverage = value;
                RaisePropertyChanged("SelectedBeverage");
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serviceReader">IBeverageReader</param>
        public BeveragesViewModel (IBeverageReader serviceReader)
        {
            this._pageReader = serviceReader;
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
