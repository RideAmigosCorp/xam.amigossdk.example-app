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

            // Uncomment this to point the SDK to a specific instance of the web app
            //RideAmigosContent.Source = "http://10.0.2.2:3000/workplace-app-preview";
            RideAmigosContent.PageContext = pageContext;
            RideAmigosContent.JWTString = amigosJWTString;
            RideAmigosContent.OnCloseRequested += OnCloseSDK;
        }

        /// <summary>
        /// An example event handler that demonstrates what happens when the SDK requests "close"
        /// This will need to be implemented within the embedding application
        /// to fully support the hardware back button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void OnCloseSDK(object sender, EventArgs e)
        {
            await DisplayAlert("Close Requested", "The SDK has requested to close.", "OK");
        }

        /// <summary>
        /// This is an example of overriding the default back button behavior and sending the
        /// back request to the SDK instead. This will need to be implemented within the embedding
        /// application in order to fully support the hardware back button.
        /// </summary>
        /// <returns></returns>
        protected override bool OnBackButtonPressed()
        {
            RideAmigosContent.BackPressed();
            return true;
        }
    }
}
