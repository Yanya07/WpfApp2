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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        private Notification notification;

        public MainWindow()
        {
            InitializeComponent();

            notification = new Notification();

            // Регистрация обработчиков событий
            notification.OnMessageNotification += HandleMessageNotification;
            notification.OnCallNotification += HandleCallNotification;
            notification.OnEmailNotification += HandleEmailNotification;
        }

        // Обработчики событий
        private void HandleMessageNotification(string message)
        {
            MessageBox.Show($"Сообщение отправлено: {message}", "Уведомление");
        }

        private void HandleCallNotification(string phoneNumber)
        {
            MessageBox.Show($"Звонок на номер: {phoneNumber}", "Уведомление");
        }

        private void HandleEmailNotification(string email)
        {
            MessageBox.Show($"Письмо отправлено на: {email}", "Уведомление");
        }

        // Методы для обработки кликов кнопок
        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string message = MessageTextBox.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                notification.SendMessage(message);
            }
            else
            {
                MessageBox.Show("Введите текст сообщения", "Ошибка");
            }
        }

        private void MakeCallButton_Click(object sender, RoutedEventArgs e)
        {
            string phoneNumber = PhoneNumberTextBox.Text;
            if (!string.IsNullOrWhiteSpace(phoneNumber))
            {
                notification.MakeCall(phoneNumber);
            }
            else
            {
                MessageBox.Show("Введите номер телефона", "Ошибка");
            }
        }

        private void SendEmailButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            if (!string.IsNullOrWhiteSpace(email))
            {
                notification.SendEmail(email);
            }
            else
            {
                MessageBox.Show("Введите адрес электронной почты", "Ошибка");
            }
        }
    }
}

