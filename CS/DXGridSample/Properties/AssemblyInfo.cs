﻿// Developer Express Code Central Example:
// How to scroll TableView on selecting row/cell with moving the mouse outside view bounds
// 
// This example illustrates how to add the DXGrid behavior which provides the
// capability to select rows and cells by simply moving the mouse over them with
// the mouse button pressed and auto-scrolling the view in a necessary
// direction.
// This functionality was implemented via attached behavior for DXGrid
// which encapsulates all the selection functionality. The scrolling functionality
// was implemented in a separate class named ScrollController.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2725

// Developer Express Code Central Example:
// How to Select Rows via the mouse
// 
// This example demonstrates how to select rows by simply moving the mouse over
// them with the mouse button pressed
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2725

using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("DXGrid_AssignComboBoxToColumn")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("DXGrid_AssignComboBoxToColumn")]
[assembly: AssemblyCopyright("Copyright ©  2009")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

//In order to begin building localizable applications, set 
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
    //(used if a resource is not found in the page, 
    // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
    //(used if a resource is not found in the page, 
    // app, or any theme specific resource dictionaries)
)]


// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
