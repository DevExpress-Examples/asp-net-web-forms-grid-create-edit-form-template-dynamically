# How to create edit form templates dynamically


<p>This example illustrates how to add editors within EditFormTemplateContainer of ASPxGridView programmatically by implementing the ITemplate interface.<br> <br>Custom editors are added onto the edit form by creating a custom edit form template. In this example, a template is created as a descendant of the <a href="https://msdn.microsoft.com/en-gb/en-en/library/system.web.ui.itemplate.aspx">ITemplate</a> interface in the EditFormTemplate.cs file. The template is populated with content using the <a href="https://msdn.microsoft.com/en-gb/en-en/library/system.web.ui.itemplate.instantiatein(v=vs.110).aspx">InstantiateIn</a> method. The Update and Cancel edit form's regular buttons are kept within the custom edit form using <a href="https://documentation.devexpress.com/AspNet/9324/ASP-NET-WebForms-Controls/Grid-View/Concepts/Templates/Template-Replacements">Template Replacements</a> (the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxGridViewTemplateReplacement.class">ASPxGridViewTemplateReplacements</a> object). <br> <br>The edit form template is attached to the grid in the Page Load event handler. The edit form template's content can be accessed at runtime using the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxGridView.FindEditFormTemplateControl.method">FindEditFormTemplateControl</a> method. It receives a control's ID as a parameter and returns the control if it exists within the edit form template.</p>
<p><strong>See also:</strong><br> <a href="https://www.devexpress.com/Support/Center/p/E3735">ASPxGridView - How to load UserControl within EditFormTemplate at runtime </a></p>

<br/>


