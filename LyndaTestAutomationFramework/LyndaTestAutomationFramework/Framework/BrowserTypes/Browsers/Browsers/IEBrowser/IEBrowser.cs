﻿using System;
using System.Collections.Generic;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using Ranorex.Controls;

using Browsers;
using Browsers.IEBrowser;

namespace Lynda.Test.Browsers
{

    /// <summary>
    /// Represents an Internet Explorer browser.
    /// </summary>
    internal class IEBrowser : BrowserBasic
    {    	    	    	
    	/// <summary>
        /// Version (Major version) of iexplore exe that this class supports.
        /// </summary>
    	static int supportedExeMajorVersion = 9;
    	
    	/// <summary>
        /// Expected full directory path of iexplore exe including the exe.
        /// </summary>
        static string expectedExePath = null;
        
        static string installedExePath = null;
        static int installedVersion = 0;  	

        /// <summary>
        /// IE Ranorex repository instance for this IE browser window.
        /// </summary>
        internal IE ieRepo = null;
        
        /// <summary>
        /// Static constructor for Lynda.Test.Browsers.IEBrowser class.
        /// </summary>
        static IEBrowser()
        {
        	expectedExePath = string.Format("{0}{1}",BrowserSystemInfo.ProgramFilesX86Path,"\\Internet Explorer\\iexplore.exe");
			installedExePath = BrowserSystemInfo.GetInstalledExePath(expectedExePath);
        	installedVersion = BrowserSystemInfo.GetInstalledVersion(expectedExePath);
        }       
       
        /// <summary>
        /// Initializes a new instance of the Lynda.Test.Browsers.IEBrowser class, opens a new IE window and navigates to
        /// the specified uri.
        /// </summary>
        /// <param name="uri">uri to navigate to in the new IE window.</param>
        /// <param name="killExisting">Kill all existing IE browser processes before opening a new IE window.</param>
        internal IEBrowser(string uri, bool killExisting)
        {       	       	        	
        	if (installedExePath == null)
        	{
        		throw new Exception(string.Format("Internet Explorer is not installed. Expected location:{0}",expectedExePath));
        	}
        	if (installedVersion != supportedExeMajorVersion)
    		{
    			throw new Exception(string.Format("Internet Explorer version {0} ({1}) is not supported by this class. Supported version: {2}.", installedVersion, installedExePath, supportedExeMajorVersion));
    		}
        	
        	ieRepo = new IE();

            //Kill existing browser processes before opening a new browser
            if (killExisting)
            {
                Host.Local.KillBrowser(BrowserProduct.IE.ToString());
            }

            //Open browser           
            OpenBrowser(uri, BrowserProduct.IE.ToString(), new RxPath("/form[@class='IEFrame']"));
            //Update repository instance base path to include native window handle attribute for the form
            ieRepo.Form.BasePath = new RxPath(String.Format("/form[@class='IEFrame' and @handle='{0}']", handle));
            Validate.Exists(ieRepo.Form.BasePath);
        }
        
        /// <summary>
        /// Major part of the file version of browser exe.
        /// Will be 0 if browser exe is not installed.
        /// </summary>
        internal static int InstalledVersion
        {
        	get{return installedVersion;}
        }
        
		/// <summary>
		/// Full directory path of installed browser exe.
		/// Will be null if browser exe is not installed.
		/// </summary>
        internal static string InstalledExePath
        {
        	get{return installedExePath;}
        }
        
        /// <summary>
        /// Version (Major version) of iexplore exe that this class supports.
        /// </summary>
        internal static int SupportedExeMajorVersion
        {
        	get {return supportedExeMajorVersion;}
        }
        
        /// <summary>
        /// Get the uri from this browser window's navigation edit box.
        /// </summary>
        internal string CurrentUri
        {
            get
            {
                Validate.Exists(ieRepo.Form.NavigateEditBox);
                return ieRepo.Form.NavigateEditBox.TextValue;
            }
        }
        
        /// <summary>
        /// Navigate to specified uri by typing it in the browser's navigate edit box and then pressing the {ENTER} key.
        /// </summary>
        /// <param name="uri">uri to navigate to.</param>
        internal void Navigate(string uri)
        {
            string navigateUri = ValidateUri(uri, true);
            //Click title bar of this window first so the navigate edit box is in the active window so it can be typed into
            ClickTitleBar();
            Validate.Exists(ieRepo.Form.NavigateEditBox);
            ieRepo.Form.NavigateEditBox.PressKeys(navigateUri);
        }

        /// <summary>
        /// Click the title bar of this browser window.
        /// </summary>
        internal void ClickTitleBar()
        {
            Validate.Exists(ieRepo.Form.TitleBar);
            //Click using move time, otherwise a click too soon after a previous call to ClickTitleBar() acts like a double-click on the title bar
            //(which can change the window size).
            ieRepo.Form.TitleBar.Click(new Duration(250));            
        }

        /// <summary>
        /// Half the size of this browser window.
        /// </summary>
        internal void HalfSize()
        {
            base.HalfSize(ieRepo.Form.Window);
        }

        /// <summary>
        /// Move this browser window.
        /// </summary>
        /// <param name="x">Adds this paramter to browser window's current screen location x-coordinate.</param>
        /// <param name="y">Adds this paramter to browser window's current screen location y-coordinate.</param>
        internal void Move(int x, int y)
        {
            base.Move(ieRepo.Form.Window, x, y);       
        }

        /// <summary>
        /// Included for API test stability purposes. Move this browser window down and up quickly four times.
        /// </summary>
        internal void Fun()
        {
            base.Fun(ieRepo.Form.Window);
        }
        
                 
    }  
    
}