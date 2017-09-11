using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Levart.UserInterface;
using Xamarin.Forms;

namespace Levart
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new DetailPage());

<<<<<<< HEAD

        }
=======
			MainPage = new NavigationPage( new MainPage());
		}
>>>>>>> 5571de3efd1763c5793679e69e606d497469effe



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
