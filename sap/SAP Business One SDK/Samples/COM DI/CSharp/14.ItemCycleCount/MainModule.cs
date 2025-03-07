using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using SAPbobsCOM;

//  SAP DI API 2006 SDK Sample
//****************************************************************************
//
//  File:      MainModule.vb
//
//  Copyright (c) SAP
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
//****************************************************************************

//****************************************************************************
//
// Description:
// -------------
// 1) Log in to the company
// 2) Display how to add an existing Cycle Count to an existing item

//****************************************************************************


namespace ItemCycleCount
{
	sealed class MainModule
	{
		public static SAPbobsCOM.Company oCompany = new SAPbobsCOM.Company();
		public static SAPbobsCOM.CompanyService oCmpSrv;
		
		static public void Main ()
		{
			StartupForm frm = new StartupForm();
			frm.ShowDialog();
		}
		//init the service object
		public static void initCompanyService ()
		{
			//get company service
			oCmpSrv = oCompany.GetCompanyService();
		}
	}
	
}
