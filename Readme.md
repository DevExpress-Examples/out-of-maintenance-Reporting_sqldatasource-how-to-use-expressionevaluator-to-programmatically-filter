<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604746/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T328522)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [XtraReport2.cs](./CS/XtraReport2.cs) (VB: [XtraReport2.vb](./VB/XtraReport2.vb))
<!-- default file list end -->
# SqlDataSource - How to use ExpressionEvaluator to programmatically filter report data 


This example demonstrates how to use the DevExpress.Data.Filtering.Helpers.ExpressionEvaluator.Fit method to programmatically filter the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessSqlSqlDataSourcetopic">SqlDataSource</a> query. The Fit operation result is used in the band's <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_BeforePrinttopic">BeforePrint</a> event handler to allow or cancel rendering of the band content through the e.Cancel property. Please note that the filter expression should be construct according to the <strong><a href="https://documentation.devexpress.com/#CoreLibraries/CustomDocument4928">Criteria Language Syntax</a></strong>.<br><br>Other examples of using <strong>DevExpress.Data.Filtering.Helpers.ExpressionEvaluator</strong> appear here:<br><a href="https://www.devexpress.com/Support/Center/p/T328515">How to get one calculated field value in the other calculated field's GetResult event handler by using ExpressionEvaluator</a><br><a href="https://www.devexpress.com/Support/Center/p/T242016">How to evaluate the calculated field expression</a><br><a href="https://www.devexpress.com/Support/Center/p/T195040">First and last column value</a>

<br/>


