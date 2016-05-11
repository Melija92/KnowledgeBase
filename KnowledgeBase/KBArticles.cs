//////// KNOWLEDGE BASE ///////

using KnowledgeBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnowledgeBase
{
    /// <summary> 
    /// KB Articles
    /// </summary>
    public static class KBArticles
    {
        public static List<ArticlesList> Names;

        public static List<ArticlesList> GetMVCList()
        {
            var mvcData = GetListArticles().ToList().Where(x => x.ArticleURL.StartsWith("../MVC")).ToList().OrderByDescending(x => x.ArticleName.Contains("MVC")).ToList();
            return mvcData;
        }

        public static List<ArticlesList> GetASPNETList()
        {
            var aspnetData = GetListArticles().ToList().Where(x => x.ArticleURL.StartsWith("../ASPNET")).ToList();
            return aspnetData;
        }

        public static List<ArticlesList> GetEntityFrameworkList()
        {
            var efData = GetListArticles().ToList().Where(x => x.ArticleURL.StartsWith("../EntityFramework") || x.ArticleURL.StartsWith("../Linq")).ToList();
            return efData;
        }

        public static List<ArticlesList> GetXamariniOSList()
        {
            var xamarinData = GetListArticles().ToList().Where(x => x.ArticleURL.StartsWith("../XamariniOS")).ToList();
            return xamarinData;
        }

        public static List<ArticlesList> GetLinqList()
        {
            var xamarinData = GetListArticles().ToList().Where(x => x.ArticleURL.StartsWith("../Linq")).ToList();
            return xamarinData;
        }


        public static List<ArticlesList> GetListArticles()
        {
            Names = new List<ArticlesList>();

            Names.Add(new ArticlesList
            {
                ArticleName = "Encrypting Web Config using Command Line Arguments",
                ArticleURL = "../MVC/EncryptingWebConfigusingCommandLineArguments",
                Article = "EncryptingWebConfigusingCommandLineArguments"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating XSD and XML in .NET",
                ArticleURL = "../MVC/CreatingXSDandXMLinNET",
                Article = "CreatingXSDandXMLinNET"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Showing Live time in WebPage using Javascript",
                ArticleURL = "../MVC/ShowingLivetimeinWebPageusingJavascript",
                Article = "ShowingLivetimeinWebPageusingJavascript"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Custom Exceptions in CSharp",
                ArticleURL = "../MVC/CustomExceptionsinCSharp",
                Article = "CustomExceptionsinCSharp"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Request Processing in IIS",
                ArticleURL = "../MVC/RequestProcessinginIIS",
                Article = "RequestProcessinginIIS"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Generate Word Document in .NET",
                ArticleURL = "../MVC/GenerateWordDocumentinNET",
                Article = "GenerateWordDocumentinNET"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "ASP.NET Applications Using Wait Handles",
                ArticleURL = "../MVC/ASPNETApplicationsUsingWaitHandles",
                Article = "ASPNETApplicationsUsingWaitHandles"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Bulleted List Grid View",
                ArticleURL = "../MVC/BulletedListGridView",
                Article = "BulletedListGridView"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Exporting Grid View to PDF EXCEL WORD",
                ArticleURL = "../MVC/ExportingGridViewtoPDFEXCELWORD",
                Article = "ExportingGridViewtoPDFEXCELWORD"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Popup using CSS with ASP.NET",
                ArticleURL = "../MVC/CreatingPopupusingCSSwithASPNET",
                Article = "CreatingPopupusingCSSwithASPNET"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Alert Control in ASP.NET",
                ArticleURL = "../MVC/CreatingAlertControlinASPNET",
                Article = "CreatingAlertControlinASPNET"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Encrypting Query String",
                ArticleURL = "../MVC/EncryptingQueryString",
                Article = "EncryptingQueryString"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Opening Confirmation box from server side",
                ArticleURL = "../MVC/OpeningConfirmationboxfromserverside",
                Article = "OpeningConfirmationboxfromserverside"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "ASP.NET Routing",
                ArticleURL = "../MVC/ASPNETRouting",
                Article = "ASPNETRouting"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Building and Deployment of ASP.NET Application",
                ArticleURL = "../MVC/BuildingandDeploymentofASPNETApplication",
                Article = "BuildingandDeploymentofASPNETApplication"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Dynamic Data with ASP.NET",
                ArticleURL = "../MVC/DynamicDatawithASPNET",
                Article = "DynamicDatawithASPNET"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "ASP.NET Master Pages",
                ArticleURL = "../MVC/ASPNETMasterPages",
                Article = "ASPNETMasterPages"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Code First with Entity Framework",
                ArticleURL = "../EntityFramework/CodeFirstwithEntityFramework",
                Article = "CodeFirstwithEntityFramework"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Auditing with Entity Framework",
                ArticleURL = "../EntityFramework/AuditingwithEntityFramework",
                Article = "AuditingwithEntityFramework"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Model First with Entity Framework",
                ArticleURL = "../EntityFramework/CreatingModeFirstwithEntityFramework",
                Article = "CreatingModeFirstwithEntityFramework"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Entity Framework",
                ArticleURL = "../EntityFramework/EntityFramework",
                Article = "EntityFramework"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "MVC Architecture",
                ArticleURL = "../MVC/MVCArchitecture",
                Article = "MVCArchitecture"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Razor Engine",
                ArticleURL = "../MVC/RazorEngine",
                Article = "RazorEngine"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Razor Engine with Webmatrix",
                ArticleURL = "../MVC/RazorEnginewithWebmatrix",
                Article = "RazorEnginewithWebmatrix"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating First iOS Application",
                ArticleURL = "../XamariniOS/CreatingFirstApplication",
                Article = "CreatingFirstApplication"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Brief about Design Patterns",
                ArticleURL = "../MVC/BriefaboutDesignPatterns",
                Article = "BriefaboutDesignPatterns"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating WCF Service Application",
                ArticleURL = "../MVC/CreatingWCFServiceApplication",
                Article = "CreatingWCFServiceApplication"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Removing Repetitive Characters from the string",
                ArticleURL = "../MVC/Removingrepetitivecharactersfromthestring",
                Article = "Removingrepetitivecharactersfromthestring"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Language Integrated Query",
                ArticleURL = "../EntityFramework/Linq",
                Article = "Linq"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Windows Communication Foundation",
                ArticleURL = "../MVC/WindowsCommunicationFoundation",
                Article = "WindowsCommunicationFoundation"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Custom View With Xamarin iOS",
                ArticleURL = "../XamariniOS/CreatingCustomView",
                Article = "CreatingCustomView"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Push Notifications",
                ArticleURL = "../XamariniOS/WorkingWithPushNotifications",
                Article = "WorkingWithPushNotifications"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Custom TableVieCell Xamarin iOS",
                ArticleURL = "../XamariniOS/CreatingCustomTableViewCells",
                Article = "CreatingCustomTableViewCells"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Custom Fonts",
                ArticleURL = "../XamariniOS/WorkingWithCustomFonts",
                Article = "WorkingWithCustomFonts"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Animations Shaking a View",
                ArticleURL = "../XamariniOS/WorkingonAnimationsShakingView",
                Article = "WorkingonAnimationsShakingView"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Extensions in iOS8",
                ArticleURL = "../XamariniOS/WorkingwithExtensionsiniOS8",
                Article = "WorkingwithExtensionsiniOS8"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working on Animations Bubble Animation",
                ArticleURL = "../XamariniOS/WorkingonAnimationsBubbleAnimation",
                Article = "WorkingonAnimationsBubbleAnimation"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working On Floating Text Field",
                ArticleURL = "../XamariniOS/WorkingOnFloatingTextField",
                Article = "WorkingOnFloatingTextField"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working on Pull to Refresh",
                ArticleURL = "../XamariniOS/WorkingonPulltoRefresh",
                Article = "WorkingonPulltoRefresh"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Asynchronous Downloading",
                ArticleURL = "../XamariniOS/WorkingwithAsynchronousDownloading",
                Article = "WorkingwithAsynchronousDownloading"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With Application Settings",
                ArticleURL = "../XamariniOS/WorkingWithAppSettings",
                Article = "WorkingWithAppSettings"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With UISearchBar",
                ArticleURL = "../XamariniOS/WorkingWithSearchBar",
                Article = "WorkingWithSearchBar"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With Audio Playing Sounds in iOS Application",
                ArticleURL = "../XamariniOS/WorkingWithAudioPlayingSoundsiniOSApplication",
                Article = "WorkingWithAudioPlayingSoundsiniOSApplication"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Drawing Circle with CALayer",
                ArticleURL = "../XamariniOS/DrawingCirclewithCALayer",
                Article = "DrawingCirclewithCALayer"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Drawing Circle with Zoom Animation",
                ArticleURL = "../XamariniOS/DrawingCirclewithZoomAnimation",
                Article = "DrawingCirclewithZoomAnimation"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Alternative CollectionViews for iOS",
                ArticleURL = "../XamariniOS/AlternativeCollectionViewsiOS",
                Article = "AlternativeCollectionViewsiOS"
            });

            //Names.Add(new ArticlesList
            //{
            //    ArticleName = "Creating XibLess Application",
            //    ArticleURL = "../XamariniOS/CreatingXibLessApplication",
            //    Article = "CreatingXibLessApplication"
            //});

            //Names.Add(new ArticlesList
            //{
            //    ArticleName = "Working with Navigation Controller",
            //    ArticleURL = "../XamariniOS/WorkingwithNavigationBar",
            //    Article = "WorkingwithNavigationBar"
            //});

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Sectioned TableView With Alphabetical Order",
                ArticleURL = "../XamariniOS/CreatingSectionedTableViewWithAlphabeticalOrder",
                Article = "CreatingSectionedTableViewWithAlphabeticalOrder"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Custom Authorize Attribute in MVC",
                ArticleURL = "../MVC/CustomAuthorizeAttribute",
                Article = "CustomAuthorizeAttribute"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Exception Handling in MVC",
                ArticleURL = "../MVC/ExceptionHandlingMVC",
                Article = "ExceptionHandlingMVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Tracing in MVC",
                ArticleURL = "../MVC/TracinginMVC",
                Article = "TracinginMVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With RavenDB in MVC",
                ArticleURL = "../MVC/WorkingWithRavenDB",
                Article = "WorkingWithRavenDB"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Inheritance in EntityFramework",
                ArticleURL = "../EntityFramework/InheritanceWithEntityFramework",
                Article = "InheritanceWithEntityFramework"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Audit Log Action Filter in MVC",
                ArticleURL = "../MVC/AuditLogActionFilterinMVC",
                Article = "AuditLogActionFilterinMVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Usage Concurrent Dictionary in .NET",
                ArticleURL = "../MVC/ConcurrentDictionaryinNET",
                Article = "ConcurrentDictionaryinNET"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Live DateTime Using JQuery",
                ArticleURL = "../MVC/LiveDateTimeUsingJQuery",
                Article = "LiveDateTimeUsingJQuery"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With View Engines in MVC",
                ArticleURL = "../MVC/WorkingWithViewEnginesinMVC",
                Article = "WorkingWithViewEnginesinMVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With Dependency Injection in MVC Application",
                ArticleURL = "../MVC/WorkingWithDependencyInjection",
                Article = "WorkingWithDependencyInjection"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With MongoDB in MVC Application",
                ArticleURL = "../MVC/WorkingWithMongoDBinMVCApplication",
                Article = "WorkingWithMongoDBinMVCApplication"
            });
            Names.Add(new ArticlesList
            {
                ArticleName = "Caller Info Attributes in CSharp",
                ArticleURL = "../MVC/CallerInfoAttributesinCSharp",
                Article = "CallerInfoAttributesinCSharp"
            });
            return Names;
        }
    }
}