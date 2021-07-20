using System;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using UAutoTranslate;
using UAutoTranslate.Properties;

namespace UAutoTranslate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] myArray = Properties.Settings.Default.AppList.Cast<string>().ToArray();
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < myArray.Length; i++)
            {
                cmbGame.Items.Add(myArray[i]);
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        public void btnAccept_Click(object sender, RoutedEventArgs e)
        {            
            MSGShow("Точно хочете змінити мову цієї програми? Ви завжди зможете повернути переклад назад автоматично або вручну.");
        }
        private void btnComeback_Click(object sender, RoutedEventArgs e)
        {
            MSGShow("Точно хочете відновити початкову локалізацію вибраної програми?");
        }
        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            VisibleTextTogleToHelp();
        }
        private void VisibleTextTogleToHelp()
        {
            switch (CamebackBtnText.Visibility)
            {
                case Visibility.Visible:
                    CamebackBtnText.Visibility = Visibility.Hidden;
                    AcceptBtnText.Visibility = Visibility.Hidden;
                    MainHelpText.Visibility = Visibility.Hidden;
                    Main2HelpText.Visibility = Visibility.Hidden;
                    Main3HelpText.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    CamebackBtnText.Visibility = Visibility.Visible;
                    AcceptBtnText.Visibility = Visibility.Visible;
                    MainHelpText.Visibility = Visibility.Visible;
                    Main2HelpText.Visibility = Visibility.Visible;
                    Main3HelpText.Visibility = Visibility.Visible;
                    break;
            }
            
        }
        private void ingDon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("http://8.8.8.8");
        }
        public void MSGShow(string textmsg)
        {
            MessagesWindow MessagesWindow = new MessagesWindow();
            MessagesWindow.txtNeedMS.Text = textmsg;
            MessagesWindow.index.Text = Convert.ToString(cmbGame.SelectedIndex);            
            try{MessagesWindow.Owner = this;}catch (Exception){}            
            MessagesWindow.Show();
        }

        public void MSGEXShow(string textmsg)
        {
            MSGWex MSGWex = new MSGWex();
            MSGWex.txtNeedMS.Text = textmsg;
            try
            {
                MSGWex.Owner = this;
            }
            catch (Exception) { }

            MSGWex.Show();
        }

    }
}
