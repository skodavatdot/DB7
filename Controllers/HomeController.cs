﻿using DB7.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DB7.Webapplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public JsonResult RetrivePositionfields()
        {

            List<BWAS_RPARequestPersonnelAction> lstBwas = new List<BWAS_RPARequestPersonnelAction>();

            // Add parts to the list.
            lstBwas.Add(new BWAS_RPARequestPersonnelAction()
            {
                RPAHRPANo = "1",
                RPAStatus = "Active",
                RPAPActnReclass = true,
                RPAPActnRedirect = false,
                RPAPActnFill = false,
                RPAPActnRefill = false,
                RPAPActnReorg = false,
                RPAPActnSpeclnst = "RPA Special Instruction1",
                RPAPActnCeaExempt = false,
                RPAPHireApprover = "Test",
                RPAPActnBlanket = false,
                RPAPActnPromolnPlace = false,
                RPAPContactFstNm = "TestAFName1",
                RPAPContactLstNm = "TestALName1",
                RPAPContactTelNo = "123-456-7891",
                RPAPComments = "RPA Comments1",
                RPAEReqEffD = Convert.ToDateTime("1/1/2019"),
                RPAEOfficialEffDt = Convert.ToDateTime("1/1/2019"),
                RPAEListType = "List Type",
                RPAETransfrType = "FT",
                RPAEReinsMndtryPrmsv = "'1'",
                RPAETimeBaseFr = "1/1/2019",
                RPAETimeBaseTo = "2/1/2019",
                RPAETypeApptOther = "RPA others",
                RPAETAUMonths = 12,
                RPAETAUActHrsWkd = 12,
                RPAETimeBaseFraction = 12,
                RPAETimeBaseIntHrs = 18,
                RPAECEAExemptSalary = 6014,
                RPAEBilingualBox = true,
                RPAEBilingualHire = "Yes",
                RPAELangFluencyCert = true,
                RPAEMedExamReq = true,
                RPAELicCertReq = true,
                RPAELicCertExpDt = Convert.ToDateTime("1/1/2019"),
                RPAESalaryVolReduction = true,
                RPAEStateService = "'1'",
                RPAEDHCSEmployee = "'1'",
                RPAEAgncyCd = "806",
                RPAERptngUnit = "010",
                RPAEClassCd = "4255",
                RPAESerialNo = "604",
                RPAECurrLastAgncy = "test",
                OrganizationId = 1234,
                RPAPActnMerge = true,
                RPAEApptType = "'1'",
                RPAESpecialSalaryCEAExempt = true,
                RPAELimitedTermMonths = 12,
                RPAPPCACd = "testa",
                RPAPIndxCd = "1234",
                RPAHiringManagerApprover = "testA",
                RPAPersonnelLiaisonName = "TestA",
                RPAETimeBaseFrPT = 18,
                RPAETimeBaseToPT = 20,
                NoChangeInDuties = true
            });
            lstBwas.Add(new BWAS_RPARequestPersonnelAction()
            {
                RPAHRPANo = "2",
                RPAStatus = "Active",
                RPAPActnReclass = true,
                RPAPActnRedirect = false,
                RPAPActnFill = false,
                RPAPActnRefill = false,
                RPAPActnReorg = false,
                RPAPActnSpeclnst = "RPA Special Instruction2",
                RPAPActnCeaExempt = false,
                RPAPHireApprover = "Test",
                RPAPActnBlanket = false,
                RPAPActnPromolnPlace = false,
                RPAPContactFstNm = "TestAFName2",
                RPAPContactLstNm = "TestALName2",
                RPAPContactTelNo = "123-456-7899",
                RPAPComments = "RPA Comments2",
                RPAEReqEffD = Convert.ToDateTime("1/1/2019"),
                RPAEOfficialEffDt = Convert.ToDateTime("1/1/2019"),
                RPAEListType = "List Type",
                RPAETransfrType = "FT",
                RPAEReinsMndtryPrmsv = "'1'",
                RPAETimeBaseFr = "1/1/2019",
                RPAETimeBaseTo = "2/1/2019",
                RPAETypeApptOther = "RPA others",
                RPAETAUMonths = 12,
                RPAETAUActHrsWkd = 12,
                RPAETimeBaseFraction = 12,
                RPAETimeBaseIntHrs = 18,
                RPAECEAExemptSalary = 6014,
                RPAEBilingualBox = true,
                RPAEBilingualHire = "Yes",
                RPAELangFluencyCert = true,
                RPAEMedExamReq = true,
                RPAELicCertReq = true,
                RPAELicCertExpDt = Convert.ToDateTime("1/1/2019"),
                RPAESalaryVolReduction = true,
                RPAEStateService = "'1'",
                RPAEDHCSEmployee = "'1'",
                RPAEAgncyCd = "806",
                RPAERptngUnit = "010",
                RPAEClassCd = "4255",
                RPAESerialNo = "604",
                RPAECurrLastAgncy = "test",
                OrganizationId = 1234,
                RPAPActnMerge = true,
                RPAEApptType = "'1'",
                RPAESpecialSalaryCEAExempt = true,
                RPAELimitedTermMonths = 12,
                RPAPPCACd = "testa",
                RPAPIndxCd = "1234",
                RPAHiringManagerApprover = "testA",
                RPAPersonnelLiaisonName = "TestA",
                RPAETimeBaseFrPT = 18,
                RPAETimeBaseToPT = 20,
                NoChangeInDuties = true
            });

            lstBwas.Add(new BWAS_RPARequestPersonnelAction()
            {
                RPAHRPANo = "3",
                RPAStatus = "Active",
                RPAPActnReclass = true,
                RPAPActnRedirect = false,
                RPAPActnFill = false,
                RPAPActnRefill = false,
                RPAPActnReorg = false,
                RPAPActnSpeclnst = "RPA Special Instruction",
                RPAPActnCeaExempt = false,
                RPAPHireApprover = "Test",
                RPAPActnBlanket = false,
                RPAPActnPromolnPlace = false,
                RPAPContactFstNm = "TestAFName3",
                RPAPContactLstNm = "TestALName3",
                RPAPContactTelNo = "123-456-7899",
                RPAPComments = "RPA Comments3",
                RPAEReqEffD = Convert.ToDateTime("1/1/2019"),
                RPAEOfficialEffDt = Convert.ToDateTime("1/1/2019"),
                RPAEListType = "List Type",
                RPAETransfrType = "FT",
                RPAEReinsMndtryPrmsv = "'1'",
                RPAETimeBaseFr = "1/1/2019",
                RPAETimeBaseTo = "2/1/2019",
                RPAETypeApptOther = "RPA others",
                RPAETAUMonths = 12,
                RPAETAUActHrsWkd = 12,
                RPAETimeBaseFraction = 12,
                RPAETimeBaseIntHrs = 18,
                RPAECEAExemptSalary = 6014,
                RPAEBilingualBox = true,
                RPAEBilingualHire = "Yes",
                RPAELangFluencyCert = true,
                RPAEMedExamReq = true,
                RPAELicCertReq = true,
                RPAELicCertExpDt = Convert.ToDateTime("1/1/2019"),
                RPAESalaryVolReduction = true,
                RPAEStateService = "'1'",
                RPAEDHCSEmployee = "'1'",
                RPAEAgncyCd = "806",
                RPAERptngUnit = "010",
                RPAEClassCd = "4255",
                RPAESerialNo = "604",
                RPAECurrLastAgncy = "test",
                OrganizationId = 1234,
                RPAPActnMerge = true,
                RPAEApptType = "'1'",
                RPAESpecialSalaryCEAExempt = true,
                RPAELimitedTermMonths = 12,
                RPAPPCACd = "testa",
                RPAPIndxCd = "1234",
                RPAHiringManagerApprover = "testA",
                RPAPersonnelLiaisonName = "TestA",
                RPAETimeBaseFrPT = 18,
                RPAETimeBaseToPT = 20,
                NoChangeInDuties = true
            });
            lstBwas.Add(new BWAS_RPARequestPersonnelAction()
            {
                RPAHRPANo = "4",
                RPAStatus = "Active",
                RPAPActnReclass = true,
                RPAPActnRedirect = false,
                RPAPActnFill = false,
                RPAPActnRefill = false,
                RPAPActnReorg = false,
                RPAPActnSpeclnst = "RPA Special Instruction4",
                RPAPActnCeaExempt = false,
                RPAPHireApprover = "Test",
                RPAPActnBlanket = false,
                RPAPActnPromolnPlace = false,
                RPAPContactFstNm = "TestAFName4",
                RPAPContactLstNm = "TestALName4",
                RPAPContactTelNo = "123-456-4444",
                RPAPComments = "RPA Comments4",
                RPAEReqEffD = Convert.ToDateTime("1/10/2019"),
                RPAEOfficialEffDt = Convert.ToDateTime("1/10/2019"),
                RPAEListType = "List Type",
                RPAETransfrType = "FT",
                RPAEReinsMndtryPrmsv = "'1'",
                RPAETimeBaseFr = "1/1/2019",
                RPAETimeBaseTo = "2/1/2019",
                RPAETypeApptOther = "RPA others",
                RPAETAUMonths = 12,
                RPAETAUActHrsWkd = 12,
                RPAETimeBaseFraction = 12,
                RPAETimeBaseIntHrs = 18,
                RPAECEAExemptSalary = 6014,
                RPAEBilingualBox = true,
                RPAEBilingualHire = "Yes",
                RPAELangFluencyCert = true,
                RPAEMedExamReq = true,
                RPAELicCertReq = true,
                RPAELicCertExpDt = Convert.ToDateTime("1/1/2019"),
                RPAESalaryVolReduction = true,
                RPAEStateService = "'1'",
                RPAEDHCSEmployee = "'1'",
                RPAEAgncyCd = "806",
                RPAERptngUnit = "010",
                RPAEClassCd = "4255",
                RPAESerialNo = "604",
                RPAECurrLastAgncy = "test",
                OrganizationId = 1234,
                RPAPActnMerge = true,
                RPAEApptType = "'1'",
                RPAESpecialSalaryCEAExempt = true,
                RPAELimitedTermMonths = 12,
                RPAPPCACd = "testa",
                RPAPIndxCd = "1234",
                RPAHiringManagerApprover = "testA",
                RPAPersonnelLiaisonName = "TestA",
                RPAETimeBaseFrPT = 18,
                RPAETimeBaseToPT = 20,
                NoChangeInDuties = true
            });



            lstBwas.Add(new BWAS_RPARequestPersonnelAction()
            {
                RPAHRPANo = "5",
                RPAStatus = "Active",
                RPAPActnReclass = true,
                RPAPActnRedirect = false,
                RPAPActnFill = false,
                RPAPActnRefill = false,
                RPAPActnReorg = false,
                RPAPActnSpeclnst = "RPA Special Instruction",
                RPAPActnCeaExempt = false,
                RPAPHireApprover = "Test",
                RPAPActnBlanket = false,
                RPAPActnPromolnPlace = false,
                RPAPContactFstNm = "TestAFName5",
                RPAPContactLstNm = "TestALName5",
                RPAPContactTelNo = "123-456-7899",
                RPAPComments = "RPA Comments5",
                RPAEReqEffD = Convert.ToDateTime("1/1/2019"),
                RPAEOfficialEffDt = Convert.ToDateTime("1/1/2019"),
                RPAEListType = "List Type",
                RPAETransfrType = "FT",
                RPAEReinsMndtryPrmsv = "'1'",
                RPAETimeBaseFr = "1/1/2019",
                RPAETimeBaseTo = "2/1/2019",
                RPAETypeApptOther = "RPA others",
                RPAETAUMonths = 12,
                RPAETAUActHrsWkd = 12,
                RPAETimeBaseFraction = 12,
                RPAETimeBaseIntHrs = 18,
                RPAECEAExemptSalary = 6014,
                RPAEBilingualBox = true,
                RPAEBilingualHire = "Yes",
                RPAELangFluencyCert = true,
                RPAEMedExamReq = true,
                RPAELicCertReq = true,
                RPAELicCertExpDt = Convert.ToDateTime("1/1/2019"),
                RPAESalaryVolReduction = true,
                RPAEStateService = "'1'",
                RPAEDHCSEmployee = "'1'",
                RPAEAgncyCd = "806",
                RPAERptngUnit = "010",
                RPAEClassCd = "4255",
                RPAESerialNo = "604",
                RPAECurrLastAgncy = "test",
                OrganizationId = 1234,
                RPAPActnMerge = true,
                RPAEApptType = "'1'",
                RPAESpecialSalaryCEAExempt = true,
                RPAELimitedTermMonths = 12,
                RPAPPCACd = "testa",
                RPAPIndxCd = "1234",
                RPAHiringManagerApprover = "testA",
                RPAPersonnelLiaisonName = "TestA",
                RPAETimeBaseFrPT = 18,
                RPAETimeBaseToPT = 20,
                NoChangeInDuties = true
            });
            lstBwas.Add(new BWAS_RPARequestPersonnelAction()
            {
                RPAHRPANo = "6",
                RPAStatus = "Active",
                RPAPActnReclass = true,
                RPAPActnRedirect = false,
                RPAPActnFill = false,
                RPAPActnRefill = false,
                RPAPActnReorg = false,
                RPAPActnSpeclnst = "RPA Special Instruction",
                RPAPActnCeaExempt = false,
                RPAPHireApprover = "Test",
                RPAPActnBlanket = false,
                RPAPActnPromolnPlace = false,
                RPAPContactFstNm = "TestAFName6",
                RPAPContactLstNm = "TestALName6",
                RPAPContactTelNo = "123-456-7899",
                RPAPComments = "RPA Comments6",
                RPAEReqEffD = Convert.ToDateTime("1/1/2019"),
                RPAEOfficialEffDt = Convert.ToDateTime("1/1/2019"),
                RPAEListType = "List Type",
                RPAETransfrType = "FT",
                RPAEReinsMndtryPrmsv = "'1'",
                RPAETimeBaseFr = "1/1/2019",
                RPAETimeBaseTo = "2/1/2019",
                RPAETypeApptOther = "RPA others",
                RPAETAUMonths = 12,
                RPAETAUActHrsWkd = 12,
                RPAETimeBaseFraction = 12,
                RPAETimeBaseIntHrs = 18,
                RPAECEAExemptSalary = 6014,
                RPAEBilingualBox = true,
                RPAEBilingualHire = "Yes",
                RPAELangFluencyCert = true,
                RPAEMedExamReq = true,
                RPAELicCertReq = true,
                RPAELicCertExpDt = Convert.ToDateTime("1/1/2019"),
                RPAESalaryVolReduction = true,
                RPAEStateService = "'1'",
                RPAEDHCSEmployee = "'1'",
                RPAEAgncyCd = "806",
                RPAERptngUnit = "010",
                RPAEClassCd = "4255",
                RPAESerialNo = "604",
                RPAECurrLastAgncy = "test",
                OrganizationId = 1234,
                RPAPActnMerge = true,
                RPAEApptType = "'1'",
                RPAESpecialSalaryCEAExempt = true,
                RPAELimitedTermMonths = 12,
                RPAPPCACd = "testa",
                RPAPIndxCd = "1234",
                RPAHiringManagerApprover = "testA",
                RPAPersonnelLiaisonName = "TestA",
                RPAETimeBaseFrPT = 18,
                RPAETimeBaseToPT = 20,
                NoChangeInDuties = true
            });



            return Json(lstBwas, JsonRequestBehavior.AllowGet);

        }


    }
}