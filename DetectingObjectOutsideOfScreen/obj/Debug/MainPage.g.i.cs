﻿

#pragma checksum "C:\Users\d.delaire\Documents\GitHub\Tutorials\DetectingObjectOutsideOfScreen\DetectingObjectOutsideOfScreen\DetectingObjectOutsideOfScreen\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "201513B050D421E5DBE2A91FC5131DD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DetectingObjectOutsideOfScreen
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ScrollViewer scrollviewer; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid MainPlayerGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid ObjectThatIWhatToSee; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid ObjectThatIAmTracking; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///MainPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            scrollviewer = (global::Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("scrollviewer");
            MainPlayerGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("MainPlayerGrid");
            ObjectThatIWhatToSee = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("ObjectThatIWhatToSee");
            ObjectThatIAmTracking = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("ObjectThatIAmTracking");
        }
    }
}



