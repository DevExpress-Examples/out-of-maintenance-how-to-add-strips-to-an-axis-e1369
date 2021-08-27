<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572593/12.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1369)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Strips/Form1.cs) (VB: [Form1.vb](./VB/Strips/Form1.vb))
<!-- default file list end -->
# How to add strips to an axis


This example demonstrates how [strips](https://docs.devexpress.com/WindowsForms/5784/controls-and-libraries/chart-control/axes/strips?p=netframework) can be created and customized at runtime.

Since strips reside in an appropriate [axis](https://docs.devexpress.com/WindowsForms/5779/controls-and-libraries/chart-control/diagram/axes?p=netframework) collection, you should first cast your [diagram](https://docs.devexpress.com/WindowsForms/5778/controls-and-libraries/chart-control/diagram?p=netframework) object to the required diagram type. Then, you can access the collection via the [Axis.Strips](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Axis2D.Strips?p=netframework) property.
