using System;
using System.Windows;
using System.Diagnostics;
using System.Windows.Input;


namespace UAutoTranslate
{
    /// <summary>
    /// Interaction logic for MessagesWindow.xaml
    /// </summary>
    public partial class MessagesWindow : Window
    {        
        public MessagesWindow()
        {
            InitializeComponent();
        }
        private void RowDefinition_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            sbyte ind = Convert.ToSByte(index.Text);
            SetLang lang = new SetLang();
            MainWindow msg = new MainWindow();
            switch (ind)
            {
                case -1:                    
                    msg.MSGEXShow("Схоже ви не обрали нічого зі списку");
                    break;
                default:
                    bool is_w = lang.setLangByIndex(ind);
                    if (!is_w)
                    {
                        msg.MSGEXShow("Схоже сталася помилка");
                        break;
                    }                    
                    break;
            }
            Close();
        }
    }

}
