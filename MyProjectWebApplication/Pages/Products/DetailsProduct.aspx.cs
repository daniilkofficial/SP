using SP.App_Code.DAL;
using System.Data.SqlTypes;
using SP.App_Code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP.Pages.Products
{
    public partial class DetailsProduct : System.Web.UI.Page
    {
        private int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                LabelMessage.Text = "Id is not defined!";
                LabelMessage.ForeColor = Color.Red;
                return;
            }

            LabelMessage.Text = string.Empty;
            id = int.Parse(Request.QueryString["id"]);

            if (!IsPostBack)
            {
                BindControls();//добавляет данные в поля
            }
        }
        private void BindControls()
        {
            ClassProducts details = DataAccessor.SelectProduct(id);
            NameProductLabel.Text = details.NameProduct;
            ImageProducts.ImageUrl = details.ImageProduct;
            LabelDescriptionProduct.Text = details.DescriptionProduct;
            LabelNameProduct.Text = details.NameProduct;
        }
    }
}