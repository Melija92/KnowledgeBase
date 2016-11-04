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
            var mvcData = GetListArticles().ToList().Where(x => x.Tag == "MVC").ToList();
            return mvcData;
        }

        public static List<ArticlesList> GetASPNETList()
        {
            var aspnetData = GetListArticles().ToList().Where(x => x.Tag == "ASPNET").ToList();
            return aspnetData;
        }

        public static List<ArticlesList> GetEntityFrameworkList()
        {
            var efData = GetListArticles().ToList().Where(x => x.Tag == "Entitiy Framework").ToList();
            return efData;
        }

        public static List<ArticlesList> GetXamariniOSList()
        {
            var xamarinData = GetListArticles().ToList().Where(x => x.Tag == "Xamarin").ToList();
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
                ArticleName = "Index",
                ArticleURL = "../Books/Index",
                Article = "Books Index",
                Tag = "Books"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "BooksDetail",
                ArticleURL = "../Books/BooksDetail",
                Article = "BooksDetail",
                Tag = "Books"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Encrypting Web Config using Command Line Arguments",
                ArticleURL = "../MVC/EncryptingWebConfigusingCommandLineArguments",
                Article = "EncryptingWebConfigusingCommandLineArguments",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating XSD and XML in .NET",
                ArticleURL = "../MVC/CreatingXSDandXMLinNET",
                Article = "CreatingXSDandXMLinNET",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Showing Live time in WebPage using Javascript",
                ArticleURL = "../MVC/ShowingLivetimeinWebPageusingJavascript",
                Article = "ShowingLivetimeinWebPageusingJavascript",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Custom Exceptions in CSharp",
                ArticleURL = "../MVC/CustomExceptionsinCSharp",
                Article = "CustomExceptionsinCSharp",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Request Processing in IIS",
                ArticleURL = "../MVC/RequestProcessinginIIS",
                Article = "RequestProcessinginIIS",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Generate Word Document in .NET",
                ArticleURL = "../MVC/GenerateWordDocumentinNET",
                Article = "GenerateWordDocumentinNET",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "ASP.NET Applications Using Wait Handles",
                ArticleURL = "../MVC/ASPNETApplicationsUsingWaitHandles",
                Article = "ASPNETApplicationsUsingWaitHandles",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Bulleted List Grid View",
                ArticleURL = "../MVC/BulletedListGridView",
                Article = "BulletedListGridView",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Exporting Grid View to PDF EXCEL WORD",
                ArticleURL = "../MVC/ExportingGridViewtoPDFEXCELWORD",
                Article = "ExportingGridViewtoPDFEXCELWORD",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Popup using CSS with ASP.NET",
                ArticleURL = "../MVC/CreatingPopupusingCSSwithASPNET",
                Article = "CreatingPopupusingCSSwithASPNET",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Alert Control in ASP.NET",
                ArticleURL = "../MVC/CreatingAlertControlinASPNET",
                Article = "CreatingAlertControlinASPNET",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Encrypting Query String",
                ArticleURL = "../MVC/EncryptingQueryString",
                Article = "EncryptingQueryString",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Opening Confirmation box from server side",
                ArticleURL = "../MVC/OpeningConfirmationboxfromserverside",
                Article = "OpeningConfirmationboxfromserverside",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "ASP.NET Routing",
                ArticleURL = "../MVC/ASPNETRouting",
                Article = "ASPNETRouting",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Building and Deployment of ASP.NET Application",
                ArticleURL = "../MVC/BuildingandDeploymentofASPNETApplication",
                Article = "BuildingandDeploymentofASPNETApplication",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Dynamic Data with ASP.NET",
                ArticleURL = "../MVC/DynamicDatawithASPNET",
                Article = "DynamicDatawithASPNET",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "ASP.NET Master Pages",
                ArticleURL = "../MVC/ASPNETMasterPages",
                Article = "ASPNETMasterPages",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Code First with Entity Framework",
                ArticleURL = "../EntityFramework/CodeFirstwithEntityFramework",
                Article = "CodeFirstwithEntityFramework",
                Tag = "Entitiy Framework"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Auditing with Entity Framework",
                ArticleURL = "../EntityFramework/AuditingwithEntityFramework",
                Article = "AuditingwithEntityFramework",
                Tag = "%"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Model First with Entity Framework",
                ArticleURL = "../EntityFramework/CreatingModeFirstwithEntityFramework",
                Article = "CreatingModeFirstwithEntityFramework",
                Tag = "Entitiy Framework"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Razor Engine",
                ArticleURL = "../MVC/RazorEngine",
                Article = "RazorEngine",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Razor Engine with Webmatrix",
                ArticleURL = "../MVC/RazorEnginewithWebmatrix",
                Article = "RazorEnginewithWebmatrix",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating First iOS Application",
                ArticleURL = "../XamariniOS/CreatingFirstApplication",
                Article = "CreatingFirstApplication",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Brief about Design Patterns",
                ArticleURL = "../MVC/BriefaboutDesignPatterns",
                Article = "BriefaboutDesignPatterns",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating WCF Service Application",
                ArticleURL = "../MVC/CreatingWCFServiceApplication",
                Article = "CreatingWCFServiceApplication",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Removing Repetitive Characters from the string",
                ArticleURL = "../MVC/Removingrepetitivecharactersfromthestring",
                Article = "Removingrepetitivecharactersfromthestring",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Language Integrated Query",
                ArticleURL = "../EntityFramework/Linq",
                Article = "Linq",
                Tag = "Entitiy Framework"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Windows Communication Foundation",
                ArticleURL = "../MVC/WindowsCommunicationFoundation",
                Article = "WindowsCommunicationFoundation",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Custom View With Xamarin iOS",
                ArticleURL = "../XamariniOS/CreatingCustomView",
                Article = "CreatingCustomView",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Push Notifications",
                ArticleURL = "../XamariniOS/WorkingWithPushNotifications",
                Article = "WorkingWithPushNotifications",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Custom TableVieCell Xamarin iOS",
                ArticleURL = "../XamariniOS/CreatingCustomTableViewCells",
                Article = "CreatingCustomTableViewCells",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Custom Fonts",
                ArticleURL = "../XamariniOS/WorkingWithCustomFonts",
                Article = "WorkingWithCustomFonts",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Animations Shaking a View",
                ArticleURL = "../XamariniOS/WorkingonAnimationsShakingView",
                Article = "WorkingonAnimationsShakingView",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Extensions in iOS8",
                ArticleURL = "../XamariniOS/WorkingwithExtensionsiniOS8",
                Article = "WorkingwithExtensionsiniOS8",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working on Animations Bubble Animation",
                ArticleURL = "../XamariniOS/WorkingonAnimationsBubbleAnimation",
                Article = "WorkingonAnimationsBubbleAnimation",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working On Floating Text Field",
                ArticleURL = "../XamariniOS/WorkingOnFloatingTextField",
                Article = "WorkingOnFloatingTextField",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working on Pull to Refresh",
                ArticleURL = "../XamariniOS/WorkingonPulltoRefresh",
                Article = "WorkingonPulltoRefresh",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Asynchronous Downloading",
                ArticleURL = "../XamariniOS/WorkingwithAsynchronousDownloading",
                Article = "WorkingwithAsynchronousDownloading",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With Application Settings",
                ArticleURL = "../XamariniOS/WorkingWithAppSettings",
                Article = "WorkingWithAppSettings",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With UISearchBar",
                ArticleURL = "../XamariniOS/WorkingWithSearchBar",
                Article = "WorkingWithSearchBar",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With Audio Playing Sounds in iOS Application",
                ArticleURL = "../XamariniOS/WorkingWithAudioPlayingSoundsiniOSApplication",
                Article = "WorkingWithAudioPlayingSoundsiniOSApplication",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Drawing Circle with CALayer",
                ArticleURL = "../XamariniOS/DrawingCirclewithCALayer",
                Article = "DrawingCirclewithCALayer",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Drawing Circle with Zoom Animation",
                ArticleURL = "../XamariniOS/DrawingCirclewithZoomAnimation",
                Article = "DrawingCirclewithZoomAnimation",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Alternative CollectionViews for iOS",
                ArticleURL = "../XamariniOS/AlternativeCollectionViewsiOS",
                Article = "AlternativeCollectionViewsiOS",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Creating Sectioned TableView With Alphabetical Order",
                ArticleURL = "../XamariniOS/CreatingSectionedTableViewWithAlphabeticalOrder",
                Article = "CreatingSectionedTableViewWithAlphabeticalOrder",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Custom Authorize Attribute in MVC",
                ArticleURL = "../MVC/CustomAuthorizeAttribute",
                Article = "CustomAuthorizeAttribute",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Exception Handling in MVC",
                ArticleURL = "../MVC/ExceptionHandlingMVC",
                Article = "ExceptionHandlingMVC",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Tracing in MVC",
                ArticleURL = "../MVC/TracinginMVC",
                Article = "TracinginMVC",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With RavenDB in MVC",
                ArticleURL = "../MVC/WorkingWithRavenDB",
                Article = "WorkingWithRavenDB",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Inheritance in EntityFramework",
                ArticleURL = "../EntityFramework/InheritanceWithEntityFramework",
                Article = "InheritanceWithEntityFramework",
                Tag = "Entity Framework"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Audit Log Action Filter in MVC",
                ArticleURL = "../MVC/AuditLogActionFilterinMVC",
                Article = "AuditLogActionFilterinMVC",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Usage Concurrent Dictionary in .NET",
                ArticleURL = "../MVC/ConcurrentDictionaryinNET",
                Article = "ConcurrentDictionaryinNET",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Live DateTime Using JQuery",
                ArticleURL = "../MVC/LiveDateTimeUsingJQuery",
                Article = "LiveDateTimeUsingJQuery",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With View Engines in MVC",
                ArticleURL = "../MVC/WorkingWithViewEnginesinMVC",
                Article = "WorkingWithViewEnginesinMVC",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With Dependency Injection in MVC Application",
                ArticleURL = "../MVC/WorkingWithDependencyInjection",
                Article = "WorkingWithDependencyInjection",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working With MongoDB in MVC Application",
                ArticleURL = "../MVC/WorkingWithMongoDBinMVCApplication",
                Article = "WorkingWithMongoDBinMVCApplication",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Caller Info Attributes in CSharp",
                ArticleURL = "../MVC/CallerInfoAttributesinCSharp",
                Article = "CallerInfoAttributesinCSharp",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Google Authentication in Mobile Application",
                ArticleURL = "../XamariniOS/GoogleAuthenticationinMobileApplication",
                Article = "GoogleAuthenticationinMobileApplication",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Playing Streaming Audio in iOS Application",
                ArticleURL = "../XamariniOS/PlayingStreamingAudioiniOSApplication",
                Article = "PlayingStreamingAudioiniOSApplication",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with SeriLog in .NET Core Application",
                ArticleURL = "../MVC/WorkingwithSeriLoginNETCoreApplication",
                Article = "WorkingwithSeriLoginNETCoreApplication",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Reading Plist File",
                ArticleURL = "../XamariniOS/ReadingPlistFile",
                Article = "ReadingPlistFile",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Generating Unique Keys and Random Passwords",
                ArticleURL = "../MVC/GeneratingUniqueKeysandRandomPasswords",
                Article = "GeneratingUniqueKeysandRandomPasswords",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Remote Data in Android Application",
                ArticleURL = "../XamariniOS/WorkingwithRemoteDatainAndroidApp",
                Article = "WorkingwithRemoteDatainAndroidApp",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Display Attribute in PCL",
                ArticleURL = "../XamariniOS/WorkingwithDisplayAttributeinPCL",
                Article = "WorkingwithDisplayAttributeinPCL",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with NSDate and DateTime in iOS",
                ArticleURL = "../XamariniOS/WorkingwithNSDateandDateTimeinXamariniOS",
                Article = "WorkingwithNSDateandDateTimeinXamariniOS",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Local Notifications in iOS",
                ArticleURL = "../XamariniOS/WorkingwithLocalNotificationsinXamariniOS",
                Article = "WorkingwithLocalNotificationsinXamariniOS",
                Tag = "Xamarin"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Entity Framework in .Net Core",
                ArticleURL = "../MVC/WorkingwithEntityFrameworkinNetCore",
                Article = "WorkingwithEntityFrameworkinNetCore",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Working with Azure Storage in Web Application",
                ArticleURL = "../MVC/WorkingwithAzureStorageinWebApplication",
                Article = "WorkingwithAzureStorageinWebApplication",
                Tag = "MVC"
            });

            Names.Add(new ArticlesList
            {
                ArticleName = "Leveraging Dynamic CSharp in Application",
                ArticleURL = "../MVC/LeveragingDynamicCsharpinApplication",
                Article = "LeveragingDynamicCsharpinApplication",
                Tag = "MVC"
            });
            Names.Add(new ArticlesList
            {
                ArticleName = "Working on Xamarin Obj-C Binding",
                ArticleURL = "../XamariniOS/XamarinObjCBinding",
                Article = "XamarinObjCBinding",
                Tag = "Xamarin"
            });
            return Names;
        }
    }
}