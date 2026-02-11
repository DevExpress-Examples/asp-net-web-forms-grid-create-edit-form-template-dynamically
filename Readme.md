<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128538784/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E986)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [EdiFormTemplate.cs](./CS/WebSite/App_Code/EdiFormTemplate.cs) (VB: [EdiFormTemplate.vb](./VB/WebSite/App_Code/EdiFormTemplate.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to create edit form templates dynamically


<p>This example illustrates how to add editors within EditFormTemplateContainer of ASPxGridView programmatically by implementing the ITemplate interface.<br> <br>Custom editors are added onto the edit form by creating a custom edit form template. In this example, a template is created as a descendant of the <a href="https://msdn.microsoft.com/en-gb/en-en/library/system.web.ui.itemplate.aspx">ITemplate</a> interface in the EditFormTemplate.cs file. The template is populated with content using the <a href="https://msdn.microsoft.com/en-gb/en-en/library/system.web.ui.itemplate.instantiatein(v=vs.110).aspx">InstantiateIn</a> method. The Update and Cancel edit form's regular buttons are kept within the custom edit form using <a href="https://documentation.devexpress.com/AspNet/9324/ASP-NET-WebForms-Controls/Grid-View/Concepts/Templates/Template-Replacements">Template Replacements</a> (the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxGridViewTemplateReplacement.class">ASPxGridViewTemplateReplacements</a> object). <br> <br>The edit form template is attached to the grid in the Page Load event handler. The edit form template's content can be accessed at runtime using the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxGridView.FindEditFormTemplateControl.method">FindEditFormTemplateControl</a> method. It receives a control's ID as a parameter and returns the control if it exists within the edit form template.</p>
<p><strong>See also:</strong><br> <a href="https://www.devexpress.com/Support/Center/p/E3735">ASPxGridView - How to load UserControl within EditFormTemplate at runtime </a></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-create-edit-form-template-dynamically&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-create-edit-form-template-dynamically&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
