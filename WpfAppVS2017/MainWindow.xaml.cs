﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfAppVS2017
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
            using (StreamReader myStrm = new StreamReader(@"F:\file.txt"))
            {
                myStrm.ReadLine();
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




    }
}