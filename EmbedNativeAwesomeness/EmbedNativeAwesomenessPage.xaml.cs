using Xamarin.Forms;

namespace EmbedNativeAwesomeness
{
    public partial class EmbedNativeAwesomenessPage : ContentPage
    {
        public int SlideValue {
            get;
            set;
        }

        public EmbedNativeAwesomenessPage ()
        {
            InitializeComponent ();

            SlideValue = 5;
            BindingContext = this;
        }
    }
}
