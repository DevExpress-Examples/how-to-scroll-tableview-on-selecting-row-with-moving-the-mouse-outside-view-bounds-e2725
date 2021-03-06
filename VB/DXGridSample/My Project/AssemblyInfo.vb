﻿' Developer Express Code Central Example:
' How to scroll TableView on selecting row/cell with moving the mouse outside view bounds
' 
' This example illustrates how to add the DXGrid behavior which provides the
' capability to select rows and cells by simply moving the mouse over them with
' the mouse button pressed and auto-scrolling the view in a necessary
' direction.
' This functionality was implemented via attached behavior for DXGrid
' which encapsulates all the selection functionality. The scrolling functionality
' was implemented in a separate class named ScrollController.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2725

' Developer Express Code Central Example:
' How to Select Rows via the mouse
' 
' This example demonstrates how to select rows by simply moving the mouse over
' them with the mouse button pressed
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2725


Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("DXGrid_AssignComboBoxToColumn")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("DXGrid_AssignComboBoxToColumn")>
<Assembly: AssemblyCopyright("Copyright ©  2009")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

'In order to begin building localizable applications, set 
'<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
'inside a <PropertyGroup>.  For example, if you are using US english
'in your source files, set the <UICulture> to en-US.  Then uncomment
'the NeutralResourceLanguage attribute below.  Update the "en-US" in
'the line below to match the UICulture setting in the project file.

'[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


	'(used if a resource is not found in the page, 
	' or application resource dictionaries)
	'(used if a resource is not found in the page, 
	' app, or any theme specific resource dictionaries)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>


' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
