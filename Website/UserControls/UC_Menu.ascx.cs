using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess.Classes;
using System.Text;

public partial class Vn_Vn_Control_Menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string LoadMenu()
    {
        return BuildMenu(0).ToString();
    }

    protected StringBuilder BuildMenu(int id)
    {
        List<TheLoai> listTheLoai = TheLoai.TheLoai_GetByCategoryAndParentID("2", id);
        string activeMenuID = Request.QueryString["catID"] ?? "";


        StringBuilder sb = new StringBuilder();
        int count = 1;
        if (listTheLoai.Count() != 0)
        {
            sb.Append("<ul>");
            foreach (TheLoai theLoai in listTheLoai)
            {
                string hsClass = "v-has-sub";
                string rarow = "<span class='rarow'></span>";

                if (hasRow(theLoai.ID))
                {

                    if (count > 1)
                        hsClass = "v-has-sub1";                     

                    if (theLoai.ID.ToString().Equals(activeMenuID))
                    {
                        sb.Append(String.Format("<li class='{0} vactive'>", hsClass));
                        sb.Append("<a href='" + theLoai.DuongDan_Vn + "'> " + rarow + " <span>" + theLoai.TieuDe_Vn + "</span></a>");
                    }
                    else
                    {
                        sb.Append(String.Format("<li class='{0}'>", hsClass));
                        sb.Append("<a href='" + theLoai.DuongDan_Vn + "'> " + rarow + " <span>" + theLoai.TieuDe_Vn + "</span></a>");
                    }
                    count++;
                }
                else
                {
                    if (theLoai.ID.ToString().Equals(activeMenuID))
                    {
                        sb.Append("<li class='vactive'>");
                        sb.Append("<a href='" + theLoai.DuongDan_Vn + "'> " + rarow + " <span>" + theLoai.TieuDe_Vn + "</span></a>");
                    }
                    else
                    {
                        sb.Append("<li>");
                        sb.Append("<a href='" + theLoai.DuongDan_Vn + "'> " + rarow + " <span>" + theLoai.TieuDe_Vn + "</span></a>");
                    }
                }

                sb.Append(BuildMenu(theLoai.ID));

                sb.Append("</li>");
            }
            sb.Append("</ul>");
        }
        return sb;
    }

    private bool hasRow(int menuItemID)
    {

        bool value = false;
        List<TheLoai> theLoais = TheLoai.COUNT_ON_THELOAI(menuItemID);
        if (theLoais.Count() != 0)
        {
            value = true;
        }

        return value;
    }

}