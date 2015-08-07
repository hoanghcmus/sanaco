using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess.Classes;
using DataAccess.Help;

public partial class View_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.txtSearch.Attributes.Add("onkeypress", "button_click(this,'" + this.btnSearch.ClientID + "')");
            LoadParent("3");

            MenuBottomGioiThieu.IDTheLoai = "20";
            MenuBottomHuongDan.IDTheLoai = "34";
            MenuBottomChinhSach.IDTheLoai = "35";
        }
    }
    private void LoadParent(string idParent)
    {
        drlSearchOption.DataValueField = "ID";
        drlSearchOption.DataTextField = "TieuDe_Vn";
        List<TheLoai> listTL = TheLoai.LayTheoModule(idParent);
        if (listTL != null && listTL.Count > 0)
        {
            foreach (TheLoai tl in listTL)
            {
                tl.TieuDe_Vn = UCFirst(ShowTitle(tl.TieuDe_Vn).Trim().ToLower());
            }
        }
        drlSearchOption.DataSource = listTL;
        drlSearchOption.DataBind();
        drlSearchOption.Items.Insert(0, new ListItem("Tất cả danh mục", "0"));
    }

    public string ShowTitle(string title)
    {
        return DecodeHTML(HttpUtility.HtmlDecode(title));
    }

    public string DecodeHTML(string chuoi)
    {
        Regex regex = new Regex("\\<[^\\>]*\\>");
        chuoi = regex.Replace(chuoi, String.Empty);
        return chuoi;
    }

    protected string UCFirst(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        return char.ToUpper(s[0]) + s.Substring(1);
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string IDTheLoai = drlSearchOption.SelectedValue;
        string keyWord = txtSearch.Text.Trim();
        Response.Redirect(String.Format("/search/{0}/{1}.html", IDTheLoai, keyWord));
    }
}
