namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public enum RequiredPaymentsTypeGuaranteePaymentGuaranteeType
    {
        
        /// <remarks/>
        GuaranteeRequired,
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CC/DC/Voucher")]
        CCDCVoucher,
        
        /// <remarks/>
        Profile,
        
        /// <remarks/>
        Deposit,
        
        /// <remarks/>
        PrePay,
    }
}