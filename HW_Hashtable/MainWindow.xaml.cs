using System;
using System.Collections;
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

namespace HW_Hashtable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        SortedList sortedList;
        int i = 1;
        
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
          
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(txtKey.Text.Trim(), txtValue.Text.Trim());
            MessageBox.Show("Key: '" + txtKey.Text + " , Value: '" + txtValue.Text );
            ClearText();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (sortedList.Contains(txtKey.Text.Trim()))
            {
                sortedList.Remove(txtKey.Text.Trim());
                MessageBox.Show("Value with key: '" + txtKey.Text.Trim() + "' Deleted.");
            }      
            ClearText();
        }

        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {
            string text_out = "";
            if (sortedList.Count == 0)
            {
                MessageBox.Show("This sortedList has no item.");
            }
            else if (sortedList.Count == 1)
            {
                MessageBox.Show("This sortedList has " + sortedList.Count.ToString() + " item.");
            }
            else
            {
                MessageBox.Show("This sortedList has " + sortedList.Count.ToString() + " items.");
            }

            ICollection iCollection = sortedList.Keys;
            foreach (string key in iCollection)
            {
               // MessageBox.Show(hashtable[key].ToString());
                text_out = text_out + i.ToString() + ") key: " + key.ToString() + " , Value: " + sortedList[key].ToString()+"\n";
                i++;
            }
            MessageBox.Show(text_out);
            ClearText();
        }

        private void ClearText()
        {
            txtKey.Clear();
            txtValue.Clear();
        }
    }
}
