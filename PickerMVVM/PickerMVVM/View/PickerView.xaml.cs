using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PickerMVVM.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickerMVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerView : ContentPage
    {
        public PickerView()
        {
            InitializeComponent();
            BindingContext = new PickerViewModel();
        }
    }
}