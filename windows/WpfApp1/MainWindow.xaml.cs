using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
            var client = new Game.GameClient(channel);

            var reply = client.Login(new LoginRequest
            {
                Username = "admin",
                Password = "password"
            });

            MessageBox.Show(reply.Expires, reply.Uuid);

            var metadata = new Metadata
            {
                { "token", reply.Uuid }
            };

            using (var call = client.Chat(metadata))
            {
                var responseReaderTask = Task.Run(async () =>
                {
                    while (await call.ResponseStream.MoveNext())
                    {
                        var note = call.ResponseStream.Current;
                        MessageBox.Show(note.ToString());
                    }
                });


                await call.RequestStream.CompleteAsync();
                await responseReaderTask;
            }

            channel.ShutdownAsync().Wait();


        }
    }
}
