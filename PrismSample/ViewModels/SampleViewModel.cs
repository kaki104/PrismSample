using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Windows.Mvvm;

namespace PrismSample.ViewModels
{
    public class SampleViewModel : ViewModelBase
    {
        private string _helloText;

        public SampleViewModel()
        {
            Init();
        }

        private void Init()
        {
            ClickMeCommand = new DelegateCommand(OnClickMeCommand);
            HelloText = "Hello UWP World!!";
        }

        private void OnClickMeCommand()
        {
            HelloText = "UWP 세계에 오신것을 환영 합니다.";
        }

        public ICommand ClickMeCommand { get; set; }

        public string HelloText
        {
            get => _helloText;
            set => SetProperty(ref _helloText ,value);
        }
    }
}
