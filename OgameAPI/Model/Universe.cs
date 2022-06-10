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
    [XmlRootAttribute("universe")]
    public partial class Universe
    {

        private universePlanet[] planetField;

        private uint timestampField;

        private string serverIdField;

        /// <remarks/>
        [XmlElementAttribute("planet")]
        public universePlanet[] planets
        {
            get
            {
                return this.planetField;
            }
            set
            {
                this.planetField = value;
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
    public partial class universePlanet
    {

        private universePlanetMoon moonField;

        private uint idField;

        private uint playerField;

        private string nameField;

        private string coordsField;

        /// <remarks/>
        public universePlanetMoon moon
        {
            get
            {
                return this.moonField;
            }
            set
            {
                this.moonField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint id
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
        public uint player
        {
            get
            {
                return this.playerField;
            }
            set
            {
                this.playerField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string coords
        {
            get
            {
                return this.coordsField;
            }
            set
            {
                this.coordsField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class universePlanetMoon
    {

        private uint idField;

        private string nameField;

        private ushort sizeField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint id
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
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
    }
}
