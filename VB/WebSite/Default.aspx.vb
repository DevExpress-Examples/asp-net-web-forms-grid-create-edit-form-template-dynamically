Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Xml.Linq
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxTabControl

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private template As New EdiFormTemplate()
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxGridView1.Templates.EditForm = template
		template.Grid = ASPxGridView1
	End Sub
	Protected Sub ASPxGridView1_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
		Dim pg As ASPxPageControl = TryCast((CType(sender, ASPxGridView)).FindEditFormTemplateControl("ASPxPageControl1"), ASPxPageControl)
		Dim txt1 As ASPxTextBox = TryCast(pg.FindControl("ASPxTextBox1"), ASPxTextBox)
		e.NewValues("CategoryName") = txt1.Text
		Dim txt2 As ASPxTextBox = TryCast(pg.FindControl("ASPxTextBox2"), ASPxTextBox)
		e.NewValues("Description") = txt2.Text
	End Sub
	Protected Sub ASPxGridView1_RowInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs)
		Dim pg As ASPxPageControl = TryCast((CType(sender, ASPxGridView)).FindEditFormTemplateControl("ASPxPageControl1"), ASPxPageControl)
		Dim txt1 As ASPxTextBox = TryCast(pg.FindControl("ASPxTextBox1"), ASPxTextBox)
		e.NewValues("CategoryName") = txt1.Text
		Dim txt2 As ASPxTextBox = TryCast(pg.FindControl("ASPxTextBox2"), ASPxTextBox)
		e.NewValues("Description") = txt2.Text
		e.NewValues("CategoryID") = (CType(sender, ASPxGridView)).VisibleRowCount + 1
	End Sub
End Class
