using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DiningCourtApp
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FordCourt court = new FordCourt();
            string result = null;
            string url = "https://api.hfs.purdue.edu/menus/v2/locations/Ford/2017-04-25";
            HttpWebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = @"Mozilla/6.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                request.Method = "GET";
                request.Accept = "application/xml";
                request.ContentType = "application/xml";
                response = request.GetResponse() as HttpWebResponse;
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                result = reader.ReadToEnd();
                System.Console.WriteLine(result);
                XDocument xdoc = XDocument.Parse(result);
                XElement childElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Lunch").Parent.LastNode;
                XElement stnChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)stnChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getLunchMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);

                    //Go to Next Station Node
                    stnChildElement = (XElement)stnChildElement.NextNode;
                } while (null != stnChildElement);

                XElement dinnerElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Dinner").Parent.LastNode;
                XElement dinChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)dinChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getDinnerMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                       // Console.WriteLine(court.getDinnerMenu().getList()[0].getName());
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);

                    //Go to Next Station Node
                    dinChildElement = (XElement)dinChildElement.NextNode;
                } while (null != dinChildElement);
            }
            catch (Exception ex)
            {
                // handle error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }
        }

    }

    public class Searcher {






    }

    public class MenuPopulater
    {
        String name;
        public MenuPopulater(String name)
        {
            this.name = name;
        }

        // Populates Dinner
        public void populateLLD(LLDCourt court)
        {
            string result = null;
            string url = "https://api.hfs.purdue.edu/menus/v2/locations/" + name + "/2017-04-27";
            HttpWebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = @"Mozilla/6.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                request.Method = "GET";
                request.Accept = "application/xml";
                request.ContentType = "application/xml";
                response = request.GetResponse() as HttpWebResponse;
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

                result = reader.ReadToEnd();
                System.Console.WriteLine(result);
                XDocument xdoc = XDocument.Parse(result);
                XElement childElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Lunch").Parent.LastNode;
                XElement stnChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)stnChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getLunchMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);
                    //Go to Next Station Node
                    stnChildElement = (XElement)stnChildElement.NextNode;
                } while (null != stnChildElement);

                XElement dinnerElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Dinner").Parent.LastNode;
                XElement dinChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)dinChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getDinnerMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);

                    //Go to Next Station Node
                    dinChildElement = (XElement)dinChildElement.NextNode;
                } while (null != dinChildElement);

                XElement lateLunchElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Late Lunch").Parent.LastNode;
                XElement lateLunchChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)lateLunchChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getLateLunchMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);

                    //Go to Next Station Node
                    lateLunchChildElement = (XElement)lateLunchChildElement.NextNode;
                } while (null != lateLunchChildElement);

            }
            catch (Exception ex)
            {
                // handle error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }
        }

        public void populateBLD(BLDCourt court)
        {
            string result = null;
            string url = "https://api.hfs.purdue.edu/menus/v2/locations/" + name + "/2017-04-27";
            HttpWebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = @"Mozilla/6.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                request.Method = "GET";
                request.Accept = "application/xml";
                request.ContentType = "application/xml";
                response = request.GetResponse() as HttpWebResponse;
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

                result = reader.ReadToEnd();
                System.Console.WriteLine(result);
                XDocument xdoc = XDocument.Parse(result);
                XElement childElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Lunch").Parent.LastNode;
                XElement stnChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)stnChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getLunchMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);
                    //Go to Next Station Node
                    stnChildElement = (XElement)stnChildElement.NextNode;
                } while (null != stnChildElement);

                XElement dinnerElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Dinner").Parent.LastNode;
                XElement dinChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)dinChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getDinnerMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);

                    //Go to Next Station Node
                    dinChildElement = (XElement)dinChildElement.NextNode;
                } while (null != dinChildElement);

                XElement breakfastElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Breakfast").Parent.LastNode;
                XElement breakfastChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)breakfastChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getBreakfastMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);

                    //Go to Next Station Node
                    breakfastChildElement = (XElement)breakfastChildElement.NextNode;
                } while (null != breakfastChildElement);

            }
            catch (Exception ex)
            {
                // handle error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }
        }

        public void populateFord(FordCourt court)
        {

            string result = null;
            string url = "https://api.hfs.purdue.edu/menus/v2/locations/" +name+ "/2017-04-27";
            HttpWebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = @"Mozilla/6.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                request.Method = "GET";
                request.Accept = "application/xml";
                request.ContentType = "application/xml";
                response = request.GetResponse() as HttpWebResponse;
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

                result = reader.ReadToEnd();
                System.Console.WriteLine(result);
                XDocument xdoc = XDocument.Parse(result);
                XElement childElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Lunch").Parent.LastNode;
                XElement stnChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)stnChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getLunchMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);
                    //Go to Next Station Node
                    stnChildElement = (XElement)stnChildElement.NextNode;
                } while (null != stnChildElement);

                XElement dinnerElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Dinner").Parent.LastNode;
                XElement dinChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)dinChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getDinnerMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);

                    //Go to Next Station Node
                    dinChildElement = (XElement)dinChildElement.NextNode;
                } while (null != dinChildElement);

                XElement lateLunchElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Late Lunch").Parent.LastNode;
                XElement lateLunchChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)lateLunchChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getLateLunchMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);

                    //Go to Next Station Node
                    lateLunchChildElement = (XElement)lateLunchChildElement.NextNode;
                } while (null != lateLunchChildElement);

                XElement breakfastElement = (XElement)xdoc.Root.Descendants("Meals").Descendants("Meal").Descendants("Name").Single(x => (string)x.Value == "Breakfast").Parent.LastNode;
                XElement breakfastChildElement = (XElement)childElement.FirstNode;
                do
                {
                    //Get Items Node 
                    XElement itemsChildElement = (XElement)breakfastChildElement.FirstNode.NextNode;
                    //Get Item Node
                    XElement itemChildElement = (XElement)itemsChildElement.FirstNode;
                    do
                    {
                        //Get the Name
                        Console.WriteLine(itemChildElement.Element("Name").Value);
                        court.getBreakfastMenu().addFood(new Food(itemChildElement.Element("Name").Value));
                        //Go to Next Item Node
                        itemChildElement = (XElement)itemChildElement.NextNode;
                    } while (null != itemChildElement);

                    //Go to Next Station Node
                    breakfastChildElement = (XElement)breakfastChildElement.NextNode;
                } while (null != breakfastChildElement);

            }
            catch (Exception ex)
            {
                // handle error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }
        }



    }

    public class Food
    {
        public String name;
        public Boolean isVegetarian;

        public Food()
        {
            this.name = "";
            this.isVegetarian = false;
        }

        public Food(String name)
        {
            this.name = name;
        }

        public Food(String name, Boolean isVegetarian)
        {
            this.name = name;
            this.isVegetarian = isVegetarian;
        }

        public String getName()
        {
            return name;

        }

        public Boolean getVegValue()
        {
            return isVegetarian;
        }
    }

    public class Menu
    {
        public List<Food> foodList;

        public Menu()
        {
            foodList = new List<Food>();
        }

        public void addFood(Food x)
        {
            foodList.Add(x);
        }

        public List<Food> getList()
        {
            return foodList;
        }

    }

    public interface DiningCourt
    {
        //public int matches;
        //public Menu courtMenuDinner;
        //public Menu courtMenuLunch;

        Menu getDinnerMenu();
        Menu getLunchMenu();


    }

    public class LLDCourt : DiningCourt //Hillenbrand and Windsor
    {
        public int matches;
        public Menu lunchMenu;
        public Menu lateLunchMenu;
        public Menu dinnerMenu;

        public LLDCourt()
        {
            matches = 0;
        }

        public LLDCourt(Menu lunch, Menu late, Menu dinner)
        {
            matches = 0;
            lunchMenu = lunch;
            lateLunchMenu = late;
            dinnerMenu = dinner;
        }

        public Menu getDinnerMenu()
        {
            return dinnerMenu;
        }

        public Menu getLunchMenu()
        {
            return lunchMenu;
        }

        public Menu getLateLunchMenu()
        {
            return lateLunchMenu;
        }

        public void addMatch()
        {
            matches++;
        }

        public int getMatches()
        {
            return matches;
        }
    }

    public class BLDCourt : DiningCourt //Hillenbrand and Windsor
    {
        public int matches;
        public Menu lunchMenu;
        public Menu breakfastMenu;
        public Menu dinnerMenu;

        public BLDCourt()
        {
            matches = 0;
        }

        public BLDCourt(Menu lunch, Menu bfast, Menu dinner)
        {
            matches = 0;
            lunchMenu = lunch;
            breakfastMenu = bfast;
            dinnerMenu = dinner;
        }

        public Menu getDinnerMenu()
        {
            return dinnerMenu;
        }

        public Menu getLunchMenu()
        {
            return lunchMenu;
        }

        public Menu getBreakfastMenu()
        {
            return breakfastMenu;
        }

        public void addMatch()
        {
            matches++;
        }

        public int getMatches()
        {
            return matches;
        }
    }

    public class FordCourt : LLDCourt
    {
        public Menu breakfastMenu;

        public FordCourt()
        {
            matches = 0;
            lunchMenu = new Menu();
            breakfastMenu = new Menu();
            lateLunchMenu = new Menu();
            dinnerMenu = new Menu();
        }

        public FordCourt(Menu lunch, Menu bfast, Menu dinner, Menu late)
        {
            matches = 0;
            lunchMenu = lunch;
            breakfastMenu = bfast;
            lateLunchMenu = late;
            dinnerMenu = dinner;
        }

        public Menu getBreakfastMenu()
        {
            return breakfastMenu;
        }
    }

}

