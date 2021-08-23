using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AmigosSDK.Abstractions;
using System.Dynamic;

namespace AmigoExampleApp
{
    public partial class MainPage : ContentPage
    {
        public String amigosJWTString;
        public RAWebViewContext pageContext;

        public MainPage()
        {
            InitializeComponent();

            dynamic metadata = new ExpandoObject();
            metadata.lastPage = "home page";

            amigosJWTString = "some jwt string";

            pageContext = new RAWebViewContext
            {
                action = "Main Menu",
                metadata = metadata
            };

            //RideAmigosContent.Source = "http://localhost:3000/workplace-app-preview";
            RideAmigosContent.PageContext = pageContext;
            RideAmigosContent.JWTString = amigosJWTString;

        }
    }
}
