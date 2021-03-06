namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatZoneSummaryType
    {
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _id;
        
        private string _code;
        
        private string _name;
        
        private string _description;
        
        private string _totalSeatQty;
        
        private SeatZoneSummaryTypeType _type;
        
        public SeatZoneSummaryType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string TotalSeatQty
        {
            get
            {
                return this._totalSeatQty;
            }
            set
            {
                this._totalSeatQty = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SeatZoneSummaryTypeType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}