﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace XpoTools.master
{

    public partial class IPLI_PDF_MERGE : XPBaseObject
    {
        string fOBJID;
        [Key]
        [Size(50)]
        public string OBJID
        {
            get { return fOBJID; }
            set { SetPropertyValue<string>("OBJID", ref fOBJID, value); }
        }
        string fBUS_CODE;
        [Size(50)]
        public string BUS_CODE
        {
            get { return fBUS_CODE; }
            set { SetPropertyValue<string>("BUS_CODE", ref fBUS_CODE, value); }
        }
        string fPROC_POS;
        [Size(50)]
        public string PROC_POS
        {
            get { return fPROC_POS; }
            set { SetPropertyValue<string>("PROC_POS", ref fPROC_POS, value); }
        }
        int fPROC_STATUS;
        public int PROC_STATUS
        {
            get { return fPROC_STATUS; }
            set { SetPropertyValue<int>("PROC_STATUS", ref fPROC_STATUS, value); }
        }
        int fEXE_PRIORITY;
        public int EXE_PRIORITY
        {
            get { return fEXE_PRIORITY; }
            set { SetPropertyValue<int>("EXE_PRIORITY", ref fEXE_PRIORITY, value); }
        }
        string fPROC_ERR_MSG;
        [Size(50)]
        public string PROC_ERR_MSG
        {
            get { return fPROC_ERR_MSG; }
            set { SetPropertyValue<string>("PROC_ERR_MSG", ref fPROC_ERR_MSG, value); }
        }
        DateTime fADD_TIME;
        public DateTime ADD_TIME
        {
            get { return fADD_TIME; }
            set { SetPropertyValue<DateTime>("ADD_TIME", ref fADD_TIME, value); }
        }
        DateTime fMODIFY_TIME;
        public DateTime MODIFY_TIME
        {
            get { return fMODIFY_TIME; }
            set { SetPropertyValue<DateTime>("MODIFY_TIME", ref fMODIFY_TIME, value); }
        }
        string frowid;
        [Size(50)]
        public string rowid
        {
            get { return frowid; }
            set { SetPropertyValue<string>("rowid", ref frowid, value); }
        }
    }

}
