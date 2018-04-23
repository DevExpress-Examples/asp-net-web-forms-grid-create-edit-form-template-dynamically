using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page{
    EdiFormTemplate template = new EdiFormTemplate();
    protected void Page_Load(object sender, EventArgs e){
        ASPxGridView1.Templates.EditForm = template;
        template.Grid = ASPxGridView1;
    }
    protected void ASPxGridView1_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e){
        ASPxPageControl pg = ((ASPxGridView)sender).FindEditFormTemplateControl("ASPxPageControl1") as ASPxPageControl;
        ASPxTextBox txt1 = pg.FindControl("ASPxTextBox1") as ASPxTextBox;
        e.NewValues["CategoryName"] = txt1.Text;
        ASPxTextBox txt2 = pg.FindControl("ASPxTextBox2") as ASPxTextBox;
        e.NewValues["Description"] = txt2.Text;
    }
    protected void ASPxGridView1_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e){
        ASPxPageControl pg = ((ASPxGridView)sender).FindEditFormTemplateControl("ASPxPageControl1") as ASPxPageControl;
        ASPxTextBox txt1 = pg.FindControl("ASPxTextBox1") as ASPxTextBox;
        e.NewValues["CategoryName"] = txt1.Text;
        ASPxTextBox txt2 = pg.FindControl("ASPxTextBox2") as ASPxTextBox;
        e.NewValues["Description"] = txt2.Text;
        e.NewValues["CategoryID"] = ((ASPxGridView)sender).VisibleRowCount + 1;
    }
}
