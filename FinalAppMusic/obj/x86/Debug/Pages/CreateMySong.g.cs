﻿#pragma checksum "E:\C#_learning\T2009M_UWP\FinalAppMusic\Pages\CreateMySong.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F2B9B2F578F9F4734B7FD6F76772D6F978E19DEF414CC6A8DEE8DCD54E61E9F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalAppMusic.Pages
{
    partial class CreateMySong : 
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
            case 2: // Pages\CreateMySong.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.Button_Click;
                }
                break;
            case 3: // Pages\CreateMySong.xaml line 31
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.Button_Click_1;
                }
                break;
            case 4: // Pages\CreateMySong.xaml line 13
                {
                    this.txtThumbnail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Pages\CreateMySong.xaml line 14
                {
                    this.txtNameSong = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Pages\CreateMySong.xaml line 19
                {
                    this.txtUrlSong = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Pages\CreateMySong.xaml line 20
                {
                    this.txtDesc = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Pages\CreateMySong.xaml line 23
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element8 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element8).Checked += this.RadioButton_Checked;
                }
                break;
            case 9: // Pages\CreateMySong.xaml line 24
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element9 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element9).Checked += this.RadioButton_Checked;
                }
                break;
            case 10: // Pages\CreateMySong.xaml line 16
                {
                    this.txtSinger = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Pages\CreateMySong.xaml line 17
                {
                    this.txtAuthor = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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
