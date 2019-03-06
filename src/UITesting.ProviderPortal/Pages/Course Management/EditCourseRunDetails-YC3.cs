﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
namespace UITesting.ProviderPortal.Pages.Course_Management
{
    
    public class EditCourseRunDetails_YC3 : BasePage 
    {
        private static String PAGE_TITLE = "Edit Course details";


        public EditCourseRunDetails_YC3(IWebDriver webDriver): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
    }
}
