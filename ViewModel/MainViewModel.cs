using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace jhone_mvvmLigth.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }
        public ICommand ChangeTitleCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Title = "Hello World";
            ChangeTitleCommand = new RelayCommand(ChangeTitle);
        }

        private void ChangeTitle()
        {
            Title = "Hello MvvmLight";
        }
    }
}