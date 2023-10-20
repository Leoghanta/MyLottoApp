using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyLottoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        PlayGame game = App.game;

        public MainPage()
        {
            this.InitializeComponent();

            User usr = new User("Jimi", "Jimi@Jimi.com", "123456");
            game.UsersList.Add(usr);

			User usr2 = new User("Bob", "Jimi@Jimi.com", "123456");
			game.UsersList.Add(usr2);
			User usr3 = new User("Fred", "Jimi@Jimi.com", "123456");
			game.UsersList.Add(usr3);

		}
    }
}
