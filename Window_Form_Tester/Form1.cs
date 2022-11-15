using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Form_Tester
{
    public partial class Form1 : Form
    {
        
        public string TextBoxString
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }

        public string ComboBoxString
        {
            set { ComboBox.Items.Add( value ); }
        }
        
        // Create return current instance
        public static Form1 Instance
        {
            get { return instance; }
        }

        private static Form1 instance;
        public Form1()
        {
            // set instance    
            instance = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call TextBOx Class
            TextBoxClass nr = new TextBoxClass();
            
            // Call ComboBox Class
            ComboBoxClass cc = new ComboBoxClass();
            // Select 1st item in combobox
            ComboBox.SelectedIndex = 0;


        }
    }
}