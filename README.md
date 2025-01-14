# Document Solutions for Excel
Document Solutions for Excel, .NET Edition (DsExcel) is a high-speed, small-footprint spreadsheet API that requires no dependencies on Excel. With full .NET Standard 2.0 support, you can generate, load, modify, and convert spreadsheets in .NET Framework, .NET Core, Mono, and Xamarin. Apps using this spreadsheet API can be deployed to cloud, Windows, Mac, or Linux. Its powerful calculation engine and breadth of features means you’ll never have to compromise design or requirements.

This repository contains source project of Examples and Showcases of **DsExcel** to help you learn and write your own applications. **Note** that you need to install [.NET Core SDK](https://www.microsoft.com/net/core) to run all these projects, and it may take a long time to run **AspNetCoreDemo** for the first time, because it needs to download and install some nodejs modules during the first run.

| Directory    | Description    |
| ------------- |-------------|
| Examples     | A collection of .NET examples that help you learn and explore the API features |
| AspNetCoreDemo/AspNetCore+React     | A source project that demonstrates how to use DsExcel with Asp.NET Core + React + Spread.Sheets (to run this project, install [.NET Core SDK](https://www.microsoft.com/net/core) and [NodeJS](https://nodejs.org/en/)) |
| AspNetCoreDemo/AspNetCore+Angular2     | A source project that demonstrates how to use DsExcel with Asp .Net Core + Angular2 + Spread.Sheets(to run this project, install [.NET Core SDK](https://www.microsoft.com/net/core) and [NodeJS](https://nodejs.org/en/))|
| Benchmark | Source projects to help users run performance tests on DsExcel (Put Excel files into the Files\Input folder and run the project to get performance data)|

# Limitations of non-licensed package
These projects use the non-licensed version of DsExcel. The non-licensed version has the following limitations:
* You can only open or save 100 Excel files.
* You can only run an application for up to 10 hours
* When you save a file, a new worksheet with watermark will be added stating that this was generated using a non-licensed evaluation version.

# Other Resources
* Online Demo: [https://developer.mescius.com/document-solutions/dot-net-excel-api/demos/](https://developer.mescius.com/document-solutions/dot-net-excel-api/demos/)
* Product Home Site: [https://developer.mescius.com/document-solutions/dot-net-excel-api](https://developer.mescius.com/document-solutions/dot-net-excel-api)
* Nuget Package: [https://www.nuget.org/packages/GrapeCity.Documents.Excel/](https://www.nuget.org/packages/GrapeCity.Documents.Excel/)
* .NET Core SDK: [https://www.microsoft.com/net/core](https://www.microsoft.com/net/core)
