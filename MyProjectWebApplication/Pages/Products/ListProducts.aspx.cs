using SP.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SP.Pages.Products
{
    public partial class ListProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

             private void BindGrid()
            {
            ProductsGridView.AutoGenerateColumns = false;
            ProductsGridView.DataSource = DataAccessor.SelectProducts();
            ProductsGridView.DataBind();
            }
        
    }
}