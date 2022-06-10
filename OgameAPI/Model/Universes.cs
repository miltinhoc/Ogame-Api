using System;
using System.Xml.Serialization;
using System.ComponentModel;

namespace OgameAPI.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute("universes")]
    public partial class Universes
    {

        private universesUniverse[] universeField;

        private uint timestampField;

        private string serverIdField;

        /// <remarks/>
        [XmlElementAttribute("universe")]
        public universesUniverse[] universe
        {
            get
            {
                return this.universeField;
            }
            set
            {
                this.universeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string serverId
        {
            get
            {
                return this.serverIdField;
            }
            set
            {
                this.serverIdField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class universesUniverse
    {

        private ushort idField;

        private string hrefField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }


}
