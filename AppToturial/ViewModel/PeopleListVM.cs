using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppToturial.ViewModel
{
    public class PeopleListVM : IDisposable, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command cmdSave { get; private set; }
        public Command cmdCancel { get; private set; }

        INavigation Navigation;
        List<People> list;
        public ObservableCollection<People> obcList { get; set; }

        People _selectedItem;
        public People selectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                if (_selectedItem == null) return;

                // Handle the selected Item here
                HandlerSelecteItem(_selectedItem);
                selectedItem = null;

                OnPropertyChanged(nameof(selectedItem));
            }
        }

        /// <summary>
        /// The construtor
        /// </summary>
        /// <param name="navigation"></param>
        public PeopleListVM (INavigation navigation)
        {
            Navigation = navigation;
            InitCmd();
            BuildPeoplesList();
        }

        /// <summary>
        /// Init the command linking
        /// </summary>
        void InitCmd ()
        {
            cmdSave = new Command(Save);
            cmdCancel = new Command(Cancel);
        }

        /// <summary>
        /// Handle the save command from view
        /// </summary>
        void Save ()
        {
            App.Current.MainPage.DisplayAlert("Alert", "You clicked Save cmd", "OK");
        }

        /// <summary>
        /// Handle the cancel command from view
        /// </summary>
        void Cancel ()
        {
            App.Current.MainPage.DisplayAlert("Alert", "You clicked cancel cmd", "OK");
        }

        void HandlerSelecteItem(People selectedItem)
        {
            App.Current.MainPage.DisplayAlert("Alert", "You clicked the " + selectedItem.name, "OK");
        }

        /// <summary>
        ///  Build demo list
        /// </summary>
        void BuildPeoplesList ()
        {
            list = new List<People>();
            for (int x = 0; x< 20; x++)
            {
                People newPeople = new People()
                {
                    name = x.ToString(),
                    icNumber = x.ToString(),
                    id = Convert.ToDouble(x)
                };

                list.Add(newPeople);
            }

            obcList = new ObservableCollection<People>(list);
            OnPropertyChanged(nameof(obcList));

        }

        /// <summary>
        /// Dispose the class
        /// </summary>
        public void Dispose()
        {
            GC.Collect();
        }

        /// <summary>
        /// Handle the on property changed, value update to screen
        /// </summary>
        /// <param name="propertyname"></param>
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
