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
            
        }

        public class MenuPopulater
        {
            String name;
            public MenuPopulater(String name)
            {
                this.name = name;
            }

            public void populateMenu(LLDCourt court)
            {
                string result = null;
                string url = "https://api.hfs.purdue.edu/menus/v2/locations/" + name + "/2017-04-25" ;
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
                    foreach (var childElement4 in xdoc.Root.Elements("Meals").Elements("Meal").Elements("Stations").Elements("Station").Elements("Items").Elements("Item").Elements("Name"))
                        court.getLunchMenu().addFood(new Food(childElement4.Value));
          

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
            public ArrayList foodList;

            public Menu()
            {
                foodList = new ArrayList();
            }

            public void addFood(Food x)
            {
                foodList.Add(x);
            }

            public ArrayList getList()
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

        public class FoodTruck
        {
            public Menu truckMenu;
            public int matches;

            public FoodTruck(Menu truck)
            {
                truckMenu = truck;
                matches = 0;
            }

            public Menu getMenu()
            {
                return truckMenu;
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
    }
}
