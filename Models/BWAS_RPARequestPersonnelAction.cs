using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB7.Web.Models
{
    public class BWAS_RPARequestPersonnelAction
    {
        public string RPAHRPANo { get; set; }
        public string RPAStatus { get; set; }
        public bool? RPAPActnReclass { get; set; }
        public bool? RPAPActnRedirect { get; set; }
        public bool? RPAPActnFill { get; set; }
        public bool? RPAPActnRefill { get; set; }
        public bool? RPAPActnReorg { get; set; }
        public string RPAPActnSpeclnst { get; set; }
        public bool? RPAPActnCeaExempt { get; set; }
        public string RPAPHireApprover { get; set; }
        public bool? RPAPActnBlanket { get; set; }
        public bool? RPAPActnPromolnPlace { get; set; }
        public string RPAPContactFstNm { get; set; }
        public string RPAPContactLstNm { get; set; }
        public string RPAPContactTelNo { get; set; }
        public string RPAPComments { get; set; }
        public DateTime? RPAEReqEffD { get; set; }
        public DateTime? RPAEOfficialEffDt { get; set; }
        public string RPAEListType { get; set; }
        public string RPAETransfrType { get; set; }
        public string RPAEReinsMndtryPrmsv { get; set; }
        public string RPAETimeBaseFr { get; set; }
        public string RPAETimeBaseTo { get; set; }
        public string RPAETypeApptOther { get; set; }
        public int? RPAETAUMonths { get; set; }
        public decimal? RPAETAUActHrsWkd { get; set; }
        public decimal? RPAETimeBaseFraction { get; set; }
        public decimal? RPAETimeBaseIntHrs { get; set; }
        public decimal? RPAECEAExemptSalary { get; set; }
        public bool? RPAEBilingualBox { get; set; }
        public string RPAEBilingualHire { get; set; }
        public bool? RPAELangFluencyCert { get; set; }
        public bool? RPAEMedExamReq { get; set; }
        public bool? RPAELicCertReq { get; set; }
        public DateTime? RPAELicCertExpDt { get; set; }
        public bool? RPAESalaryVolReduction { get; set; }
        public string RPAEStateService { get; set; }
        public string RPAEDHCSEmployee { get; set; }
        public string RPAEAgncyCd { get; set; }
        public string RPAERptngUnit { get; set; }
        public string RPAEClassCd { get; set; }
        public string RPAESerialNo { get; set; }
        public string RPAECurrLastAgncy { get; set; }
        public int? OrganizationId { get; set; }
        public bool? RPAPActnMerge { get; set; }
        public string RPAEApptType { get; set; }
        public bool? RPAESpecialSalaryCEAExempt { get; set; }
        public int? RPAELimitedTermMonths { get; set; }
        public string RPAPPCACd { get; set; }
        public string RPAPIndxCd { get; set; }
        public string RPAHiringManagerApprover { get; set; }
        public string RPAPersonnelLiaisonName { get; set; }
        public decimal RPAETimeBaseFrPT { get; set; }
        public decimal RPAETimeBaseToPT { get; set; }
        public bool? NoChangeInDuties { get; set; }
    }
}