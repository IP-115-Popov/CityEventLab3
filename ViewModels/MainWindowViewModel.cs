using CityEventLab3.ViewModels.Page;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CityEventLab3.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<ViewModelBase> vmbaseCollection;
        public MainWindowViewModel()
        {
            vmbaseCollection = new ObservableCollection<ViewModelBase>();
            vmbaseCollection.Add(new CultureViewModel());
            vmbaseCollection.Add(new ForChildrenViewModel());
            vmbaseCollection.Add(new SportViewModel());
            vmbaseCollection.Add(new ExcursionsViewModel());
            vmbaseCollection.Add(new LifestyleViewModel());
            vmbaseCollection.Add(new PartiesViewModel());
            vmbaseCollection.Add(new EducationViewModel());
            vmbaseCollection.Add(new OnlineViewModel());
            vmbaseCollection.Add(new ShowViewModel());
        }
    }
}
