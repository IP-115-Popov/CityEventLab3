using CityEventLab3.ViewModels.Page;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CityEventLab3.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object content;
        private ObservableCollection<ViewModelBase> vmbaseCollection;
        public MainWindowViewModel()
        {
            vmbaseCollection = new ObservableCollection<ViewModelBase>();
            vmbaseCollection.Add(new ForChildrenViewModel());
            vmbaseCollection.Add(new SportViewModel());
            vmbaseCollection.Add(new CultureViewModel());        
            vmbaseCollection.Add(new ExcursionsViewModel());
            vmbaseCollection.Add(new LifestyleViewModel());
            vmbaseCollection.Add(new PartiesViewModel());
            vmbaseCollection.Add(new EducationViewModel());
            vmbaseCollection.Add(new OnlineViewModel());
            vmbaseCollection.Add(new ShowViewModel());

            Content = vmbaseCollection[0];
        }
        public object Content
        {
            get => content;
            set
            {
                this.RaiseAndSetIfChanged(ref content, value);
            }
        }
        public ObservableCollection<ViewModelBase> VmbaseCollection
        {
            get => vmbaseCollection;
            set
            {
                this.RaiseAndSetIfChanged(ref vmbaseCollection, value);
            }
        }
        public void ReplaseTo(string winShow)
        {
            switch (winShow)
            {
                case "ForChildren":
                    Content = vmbaseCollection[0];
                    break;
                case "Culture":
                    Content = vmbaseCollection[1];
                    break;
                case "Sport":
                    Content = vmbaseCollection[2];
                    break;           
                case "Excursions":
                    Content = vmbaseCollection[3];
                    break;
                case "Lifestyle":
                    Content = vmbaseCollection[4];
                    break;
                case "Parties":
                    Content = vmbaseCollection[5];
                    break;
                case "Education":
                    Content = vmbaseCollection[6];
                    break;
                case "Online":
                    Content = vmbaseCollection[7];
                    break;
                case "Show":
                    Content = vmbaseCollection[8];
                    break;
                default:
                    Content = vmbaseCollection[0];
                    break;
            }
        }
    }
}
