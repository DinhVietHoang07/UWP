﻿#pragma checksum "D:\UWP\UWP\UWP\Plays\BlankPage1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A5A85E2D6E6A15DDAEB6EDF1268AE4F470D0BDBD5ED631160319042A59B58989"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP.Plays
{
    partial class BlankPage1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Plays\BlankPage1.xaml line 22
                {
                    this.txtUser = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Plays\BlankPage1.xaml line 23
                {
                    this.txtPassword = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Plays\BlankPage1.xaml line 17
                {
                    this.inputUser = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Plays\BlankPage1.xaml line 18
                {
                    this.inputPassword = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Plays\BlankPage1.xaml line 19
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.Button_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

