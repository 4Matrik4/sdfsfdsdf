using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
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

namespace wpf_tarabaev
{

    public partial class PageTransaction : Page
    {
        public PageTransaction()
        {
            DataEntitiesTransaction = new TitleTransactionEntities();
            InitializeComponent();
            ListTransaction = new ObservableCollection<Transaction>();
        }
        public static TitleTransactionEntities DataEntitiesTransaction { get; set; }
        ObservableCollection<Transaction> ListTransaction;
        private bool isDirty = true;


        private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RewriteTransaction();
            DataGridTransaction.IsReadOnly = true;
            isDirty = true;
        }
        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Transaction transaction = Transaction.CreateTransaction(-1,  "не задано", "не задано", 0);
            try
            {
                DataEntitiesTransaction.Transactions.Add(transaction);
                ListTransaction.Add(transaction);
                DataGridTransaction.ScrollIntoView(transaction);
                DataGridTransaction.SelectedIndex = DataGridTransaction.Items.Count - 1;
                DataGridTransaction.Focus();
                DataGridTransaction.IsReadOnly = false;
                isDirty = true;
            }
            catch (DataServiceRequestException ex)
            {
                throw new ApplicationException("Ошибка добавления нового сотрудника в контекст данных" + ex.ToString());
            }
        }
        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DataEntitiesTransaction.SaveChanges();
            isDirty = true;
            DataGridTransaction.IsReadOnly = true;
        }
        private void FindCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            BorderFind2.Visibility = System.Windows.Visibility.Visible;
            isDirty = false;
        }
        private void EditCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DataGridTransaction.IsReadOnly = false;
            DataGridTransaction.BeginEdit();
            isDirty = false;
        }
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Transaction emp = DataGridTransaction.SelectedItem as Transaction;
            if (emp != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить сделку: " + emp.NameTrans.Trim(),
                    "Предупреждение", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    DataEntitiesTransaction.Transactions.Remove(emp);
                    DataGridTransaction.SelectedIndex = DataGridTransaction.SelectedIndex == 0 ? 1 : DataGridTransaction.SelectedIndex = 1;
                    ListTransaction.Remove(emp);
                    DataEntitiesTransaction.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }
        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }
        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        private void FindCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetTransaction();
            DataGridTransaction.SelectedIndex = 0;
        }
        private void GetTransaction()
        {
            var transactions = DataEntitiesTransaction.Transactions;
            var queryTransaction = from transaction in transactions
                                   orderby transaction.NameTrans
                                   select transaction;
            foreach (Transaction emp in queryTransaction)
            {
                ListTransaction.Add(emp);
            }
            DataGridTransaction.ItemsSource = ListTransaction;
        }
        private void RewriteTransaction()
        {
            DataEntitiesTransaction = new TitleTransactionEntities();
            ListTransaction.Clear();
            GetTransaction();
        }
        private void TextBoxNameTrans_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonFindNameTrans.IsEnabled = true;
            ButtonFindTitle.IsEnabled = false;
            ComboBoxTitle.SelectedIndex = -1;
        }
        private void ButtonFindNameTrans_Click(object sender, RoutedEventArgs e)
        {
            string nametrans = TextBoxNameTrans.Text;
            DataEntitiesTransaction = new TitleTransactionEntities();
            ListTransaction.Clear();
            var transactions = DataEntitiesTransaction.Transactions;
            var queryTransaction = from transaction in transactions
                                   where transaction.NameTrans == nametrans
                                   select transaction;
            foreach (Transaction emp in queryTransaction)
            {
                ListTransaction.Add(emp);
            }
            if (ListTransaction.Count > 0)
            {
                DataGridTransaction.ItemsSource = ListTransaction;
                ButtonFindNameTrans.IsEnabled = true;
                ButtonFindTitle.IsEnabled = false;
            }
            else
                MessageBox.Show("Сотрудник с фамилией \n" + nametrans + "\n не найден",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void ComboBoxTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonFindTitle.IsEnabled = true;
            ButtonFindNameTrans.IsEnabled = false;
            TextBoxNameTrans.Text = " ";
        }
        private void ButtonFindTitle_Click(object sender, RoutedEventArgs e)
        {
            DataEntitiesTransaction = new TitleTransactionEntities();
            ListTransaction.Clear();
            Title title = ComboBoxTitle.SelectedItem as Title;
            var transactions = DataEntitiesTransaction.Transactions;
            var queryTransaction = from transaction in transactions
                                    where transaction.TitleID == title.ID
                                    orderby transaction.NameTrans
                                    select transaction;
            foreach (Transaction emp in queryTransaction)
            {
                ListTransaction.Add(emp);
            }
            DataGridTransaction.ItemsSource = ListTransaction;
        }

        private void RefreshCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RewriteTransaction();
            DataGridTransaction.IsReadOnly = false;
            isDirty = true;
            BorderFind2.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
