using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiMVVM
{
    public partial class MainViewModel : ObservableObject // z nugetu CommunityToolkit.Mvvm
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string lastName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;

        public string FullName => $"{FirstName} {LastName}";

        public bool IsNotBusy => !IsBusy;

        [RelayCommand]
        private void Tap()
        {
            IsBusy = true;

            Console.WriteLine(FullName);

            IsBusy = false;
        }
    }
}
