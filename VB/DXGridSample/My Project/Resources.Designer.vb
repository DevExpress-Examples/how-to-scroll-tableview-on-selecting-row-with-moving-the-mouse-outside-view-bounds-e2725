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

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3074
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace My


	''' <summary>
	'''   A strongly-typed resource class, for looking up localized strings, etc.
	''' </summary>
	' This class was auto-generated by the StronglyTypedResourceBuilder
	' class via a tool like ResGen or Visual Studio.
	' To add or remove a member, edit your .ResX file then rerun ResGen
	' with the /str option, or rebuild your VS project.
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
	Friend Class Resources

		Private Shared resourceMan As Global.System.Resources.ResourceManager

		Private Shared resourceCulture As Global.System.Globalization.CultureInfo

		<Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
		Friend Sub New()
		End Sub

		''' <summary>
		'''   Returns the cached ResourceManager instance used by this class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If (resourceMan Is Nothing) Then
					Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property

		''' <summary>
		'''   Overrides the current thread's CurrentUICulture property for all
		'''   resource lookups using this strongly typed resource class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set(ByVal value As System.Globalization.CultureInfo)
				resourceCulture = value
			End Set
		End Property
	End Class
End Namespace
