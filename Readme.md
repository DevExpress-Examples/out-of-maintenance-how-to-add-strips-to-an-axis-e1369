<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Strips/Form1.cs) (VB: [Form1.vb](./VB/Strips/Form1.vb))
<!-- default file list end -->
# How to add strips to an axis


This example demonstrates how [strips](https://docs.devexpress.com/WindowsForms/5784/controls-and-libraries/chart-control/axes/strips?p=netframework) can be created and customized at runtime.

Since strips reside in an appropriate [axis](https://docs.devexpress.com/WindowsForms/5779/controls-and-libraries/chart-control/diagram/axes?p=netframework) collection, you should first cast your [diagram](https://docs.devexpress.com/WindowsForms/5778/controls-and-libraries/chart-control/diagram?p=netframework) object to the required diagram type. Then, you can access the collection via the [Axis.Strips](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Axis2D.Strips?p=netframework) property.
