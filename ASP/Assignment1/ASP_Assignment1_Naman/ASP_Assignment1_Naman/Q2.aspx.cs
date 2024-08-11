using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace ASP_Assignment1_Naman
{
    public partial class Q2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblPrice.Text = string.Empty;
                imgFruit.ImageUrl = string.Empty;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string selectedFruit = ddlFruits.SelectedValue;
            SetFruitDetails(selectedFruit);
        }

        private void SetFruitDetails(string fruit)
        {
            string imagePath = string.Empty;
            string price = string.Empty;
            string bgColor = string.Empty;
            switch (fruit)
            {
                case "Apple":
                    imagePath = "~/Apple.jpg";
                    price = "200 rupees per kg";
                    bgColor = "#FF0800";
                    break;
                case "Banana":
                    imagePath = "~/Banana.jpg";
                    price = "60 rupees per dozen";
                    bgColor = "#FFE135";
                    break;
                case "Orange":
                    imagePath = "~/Orange.jpg";
                    price = "180 rupees per kg";
                    bgColor = "#FFA500";
                    break;
                case "Guava":
                    imagePath = "~/Guava.jpg";
                    price = "120 rupees per kg";
                    bgColor = "#7FFF00";
                    break;
                case "Mango":
                    imagePath = "~/Mango.jpg";
                    price = "150 rupees per kg";
                    bgColor = "#FFEB3B"; 
                    break;
                case "Pomegranate":
                    imagePath = "~/Pomegranate.jpg";
                    price = "250 rupees per kg";
                    bgColor = "#DC143C"; 
                    break;
                case "Pineapple":
                    imagePath = "~/Pineapple.jpg";
                    price = "80 rupees per kg";
                    bgColor = "#FFD700";
                    break;
                default:
                    price = string.Empty;
                    imgFruit.ImageUrl = string.Empty;
                    bgColor = "#FFFFFF";
                    break;          
            imgFruit.ImageUrl = imagePath;
            lblPrice.Text = price;
            fruitForm.Style["background-color"] = bgColor;
        }
    }
}