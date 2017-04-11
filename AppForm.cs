using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public class Food
        {
            public String name;
            public Boolean isVegetarian;

            public Food()
            {
                this.name = "";
                this.isVegetarian = false;
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
