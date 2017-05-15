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
using Microsoft.Phone;
using Microsoft.Phone.Controls;
using System.Xml;
using System.Xml.Schema;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace AnatomyRef
{
    public partial class imageload : PhoneApplicationPage
    {
        //string id = string.Empty;
        int id = 0;
        

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (this.NavigationContext.QueryString.ContainsKey("id"))
            {
                id = int.Parse(NavigationContext.QueryString["id"]);
               // PageTitle.Text = id.ToString();
                id++;
                
                //


                string location = Application.Current.Resources["referencexml"].ToString();
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                XmlReader reflist = XmlReader.Create(location,settings);
                
                reflist.MoveToContent();                // Skip over the XML declaration
                reflist.ReadStartElement("anatomy");



                while (reflist.Read())
                {



                    switch (reflist.NodeType)
                    {
                        case XmlNodeType.Element:
                            {
                                if (reflist.Name.ToString() == "id")
                                {
                                    string tempid = reflist.ReadElementContentAsString("id", "");
                                   
                                    //if (reflist.LocalName == "id" && reflist.ReadAttributeValue())
                                    if (tempid.ToString() == id.ToString())
                                    {
                                        //reflist.MoveToNextAttribute();

                                        string title = reflist.ReadElementContentAsString("title", "");
                                        PageTitle.Text = title.ToString();
                                        int imagecount = int.Parse(reflist.ReadElementContentAsString("imgcount", ""));
                                        
                                        switch (imagecount)
                                        {
                                            case 1:
                                                {
                                                    string Source = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp = new BitmapImage();
                                                    bmp.UriSource = new Uri(Source.ToString(), UriKind.Relative);
                                                    image1.Source = bmp;

                                                
                                                }
                                                break;

                                            case 2:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;


                                                }
                                                break;

                                            case 3:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;
                                                    string Source3 = reflist.ReadElementContentAsString("imgurl3", "").ToString();
                                                    BitmapImage bmp3 = new BitmapImage();
                                                    bmp3.UriSource = new Uri(Source3.ToString(), UriKind.Relative);
                                                    image3.Source = bmp3;

                                                }
                                                break;

                                            case 4:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;
                                                    string Source3 = reflist.ReadElementContentAsString("imgurl3", "").ToString();
                                                    BitmapImage bmp3 = new BitmapImage();
                                                    bmp3.UriSource = new Uri(Source3.ToString(), UriKind.Relative);
                                                    image3.Source = bmp3;
                                                    string Source4 = reflist.ReadElementContentAsString("imgurl4", "").ToString();
                                                    BitmapImage bmp4 = new BitmapImage();
                                                    bmp4.UriSource = new Uri(Source4.ToString(), UriKind.Relative);
                                                    image4.Source = bmp4;
                                                }
                                                break;

                                            case 5:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;
                                                    string Source3 = reflist.ReadElementContentAsString("imgurl3", "").ToString();
                                                    BitmapImage bmp3 = new BitmapImage();
                                                    bmp3.UriSource = new Uri(Source3.ToString(), UriKind.Relative);
                                                    image3.Source = bmp3;
                                                    string Source4 = reflist.ReadElementContentAsString("imgurl4", "").ToString();
                                                    BitmapImage bmp4 = new BitmapImage();
                                                    bmp4.UriSource = new Uri(Source4.ToString(), UriKind.Relative);
                                                    image4.Source = bmp4;
                                                    string Source5 = reflist.ReadElementContentAsString("imgurl5", "").ToString();
                                                    BitmapImage bmp5 = new BitmapImage();
                                                    bmp5.UriSource = new Uri(Source5.ToString(), UriKind.Relative);
                                                    image5.Source = bmp5;
                                                }
                                                break;

                                            case 6:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;
                                                    string Source3 = reflist.ReadElementContentAsString("imgurl3", "").ToString();
                                                    BitmapImage bmp3 = new BitmapImage();
                                                    bmp3.UriSource = new Uri(Source3.ToString(), UriKind.Relative);
                                                    image3.Source = bmp3;
                                                    string Source4 = reflist.ReadElementContentAsString("imgurl4", "").ToString();
                                                    BitmapImage bmp4 = new BitmapImage();
                                                    bmp4.UriSource = new Uri(Source4.ToString(), UriKind.Relative);
                                                    image4.Source = bmp4;
                                                    string Source5 = reflist.ReadElementContentAsString("imgurl5", "").ToString();
                                                    BitmapImage bmp5 = new BitmapImage();
                                                    bmp5.UriSource = new Uri(Source5.ToString(), UriKind.Relative);
                                                    image5.Source = bmp5;
                                                    string Source6 = reflist.ReadElementContentAsString("imgurl6", "").ToString();
                                                    BitmapImage bmp6 = new BitmapImage();
                                                    bmp6.UriSource = new Uri(Source6.ToString(), UriKind.Relative);
                                                    image6.Source = bmp6;


                                                }
                                                break;

                                            case 7:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;
                                                    string Source3 = reflist.ReadElementContentAsString("imgurl3", "").ToString();
                                                    BitmapImage bmp3 = new BitmapImage();
                                                    bmp3.UriSource = new Uri(Source3.ToString(), UriKind.Relative);
                                                    image3.Source = bmp3;
                                                    string Source4 = reflist.ReadElementContentAsString("imgurl4", "").ToString();
                                                    BitmapImage bmp4 = new BitmapImage();
                                                    bmp4.UriSource = new Uri(Source4.ToString(), UriKind.Relative);
                                                    image4.Source = bmp4;
                                                    string Source5 = reflist.ReadElementContentAsString("imgurl5", "").ToString();
                                                    BitmapImage bmp5 = new BitmapImage();
                                                    bmp5.UriSource = new Uri(Source5.ToString(), UriKind.Relative);
                                                    image5.Source = bmp5;
                                                    string Source6 = reflist.ReadElementContentAsString("imgurl6", "").ToString();
                                                    BitmapImage bmp6 = new BitmapImage();
                                                    bmp5.UriSource = new Uri(Source5.ToString(), UriKind.Relative);
                                                    image6.Source = bmp6;
                                                    string Source7 = reflist.ReadElementContentAsString("imgurl7", "").ToString();
                                                    BitmapImage bmp7 = new BitmapImage();
                                                    bmp5.UriSource = new Uri(Source5.ToString(), UriKind.Relative);
                                                    image7.Source = bmp7;
                                                }
                                                break;

                                            case 8:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;
                                                    string Source3 = reflist.ReadElementContentAsString("imgurl3", "").ToString();
                                                    BitmapImage bmp3 = new BitmapImage();
                                                    bmp3.UriSource = new Uri(Source3.ToString(), UriKind.Relative);
                                                    image3.Source = bmp3;
                                                    string Source4 = reflist.ReadElementContentAsString("imgurl4", "").ToString();
                                                    BitmapImage bmp4 = new BitmapImage();
                                                    bmp4.UriSource = new Uri(Source4.ToString(), UriKind.Relative);
                                                    image4.Source = bmp4;
                                                    string Source5 = reflist.ReadElementContentAsString("imgurl5", "").ToString();
                                                    BitmapImage bmp5 = new BitmapImage();
                                                    bmp5.UriSource = new Uri(Source5.ToString(), UriKind.Relative);
                                                    image5.Source = bmp5;
                                                    string Source6 = reflist.ReadElementContentAsString("imgurl6", "").ToString();
                                                    BitmapImage bmp6 = new BitmapImage();
                                                    bmp6.UriSource = new Uri(Source6.ToString(), UriKind.Relative);
                                                    image6.Source = bmp6;
                                                    string Source7 = reflist.ReadElementContentAsString("imgurl7", "").ToString();
                                                    BitmapImage bmp7 = new BitmapImage();
                                                    bmp7.UriSource = new Uri(Source7.ToString(), UriKind.Relative);
                                                    image7.Source = bmp7;
                                                    string Source8 = reflist.ReadElementContentAsString("imgurl8", "").ToString();
                                                    BitmapImage bmp8 = new BitmapImage();
                                                    bmp8.UriSource = new Uri(Source8.ToString(), UriKind.Relative);
                                                    image8.Source = bmp8;
                                                }
                                                break;
                                            
                                            case 9:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;
                                                    string Source3 = reflist.ReadElementContentAsString("imgurl3", "").ToString();
                                                    BitmapImage bmp3 = new BitmapImage();
                                                    bmp3.UriSource = new Uri(Source3.ToString(), UriKind.Relative);
                                                    image3.Source = bmp3;
                                                    string Source4 = reflist.ReadElementContentAsString("imgurl4", "").ToString();
                                                    BitmapImage bmp4 = new BitmapImage();
                                                    bmp4.UriSource = new Uri(Source4.ToString(), UriKind.Relative);
                                                    image4.Source = bmp4;
                                                    string Source5 = reflist.ReadElementContentAsString("imgurl5", "").ToString();
                                                    BitmapImage bmp5 = new BitmapImage();
                                                    bmp5.UriSource = new Uri(Source5.ToString(), UriKind.Relative);
                                                    image5.Source = bmp5;
                                                    string Source6 = reflist.ReadElementContentAsString("imgurl6", "").ToString();
                                                    BitmapImage bmp6 = new BitmapImage();
                                                    bmp6.UriSource = new Uri(Source6.ToString(), UriKind.Relative);
                                                    image6.Source = bmp6;
                                                    string Source7 = reflist.ReadElementContentAsString("imgurl7", "").ToString();
                                                    BitmapImage bmp7 = new BitmapImage();
                                                    bmp7.UriSource = new Uri(Source7.ToString(), UriKind.Relative);
                                                    image7.Source = bmp7;
                                                    string Source8 = reflist.ReadElementContentAsString("imgurl8", "").ToString();
                                                    BitmapImage bmp8 = new BitmapImage();
                                                    bmp8.UriSource = new Uri(Source8.ToString(), UriKind.Relative);
                                                    image8.Source = bmp8;
                                                    string Source9 = reflist.ReadElementContentAsString("imgurl9", "").ToString();
                                                    BitmapImage bmp9 = new BitmapImage();
                                                    bmp9.UriSource = new Uri(Source9.ToString(), UriKind.Relative);
                                                    image9.Source = bmp9;
                                                }
                                                break;

                                            case 10:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;
                                                    string Source3 = reflist.ReadElementContentAsString("imgurl3", "").ToString();
                                                    BitmapImage bmp3 = new BitmapImage();
                                                    bmp3.UriSource = new Uri(Source3.ToString(), UriKind.Relative);
                                                    image3.Source = bmp3;
                                                    string Source4 = reflist.ReadElementContentAsString("imgurl4", "").ToString();
                                                    BitmapImage bmp4 = new BitmapImage();
                                                    bmp4.UriSource = new Uri(Source4.ToString(), UriKind.Relative);
                                                    image4.Source = bmp4;
                                                    string Source5 = reflist.ReadElementContentAsString("imgurl5", "").ToString();
                                                    BitmapImage bmp5 = new BitmapImage();
                                                    bmp5.UriSource = new Uri(Source5.ToString(), UriKind.Relative);
                                                    image5.Source = bmp5;
                                                    string Source6 = reflist.ReadElementContentAsString("imgurl6", "").ToString();
                                                    BitmapImage bmp6 = new BitmapImage();
                                                    bmp6.UriSource = new Uri(Source6.ToString(), UriKind.Relative);
                                                    image6.Source = bmp6;
                                                    string Source7 = reflist.ReadElementContentAsString("imgurl7", "").ToString();
                                                    BitmapImage bmp7 = new BitmapImage();
                                                    bmp7.UriSource = new Uri(Source7.ToString(), UriKind.Relative);
                                                    image7.Source = bmp7;
                                                    string Source8 = reflist.ReadElementContentAsString("imgurl8", "").ToString();
                                                    BitmapImage bmp8 = new BitmapImage();
                                                    bmp8.UriSource = new Uri(Source8.ToString(), UriKind.Relative);
                                                    image8.Source = bmp8;
                                                    string Source9 = reflist.ReadElementContentAsString("imgurl9", "").ToString();
                                                    BitmapImage bmp9 = new BitmapImage();
                                                    bmp9.UriSource = new Uri(Source9.ToString(), UriKind.Relative);
                                                    image9.Source = bmp9;
                                                    string Source10 = reflist.ReadElementContentAsString("imgurl10", "").ToString();
                                                    BitmapImage bmp10 = new BitmapImage();
                                                    bmp10.UriSource = new Uri(Source10.ToString(), UriKind.Relative);
                                                    image10.Source = bmp10;
                                                }
                                                break;

                                            case 11:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;
                                                    string Source3 = reflist.ReadElementContentAsString("imgurl3", "").ToString();
                                                    BitmapImage bmp3 = new BitmapImage();
                                                    bmp3.UriSource = new Uri(Source3.ToString(), UriKind.Relative);
                                                    image3.Source = bmp3;
                                                    string Source4 = reflist.ReadElementContentAsString("imgurl4", "").ToString();
                                                    BitmapImage bmp4 = new BitmapImage();
                                                    bmp4.UriSource = new Uri(Source4.ToString(), UriKind.Relative);
                                                    image4.Source = bmp4;
                                                    string Source5 = reflist.ReadElementContentAsString("imgurl5", "").ToString();
                                                    BitmapImage bmp5 = new BitmapImage();
                                                    bmp5.UriSource = new Uri(Source5.ToString(), UriKind.Relative);
                                                    image5.Source = bmp5;

                                                    string Source6 = reflist.ReadElementContentAsString("imgurl6", "").ToString();
                                                    BitmapImage bmp6 = new BitmapImage();
                                                    bmp6.UriSource = new Uri(Source6.ToString(), UriKind.Relative);
                                                    image6.Source = bmp6;
                                                    string Source7 = reflist.ReadElementContentAsString("imgurl7", "").ToString();
                                                    BitmapImage bmp7 = new BitmapImage();
                                                    bmp7.UriSource = new Uri(Source7.ToString(), UriKind.Relative);
                                                    image7.Source = bmp7;
                                                    string Source8 = reflist.ReadElementContentAsString("imgurl8", "").ToString();
                                                    BitmapImage bmp8 = new BitmapImage();
                                                    bmp8.UriSource = new Uri(Source8.ToString(), UriKind.Relative);
                                                    image8.Source = bmp8;
                                                    string Source9 = reflist.ReadElementContentAsString("imgurl9", "").ToString();
                                                    BitmapImage bmp9 = new BitmapImage();
                                                    bmp9.UriSource = new Uri(Source9.ToString(), UriKind.Relative);
                                                    image9.Source = bmp9;
                                                    string Source10 = reflist.ReadElementContentAsString("imgurl10", "").ToString();
                                                    BitmapImage bmp10 = new BitmapImage();
                                                    bmp10.UriSource = new Uri(Source10.ToString(), UriKind.Relative);
                                                    image10.Source = bmp10;
                                                    string Source11 = reflist.ReadElementContentAsString("imgurl11", "").ToString();
                                                    BitmapImage bmp11 = new BitmapImage();
                                                    bmp11.UriSource = new Uri(Source11.ToString(), UriKind.Relative);
                                                    image11.Source = bmp11;

                                                }
                                                break;
                                            
                                            case 12:
                                                {
                                                    string Source1 = reflist.ReadElementContentAsString("imgurl1", "").ToString();
                                                    BitmapImage bmp1 = new BitmapImage();
                                                    bmp1.UriSource = new Uri(Source1.ToString(), UriKind.Relative);
                                                    image1.Source = bmp1;
                                                    string Source2 = reflist.ReadElementContentAsString("imgurl2", "").ToString();
                                                    BitmapImage bmp2 = new BitmapImage();
                                                    bmp2.UriSource = new Uri(Source2.ToString(), UriKind.Relative);
                                                    image2.Source = bmp2;
                                                    string Source3 = reflist.ReadElementContentAsString("imgurl3", "").ToString();
                                                    BitmapImage bmp3 = new BitmapImage();
                                                    bmp3.UriSource = new Uri(Source3.ToString(), UriKind.Relative);
                                                    image3.Source = bmp3;
                                                    string Source4 = reflist.ReadElementContentAsString("imgurl4", "").ToString();
                                                    BitmapImage bmp4 = new BitmapImage();
                                                    bmp4.UriSource = new Uri(Source4.ToString(), UriKind.Relative);
                                                    image4.Source = bmp4;
                                                    string Source5 = reflist.ReadElementContentAsString("imgurl5", "").ToString();
                                                    BitmapImage bmp5 = new BitmapImage();
                                                    bmp5.UriSource = new Uri(Source5.ToString(), UriKind.Relative);
                                                    image5.Source = bmp5;
                                                    string Source6 = reflist.ReadElementContentAsString("imgurl6", "").ToString();
                                                    BitmapImage bmp6 = new BitmapImage();
                                                    bmp6.UriSource = new Uri(Source6.ToString(), UriKind.Relative);
                                                    image6.Source = bmp6;
                                                    string Source7 = reflist.ReadElementContentAsString("imgurl7", "").ToString();
                                                    BitmapImage bmp7 = new BitmapImage();
                                                    bmp7.UriSource = new Uri(Source7.ToString(), UriKind.Relative);
                                                    image7.Source = bmp7;
                                                    string Source8 = reflist.ReadElementContentAsString("imgurl8", "").ToString();
                                                    BitmapImage bmp8 = new BitmapImage();
                                                    bmp8.UriSource = new Uri(Source8.ToString(), UriKind.Relative);
                                                    image8.Source = bmp8;
                                                    string Source9 = reflist.ReadElementContentAsString("imgurl9", "").ToString();
                                                    BitmapImage bmp9 = new BitmapImage();
                                                    bmp9.UriSource = new Uri(Source9.ToString(), UriKind.Relative);
                                                    image9.Source = bmp9;
                                                    string Source10 = reflist.ReadElementContentAsString("imgurl10", "").ToString();
                                                    BitmapImage bmp10 = new BitmapImage();
                                                    bmp10.UriSource = new Uri(Source10.ToString(), UriKind.Relative);
                                                    image10.Source = bmp10;
                                                    string Source11 = reflist.ReadElementContentAsString("imgurl11", "").ToString();
                                                    BitmapImage bmp11 = new BitmapImage();
                                                    bmp11.UriSource = new Uri(Source11.ToString(), UriKind.Relative);
                                                    image11.Source = bmp11;
                                                    string Source12 = reflist.ReadElementContentAsString("imgurl12", "").ToString();
                                                    BitmapImage bmp12 = new BitmapImage();
                                                    bmp12.UriSource = new Uri(Source12.ToString(), UriKind.Relative);
                                                    image12.Source = bmp12;
                                                }
                                                break;
             
             
                                        }

                                        
                                    }


                                }
                            }

                            break;
                    }


                }


            }
        }


        public void loadxml()
        {
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
                            if (reflist.Name.ToString() == "topic")
                            {
                                if (reflist.Value == id.ToString())
                                {
                                    reflist.MoveToNextAttribute();

                                    string title = reflist.ReadElementContentAsString("title", "");
                                    PageTitle.Text = title.ToString();
                                }
                                    
                                    
                                    //string title = reflist.ReadElementContentAsString("title", "");

                                //reflist.MoveToContent();
                                //listBox1.Items.Add(title.ToString());
                            }
                        }

                        break;
                }


            }

 
        }

        public imageload()
        {
            InitializeComponent();
            loadxml();
        }
        
    }
}