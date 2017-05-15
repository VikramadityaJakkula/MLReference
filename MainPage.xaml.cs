/// aPP bY Vikramaditya Jakkula
/// Machine Learning Reference App
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Xml;
using System.Xml.Schema;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;

namespace AnatomyRef
{
    public partial class MainPage : PhoneApplicationPage
    {
        string id = string.Empty;
        // Constructor
        public MainPage()
        {
            //string id;
            InitializeComponent();
            string location = Application.Current.Resources["referencexml"].ToString();
            XmlReader reflist = XmlReader.Create(location);
            reflist.MoveToContent();                // Skip over the XML declaration
            reflist.ReadStartElement("anatomy");
            


            while (reflist.Read())
            {



                switch (reflist.NodeType)
                {
                    case XmlNodeType.Element:
                        {
                            if (reflist.Name.ToString() == "title")
                            {
                                string title = reflist.ReadElementContentAsString("title", "");
                
                                //reflist.MoveToContent();
                                listBox1.Items.Add(title.ToString());
                                listBox1.Items.Add(" ");
                            }
                        }

                        break;
                }

              
            }
            
        }
        
        
        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            id = Convert.ToString(listBox1.SelectedIndex);
            //button1_Click(null, new EventArgs());
           // button1.Click += new RoutedEventHandler(button1_Click);
            ButtonAutomationPeer peer = new ButtonAutomationPeer((Button)button1);
            IInvokeProvider ip = (IInvokeProvider)peer;
            ip.Invoke();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if( int.Parse(id)%2 == 0)
            
            NavigationService.Navigate(new Uri("/imageload.xaml?id=" + int.Parse(id)/2, UriKind.Relative));

        }
    }
}