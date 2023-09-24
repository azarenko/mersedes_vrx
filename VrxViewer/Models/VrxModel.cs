using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrxViewer.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.daimler.com/xsd/vdx30", IsNullable = false)]
    public partial class VehicleReport
    {

        private VehicleReportServiceTool serviceToolField;

        private VehicleReportVehicleInformation vehicleInformationField;

        private VehicleReportComponent[] componentListField;

        private string vDXVersionField;

        /// <remarks/>
        public VehicleReportServiceTool ServiceTool
        {
            get
            {
                return this.serviceToolField;
            }
            set
            {
                this.serviceToolField = value;
            }
        }

        /// <remarks/>
        public VehicleReportVehicleInformation VehicleInformation
        {
            get
            {
                return this.vehicleInformationField;
            }
            set
            {
                this.vehicleInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable = false)]
        public VehicleReportComponent[] ComponentList
        {
            get
            {
                return this.componentListField;
            }
            set
            {
                this.componentListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VDXVersion
        {
            get
            {
                return this.vDXVersionField;
            }
            set
            {
                this.vDXVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportServiceTool
    {

        private string nameField;

        private string versionField;

        private string userIDField;

        private System.DateTime executionTimeField;

        private string projectNameField;

        /// <remarks/>
        public string Name
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
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ExecutionTime
        {
            get
            {
                return this.executionTimeField;
            }
            set
            {
                this.executionTimeField = value;
            }
        }

        /// <remarks/>
        public string ProjectName
        {
            get
            {
                return this.projectNameField;
            }
            set
            {
                this.projectNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportVehicleInformation
    {

        private string fiNASNumberField;

        private VehicleReportVehicleInformationIdentificationNumber identificationNumberField;

        private byte modelLineNumberField;

        private VehicleReportVehicleInformationOdo odoField;

        private System.DateTime changeDateField;

        private byte serviceTypeField;

        /// <remarks/>
        public string FiNASNumber
        {
            get
            {
                return this.fiNASNumberField;
            }
            set
            {
                this.fiNASNumberField = value;
            }
        }

        /// <remarks/>
        public VehicleReportVehicleInformationIdentificationNumber IdentificationNumber
        {
            get
            {
                return this.identificationNumberField;
            }
            set
            {
                this.identificationNumberField = value;
            }
        }

        /// <remarks/>
        public byte ModelLineNumber
        {
            get
            {
                return this.modelLineNumberField;
            }
            set
            {
                this.modelLineNumberField = value;
            }
        }

        /// <remarks/>
        public VehicleReportVehicleInformationOdo Odo
        {
            get
            {
                return this.odoField;
            }
            set
            {
                this.odoField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ChangeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }

        /// <remarks/>
        public byte ServiceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportVehicleInformationIdentificationNumber
    {

        private string identificationNumberValueField;

        /// <remarks/>
        public string IdentificationNumberValue
        {
            get
            {
                return this.identificationNumberValueField;
            }
            set
            {
                this.identificationNumberValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportVehicleInformationOdo
    {

        private uint odoValueField;

        /// <remarks/>
        public uint OdoValue
        {
            get
            {
                return this.odoValueField;
            }
            set
            {
                this.odoValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponent
    {

        private string eCUShortNameField;

        private string locationShortNameField;

        private string locationAccessKeyField;

        private VehicleReportComponentDiagnosticInfo diagnosticInfoField;

        private string communicationProtocolField;

        private byte communicationStateField;

        private VehicleReportComponentDTCCount dTCCountField;

        private VehicleReportComponentSWHWInformation sWHWInformationField;

        private VehicleReportComponentConfig configField;

        private VehicleReportComponentDTCList dTCListField;

        private VehicleReportComponentAdditionalService[] additionalServiceField;

        /// <remarks/>
        public string ECUShortName
        {
            get
            {
                return this.eCUShortNameField;
            }
            set
            {
                this.eCUShortNameField = value;
            }
        }

        /// <remarks/>
        public string LocationShortName
        {
            get
            {
                return this.locationShortNameField;
            }
            set
            {
                this.locationShortNameField = value;
            }
        }

        /// <remarks/>
        public string LocationAccessKey
        {
            get
            {
                return this.locationAccessKeyField;
            }
            set
            {
                this.locationAccessKeyField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentDiagnosticInfo DiagnosticInfo
        {
            get
            {
                return this.diagnosticInfoField;
            }
            set
            {
                this.diagnosticInfoField = value;
            }
        }

        /// <remarks/>
        public string CommunicationProtocol
        {
            get
            {
                return this.communicationProtocolField;
            }
            set
            {
                this.communicationProtocolField = value;
            }
        }

        /// <remarks/>
        public byte CommunicationState
        {
            get
            {
                return this.communicationStateField;
            }
            set
            {
                this.communicationStateField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentDTCCount DTCCount
        {
            get
            {
                return this.dTCCountField;
            }
            set
            {
                this.dTCCountField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentSWHWInformation SWHWInformation
        {
            get
            {
                return this.sWHWInformationField;
            }
            set
            {
                this.sWHWInformationField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentConfig Config
        {
            get
            {
                return this.configField;
            }
            set
            {
                this.configField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentDTCList DTCList
        {
            get
            {
                return this.dTCListField;
            }
            set
            {
                this.dTCListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalService")]
        public VehicleReportComponentAdditionalService[] AdditionalService
        {
            get
            {
                return this.additionalServiceField;
            }
            set
            {
                this.additionalServiceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentDiagnosticInfo
    {

        private string diagnosticInfoValueField;

        /// <remarks/>
        public string DiagnosticInfoValue
        {
            get
            {
                return this.diagnosticInfoValueField;
            }
            set
            {
                this.diagnosticInfoValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentDTCCount
    {

        private byte dTCCountValueField;

        /// <remarks/>
        public byte DTCCountValue
        {
            get
            {
                return this.dTCCountValueField;
            }
            set
            {
                this.dTCCountValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentSWHWInformation
    {

        private VehicleReportComponentSWHWInformationSoftware[] softwareField;

        private VehicleReportComponentSWHWInformationHardware hardwareField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Software")]
        public VehicleReportComponentSWHWInformationSoftware[] Software
        {
            get
            {
                return this.softwareField;
            }
            set
            {
                this.softwareField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentSWHWInformationHardware Hardware
        {
            get
            {
                return this.hardwareField;
            }
            set
            {
                this.hardwareField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentSWHWInformationSoftware
    {

        private VehicleReportComponentSWHWInformationSoftwarePartNumber partNumberField;

        private VehicleReportComponentSWHWInformationSoftwareVersion versionField;

        private byte categoryField;

        private VehicleReportComponentSWHWInformationSoftwareSupplier supplierField;

        /// <remarks/>
        public VehicleReportComponentSWHWInformationSoftwarePartNumber PartNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentSWHWInformationSoftwareVersion Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public byte Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentSWHWInformationSoftwareSupplier Supplier
        {
            get
            {
                return this.supplierField;
            }
            set
            {
                this.supplierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentSWHWInformationSoftwarePartNumber
    {

        private string partNumberValueField;

        /// <remarks/>
        public string PartNumberValue
        {
            get
            {
                return this.partNumberValueField;
            }
            set
            {
                this.partNumberValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentSWHWInformationSoftwareVersion
    {

        private string versionValueField;

        /// <remarks/>
        public string VersionValue
        {
            get
            {
                return this.versionValueField;
            }
            set
            {
                this.versionValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentSWHWInformationSoftwareSupplier
    {

        private string codeField;

        private string nameField;

        /// <remarks/>
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string Name
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentSWHWInformationHardware
    {

        private VehicleReportComponentSWHWInformationHardwarePartNumber partNumberField;

        private VehicleReportComponentSWHWInformationHardwareVersion versionField;

        private VehicleReportComponentSWHWInformationHardwareSupplier supplierField;

        /// <remarks/>
        public VehicleReportComponentSWHWInformationHardwarePartNumber PartNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentSWHWInformationHardwareVersion Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentSWHWInformationHardwareSupplier Supplier
        {
            get
            {
                return this.supplierField;
            }
            set
            {
                this.supplierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentSWHWInformationHardwarePartNumber
    {

        private string partNumberValueField;

        /// <remarks/>
        public string PartNumberValue
        {
            get
            {
                return this.partNumberValueField;
            }
            set
            {
                this.partNumberValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentSWHWInformationHardwareVersion
    {

        private string versionValueField;

        /// <remarks/>
        public string VersionValue
        {
            get
            {
                return this.versionValueField;
            }
            set
            {
                this.versionValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentSWHWInformationHardwareSupplier
    {

        private string codeField;

        private string nameField;

        /// <remarks/>
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string Name
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentConfig
    {

        private byte recordCountField;

        private VehicleReportComponentConfigRecord[] recordField;

        /// <remarks/>
        public byte RecordCount
        {
            get
            {
                return this.recordCountField;
            }
            set
            {
                this.recordCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Record")]
        public VehicleReportComponentConfigRecord[] Record
        {
            get
            {
                return this.recordField;
            }
            set
            {
                this.recordField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentConfigRecord
    {

        private byte numberField;

        private string nameField;

        private string valueField;

        /// <remarks/>
        public byte Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public string Name
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
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentDTCList
    {

        private VehicleReportComponentDTCListDTC[] dTCField;

        private string maskField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DTC")]
        public VehicleReportComponentDTCListDTC[] DTC
        {
            get
            {
                return this.dTCField;
            }
            set
            {
                this.dTCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mask
        {
            get
            {
                return this.maskField;
            }
            set
            {
                this.maskField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentDTCListDTC
    {

        private string numberField;

        private string sAENumberField;

        private string descriptionField;

        private string testCompletionField;

        private string statusField;

        private string statusByteField;

        private VehicleReportComponentDTCListDTCExtendedDataRecord extendedDataRecordField;

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public string SAENumber
        {
            get
            {
                return this.sAENumberField;
            }
            set
            {
                this.sAENumberField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string TestCompletion
        {
            get
            {
                return this.testCompletionField;
            }
            set
            {
                this.testCompletionField = value;
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string StatusByte
        {
            get
            {
                return this.statusByteField;
            }
            set
            {
                this.statusByteField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentDTCListDTCExtendedDataRecord ExtendedDataRecord
        {
            get
            {
                return this.extendedDataRecordField;
            }
            set
            {
                this.extendedDataRecordField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentDTCListDTCExtendedDataRecord
    {

        private byte recordNumberField;

        private bool recordNumberFieldSpecified;

        private VehicleReportComponentDTCListDTCExtendedDataRecordEnvironmentData[] environmentDataField;

        /// <remarks/>
        public byte RecordNumber
        {
            get
            {
                return this.recordNumberField;
            }
            set
            {
                this.recordNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecordNumberSpecified
        {
            get
            {
                return this.recordNumberFieldSpecified;
            }
            set
            {
                this.recordNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnvironmentData")]
        public VehicleReportComponentDTCListDTCExtendedDataRecordEnvironmentData[] EnvironmentData
        {
            get
            {
                return this.environmentDataField;
            }
            set
            {
                this.environmentDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentDTCListDTCExtendedDataRecordEnvironmentData
    {

        private string shortNameField;

        private object longNameField;

        private string unitField;

        private string valueField;

        private string typeField;

        /// <remarks/>
        public string ShortName
        {
            get
            {
                return this.shortNameField;
            }
            set
            {
                this.shortNameField = value;
            }
        }

        /// <remarks/>
        public object LongName
        {
            get
            {
                return this.longNameField;
            }
            set
            {
                this.longNameField = value;
            }
        }

        /// <remarks/>
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentAdditionalService
    {

        private string shortNameField;

        private string longNameField;

        private string displayNameField;

        private VehicleReportComponentAdditionalServiceParameter[] requestField;

        private VehicleReportComponentAdditionalServiceResult resultField;

        /// <remarks/>
        public string ShortName
        {
            get
            {
                return this.shortNameField;
            }
            set
            {
                this.shortNameField = value;
            }
        }

        /// <remarks/>
        public string LongName
        {
            get
            {
                return this.longNameField;
            }
            set
            {
                this.longNameField = value;
            }
        }

        /// <remarks/>
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Parameter", IsNullable = false)]
        public VehicleReportComponentAdditionalServiceParameter[] Request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }

        /// <remarks/>
        public VehicleReportComponentAdditionalServiceResult Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentAdditionalServiceParameter
    {

        private string shortNameField;

        private string longNameField;

        private string valueField;

        private string typeField;

        /// <remarks/>
        public string ShortName
        {
            get
            {
                return this.shortNameField;
            }
            set
            {
                this.shortNameField = value;
            }
        }

        /// <remarks/>
        public string LongName
        {
            get
            {
                return this.longNameField;
            }
            set
            {
                this.longNameField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentAdditionalServiceResult
    {

        private VehicleReportComponentAdditionalServiceResultResponse responseField;

        /// <remarks/>
        public VehicleReportComponentAdditionalServiceResultResponse Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentAdditionalServiceResultResponse
    {

        private VehicleReportComponentAdditionalServiceResultResponseParameter parameterField;

        /// <remarks/>
        public VehicleReportComponentAdditionalServiceResultResponseParameter Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.daimler.com/xsd/vdx30")]
    public partial class VehicleReportComponentAdditionalServiceResultResponseParameter
    {

        private string shortNameField;

        private object longNameField;

        private string unitField;

        private string valueField;

        private string typeField;

        /// <remarks/>
        public string ShortName
        {
            get
            {
                return this.shortNameField;
            }
            set
            {
                this.shortNameField = value;
            }
        }

        /// <remarks/>
        public object LongName
        {
            get
            {
                return this.longNameField;
            }
            set
            {
                this.longNameField = value;
            }
        }

        /// <remarks/>
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }


}
