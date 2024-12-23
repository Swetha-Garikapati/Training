using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class productDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                img.Visible = false;
                price.Visible = false;
            }
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            price.Visible = true;
        }

        protected void product_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedProduct = int.Parse(product.SelectedValue);


            img.Visible = false;
            price.Visible = false;


            switch (selectedProduct)
            {
                case 1:
                    img.ImageUrl = "Images/p1.jpg";
                    price.Text = "Price: $200";
                    break;
                case 2:
                    img.ImageUrl = "Images/p2.jpg";
                    price.Text = "Price: $150";
                    break;
                case 3:
                    img.ImageUrl = "Images/p3.jpg";
                    price.Text = "Price: $800";
                    break;
                case 4:
                    img.ImageUrl = "Images/p4.jpg";
                    price.Text = "Price: $550";
                    break;
                default:
                    img.Visible = false;
                    price.Visible = false;
                    break;
            }


            if (selectedProduct != 0)
            {
                img.Visible = true;
            }
        }
    }
}
