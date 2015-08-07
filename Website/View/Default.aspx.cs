using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FirstProductCatList.IDTheLoai = "1";
            FirstProductCatList.VitriQuangCao = 1;

            SecondProductCatList.IDTheLoai = "1";
            SecondProductCatList.VitriQuangCao = 2;

            ThreeProductCatList.IDTheLoai = "1";
            ThreeProductCatList.VitriQuangCao = 3;

            QuangCao1.AdWidth = "50";
            QuangCao1.IDTheLoai = "30";

            QuangCao2.AdWidth = "50";
            QuangCao2.IDTheLoai = "31";

            QuangCao3.AdWidth = "40";
            QuangCao3.IDTheLoai = "32";

            QuangCao4.AdWidth = "60";
            QuangCao4.IDTheLoai = "33";
        }
    }
}