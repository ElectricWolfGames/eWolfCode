using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WebSockets
{
    // https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/sockets/sockets-overview

    // https://www.tabsoverspaces.com/233883-simple-websocket-client-and-server-application-using-dotnet
    public partial class MainWindow : Window
    {
        private SendMessageToWebHook _webHookSender = new SendMessageToWebHook();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Sending");
            _webHookSender.SendMessage("Hello web hook");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { }
    }
}