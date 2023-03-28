using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4.Model
{
    public partial class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {
            monkeys = new ObservableCollection<string>();
            monkeys.Add("Monk");
            monkeys.Add("Monk2");
        }

        [ObservableProperty]
        ObservableCollection<string> monkeys;

        [RelayCommand]
        void Remove(string key)
        {
            Debug.WriteLine(key);
        }

    }
}
