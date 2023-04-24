Imports System
Imports System.Data
Imports System.Configuration
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Xml.Linq
Imports DevExpress.Web
''' <summary>
''' Summary description for EdiFormTemplate
''' </summary>
Public Class EdiFormTemplate
	Implements ITemplate

	Private _gridView As ASPxGridView

	Public Property Grid() As ASPxGridView
	   Get
		   Return _gridView
	   End Get

		Set(ByVal value As ASPxGridView)
			_gridView = value
		End Set
	End Property



	Public Sub New()

	End Sub

Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
	Dim index As Integer = (TryCast(container, GridViewEditFormTemplateContainer)).VisibleIndex

	Dim pc As New ASPxPageControl()
	pc.ID = "ASPxPageControl1"
	pc.TabPages.Add("CategoryName")
	pc.TabPages.Add("Description")

	Dim lab1 As New ASPxLabel()
	lab1.Text = "Categories:"
	pc.TabPages(0).Controls.Add(lab1)

	Dim catTxt As New ASPxTextBox()
	catTxt.ID = "ASPxTextBox1"
	If Not _gridView.IsNewRowEditing Then
		catTxt.Text = _gridView.GetRowValues(index, "CategoryName").ToString()
	End If
	pc.TabPages(0).Controls.Add(catTxt)

	Dim lab2 As New ASPxLabel()
	lab2.Text = "Description:"
	pc.TabPages(1).Controls.Add(lab2)

	Dim descTxt As New ASPxTextBox()
	descTxt.ID = "ASPxTextBox2"
	If Not _gridView.IsNewRowEditing Then
		descTxt.Text = _gridView.GetRowValues(index, "Description").ToString()
	End If
	pc.TabPages(1).Controls.Add(descTxt)


	container.Controls.Add(pc)

	Dim upd As New ASPxGridViewTemplateReplacement()
	upd.ReplacementType = GridViewTemplateReplacementType.EditFormUpdateButton
	upd.ID = "Update"
	container.Controls.Add(upd)

	Dim can As New ASPxGridViewTemplateReplacement()
	can.ReplacementType = GridViewTemplateReplacementType.EditFormCancelButton
	can.ID = "Cancel"
	container.Controls.Add(can)


End Sub
End Class
