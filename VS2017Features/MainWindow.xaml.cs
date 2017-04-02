using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace VS2017Features
{
    /// <summary>
    /// VS2017 Features 
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Customer> lstCust;
        public MainWindow()
        {
            InitializeComponent();
            lstCust = new List<Customer>();
        }

        #region Click Events

        private void BtnLoadAll_Click(object sender, RoutedEventArgs e)
        {
            lstCust = BuildCustomer();
            dgAll.ItemsSource = lstCust;
        }

        private void BtnMkNullError_Click(object sender, RoutedEventArgs e)
        {
            NullError();
        }

        private void BtnMkError_Click(object sender, RoutedEventArgs e)
        {
            MakeFileDoesNotError();
        }

        #endregion

        #region Private Methods
        private void MakeFileDoesNotError()
        {
            try
            {
                using (StreamReader myStrm = new StreamReader(@"F:\file.txt"))
                {
                    myStrm.ReadLine();
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException("The file is not available", ex);
            }

        }

        private static List<Customer> BuildCustomer()
        {
            for (int i = 0; i < 5; i++)
            {
                Customer cst = new Customer()
                {
                    CustId = i,
                    CustName = $"CustName{i}",
                    CustCode = $"CST{i}"
                };
                lstCust.Add(cst);
            }
            return lstCust;
        }

        private void NullError()
        {
            Customer cst = new Customer()
            {
                CustId = 1,
                CustName = "Microsoft",
                CustCode = "CST01"
            };
            cst = null;
            string nullError = cst.CustCode;

        }

        #endregion

        private void dgAll_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
