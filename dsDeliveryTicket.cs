// Decompiled with JetBrains decompiler
// Type: VCSReport.DetailReport.DataSets.dsDeliveryTicket
// Assembly: VCSReport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3CBC2101-E91D-41B7-AE2D-8F13D26723CE
// Assembly location: C:\Program Files (x86)\BK-MIS\VCSReport.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace VCSReport.DetailReport.DataSets
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlRoot("dsDeliveryTicket")]
  [HelpKeyword("vs.data.DataSet")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [Serializable]
  public class dsDeliveryTicket : DataSet
  {
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    private dsDeliveryTicket.CoilsDataTable tableCoils;
    private dsDeliveryTicket.vOrdersDataTable tablevOrders;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    public dsDeliveryTicket.CoilsDataTable Coils
    {
      get
      {
        return this.tableCoils;
      }
    }

    [Browsable(false)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public dsDeliveryTicket.vOrdersDataTable vOrders
    {
      get
      {
        return this.tablevOrders;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [Browsable(true)]
    [DebuggerNonUserCode]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get
      {
        return this._schemaSerializationMode;
      }
      set
      {
        this._schemaSerializationMode = value;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public new DataTableCollection Tables
    {
      get
      {
        return base.Tables;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DebuggerNonUserCode]
    public new DataRelationCollection Relations
    {
      get
      {
        return base.Relations;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public dsDeliveryTicket()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected dsDeliveryTicket(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = (string) info.GetValue("XmlSchema", typeof (string));
        if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables["Coils"] != null)
            base.Tables.Add((DataTable) new dsDeliveryTicket.CoilsDataTable(dataSet.Tables["Coils"]));
          if (dataSet.Tables["vOrders"] != null)
            base.Tables.Add((DataTable) new dsDeliveryTicket.vOrdersDataTable(dataSet.Tables["vOrders"]));
          this.DataSetName = dataSet.DataSetName;
          this.Prefix = dataSet.Prefix;
          this.Namespace = dataSet.Namespace;
          this.Locale = dataSet.Locale;
          this.CaseSensitive = dataSet.CaseSensitive;
          this.EnforceConstraints = dataSet.EnforceConstraints;
          this.Merge(dataSet, false, MissingSchemaAction.Add);
          this.InitVars();
        }
        else
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public override DataSet Clone()
    {
      dsDeliveryTicket dsDeliveryTicket = (dsDeliveryTicket) base.Clone();
      dsDeliveryTicket.InitVars();
      dsDeliveryTicket.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) dsDeliveryTicket;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeTables()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeRelations()
    {
      return false;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["Coils"] != null)
          base.Tables.Add((DataTable) new dsDeliveryTicket.CoilsDataTable(dataSet.Tables["Coils"]));
        if (dataSet.Tables["vOrders"] != null)
          base.Tables.Add((DataTable) new dsDeliveryTicket.vOrdersDataTable(dataSet.Tables["vOrders"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
      {
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal void InitVars()
    {
      this.InitVars(true);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    internal void InitVars(bool initTable)
    {
      this.tableCoils = (dsDeliveryTicket.CoilsDataTable) base.Tables["Coils"];
      if (initTable && this.tableCoils != null)
        this.tableCoils.InitVars();
      this.tablevOrders = (dsDeliveryTicket.vOrdersDataTable) base.Tables["vOrders"];
      if (!initTable || this.tablevOrders == null)
        return;
      this.tablevOrders.InitVars();
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = "dsDeliveryTicket";
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/dsDeliveryTicket.xsd";
      this.EnforceConstraints = false;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableCoils = new dsDeliveryTicket.CoilsDataTable();
      base.Tables.Add((DataTable) this.tableCoils);
      this.tablevOrders = new dsDeliveryTicket.vOrdersDataTable();
      base.Tables.Add((DataTable) this.tablevOrders);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private bool ShouldSerializeCoils()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializevOrders()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      dsDeliveryTicket dsDeliveryTicket = new dsDeliveryTicket();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = dsDeliveryTicket.Namespace
      });
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsDeliveryTicket.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
          {
            memoryStream2.SetLength(0L);
            schema.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return schemaComplexType;
            }
          }
        }
        finally
        {
          if (memoryStream1 != null)
            memoryStream1.Close();
          if (memoryStream2 != null)
            memoryStream2.Close();
        }
      }
      xs.Add(schemaSerializable);
      return schemaComplexType;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void CoilsRowChangeEventHandler(object sender, dsDeliveryTicket.CoilsRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void vOrdersRowChangeEventHandler(object sender, dsDeliveryTicket.vOrdersRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class CoilsDataTable : TypedTableBase<dsDeliveryTicket.CoilsRow>
    {
      private DataColumn columnShift;
      private DataColumn columnWeight;
      private DataColumn columnCoilName;
      private DataColumn columnProductionDate;
      private DataColumn columnProductLotName;
      private DataColumn columnProductName;
      private DataColumn columnQualityID;
      private DataColumn columnGradeName;
      private DataColumn columnStoreName;
      private DataColumn columnASize;
      private DataColumn columnBarcode;
      private DataColumn columnCode;
      private DataColumn columnNumOfBars;
      private DataColumn columnLength;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn ShiftColumn
      {
        get
        {
          return this.columnShift;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn WeightColumn
      {
        get
        {
          return this.columnWeight;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn CoilNameColumn
      {
        get
        {
          return this.columnCoilName;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn ProductionDateColumn
      {
        get
        {
          return this.columnProductionDate;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ProductLotNameColumn
      {
        get
        {
          return this.columnProductLotName;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn ProductNameColumn
      {
        get
        {
          return this.columnProductName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn QualityIDColumn
      {
        get
        {
          return this.columnQualityID;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn GradeNameColumn
      {
        get
        {
          return this.columnGradeName;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn StoreNameColumn
      {
        get
        {
          return this.columnStoreName;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn ASizeColumn
      {
        get
        {
          return this.columnASize;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn BarcodeColumn
      {
        get
        {
          return this.columnBarcode;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn CodeColumn
      {
        get
        {
          return this.columnCode;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn NumOfBarsColumn
      {
        get
        {
          return this.columnNumOfBars;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn LengthColumn
      {
        get
        {
          return this.columnLength;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public dsDeliveryTicket.CoilsRow this[int index]
      {
        get
        {
          return (dsDeliveryTicket.CoilsRow) this.Rows[index];
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event dsDeliveryTicket.CoilsRowChangeEventHandler CoilsRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event dsDeliveryTicket.CoilsRowChangeEventHandler CoilsRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event dsDeliveryTicket.CoilsRowChangeEventHandler CoilsRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event dsDeliveryTicket.CoilsRowChangeEventHandler CoilsRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public CoilsDataTable()
      {
        this.TableName = "Coils";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal CoilsDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected CoilsDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddCoilsRow(dsDeliveryTicket.CoilsRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public dsDeliveryTicket.CoilsRow AddCoilsRow(string Shift, short Weight, string CoilName, DateTime ProductionDate, string ProductLotName, string ProductName, byte QualityID, string GradeName, string StoreName, string ASize, string Barcode, string Code, int NumOfBars, string Length)
      {
        dsDeliveryTicket.CoilsRow coilsRow = (dsDeliveryTicket.CoilsRow) this.NewRow();
        object[] objArray = new object[14]{ (object) Shift, (object) Weight, (object) CoilName, (object) ProductionDate, (object) ProductLotName, (object) ProductName, (object) QualityID, (object) GradeName, (object) StoreName, (object) ASize, (object) Barcode, (object) Code, (object) NumOfBars, (object) Length };
        coilsRow.ItemArray = objArray;
        this.Rows.Add((DataRow) coilsRow);
        return coilsRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        dsDeliveryTicket.CoilsDataTable coilsDataTable = (dsDeliveryTicket.CoilsDataTable) base.Clone();
        coilsDataTable.InitVars();
        return (DataTable) coilsDataTable;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new dsDeliveryTicket.CoilsDataTable();
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnShift = this.Columns["Shift"];
        this.columnWeight = this.Columns["Weight"];
        this.columnCoilName = this.Columns["CoilName"];
        this.columnProductionDate = this.Columns["ProductionDate"];
        this.columnProductLotName = this.Columns["ProductLotName"];
        this.columnProductName = this.Columns["ProductName"];
        this.columnQualityID = this.Columns["QualityID"];
        this.columnGradeName = this.Columns["GradeName"];
        this.columnStoreName = this.Columns["StoreName"];
        this.columnASize = this.Columns["ASize"];
        this.columnBarcode = this.Columns["Barcode"];
        this.columnCode = this.Columns["Code"];
        this.columnNumOfBars = this.Columns["NumOfBars"];
        this.columnLength = this.Columns["Length"];
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnShift = new DataColumn("Shift", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnShift);
        this.columnWeight = new DataColumn("Weight", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWeight);
        this.columnCoilName = new DataColumn("CoilName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCoilName);
        this.columnProductionDate = new DataColumn("ProductionDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnProductionDate);
        this.columnProductLotName = new DataColumn("ProductLotName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnProductLotName);
        this.columnProductName = new DataColumn("ProductName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnProductName);
        this.columnQualityID = new DataColumn("QualityID", typeof (byte), (string) null, MappingType.Element);
        this.Columns.Add(this.columnQualityID);
        this.columnGradeName = new DataColumn("GradeName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGradeName);
        this.columnStoreName = new DataColumn("StoreName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStoreName);
        this.columnASize = new DataColumn("ASize", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnASize);
        this.columnBarcode = new DataColumn("Barcode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBarcode);
        this.columnCode = new DataColumn("Code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCode);
        this.columnNumOfBars = new DataColumn("NumOfBars", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnNumOfBars);
        this.columnLength = new DataColumn("Length", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnLength);
        this.columnShift.AllowDBNull = false;
        this.columnShift.MaxLength = 1;
        this.columnWeight.AllowDBNull = false;
        this.columnCoilName.MaxLength = 30;
        this.columnProductionDate.AllowDBNull = false;
        this.columnProductLotName.Caption = "ProductLot";
        this.columnProductLotName.MaxLength = 20;
        this.columnProductName.AllowDBNull = false;
        this.columnProductName.MaxLength = 50;
        this.columnQualityID.AllowDBNull = false;
        this.columnGradeName.AllowDBNull = false;
        this.columnGradeName.MaxLength = 30;
        this.columnStoreName.MaxLength = 50;
        this.columnASize.ReadOnly = true;
        this.columnASize.MaxLength = 87;
        this.columnBarcode.ReadOnly = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public dsDeliveryTicket.CoilsRow NewCoilsRow()
      {
        return (dsDeliveryTicket.CoilsRow) this.NewRow();
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new dsDeliveryTicket.CoilsRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (dsDeliveryTicket.CoilsRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.CoilsRowChanged == null)
          return;
        this.CoilsRowChanged((object) this, new dsDeliveryTicket.CoilsRowChangeEvent((dsDeliveryTicket.CoilsRow) e.Row, e.Action));
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.CoilsRowChanging == null)
          return;
        this.CoilsRowChanging((object) this, new dsDeliveryTicket.CoilsRowChangeEvent((dsDeliveryTicket.CoilsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.CoilsRowDeleted == null)
          return;
        this.CoilsRowDeleted((object) this, new dsDeliveryTicket.CoilsRowChangeEvent((dsDeliveryTicket.CoilsRow) e.Row, e.Action));
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.CoilsRowDeleting == null)
          return;
        this.CoilsRowDeleting((object) this, new dsDeliveryTicket.CoilsRowChangeEvent((dsDeliveryTicket.CoilsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveCoilsRow(dsDeliveryTicket.CoilsRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        dsDeliveryTicket dsDeliveryTicket = new dsDeliveryTicket();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = new Decimal(0);
        xmlSchemaAny1.MaxOccurs = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = new Decimal(1);
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = dsDeliveryTicket.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "CoilsDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = dsDeliveryTicket.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              schema.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class vOrdersDataTable : TypedTableBase<dsDeliveryTicket.vOrdersRow>
    {
      private DataColumn columnOrderID;
      private DataColumn columnOrderDate;
      private DataColumn columnTicketNo;
      private DataColumn columnDONo;
      private DataColumn columnCustomerName;
      private DataColumn columnShipperName;
      private DataColumn columnIDCardNo;
      private DataColumn columnTruckNo;
      private DataColumn columnTareWeight;
      private DataColumn columnGrossWeight;
      private DataColumn columnTonnage;
      private DataColumn columnTimeIn;
      private DataColumn columnTimeOut;
      private DataColumn columnGoodName;
      private DataColumn columnOperatorName;
      private DataColumn columnStoreKeeperName;
      private DataColumn columnSupervisorName;
      private DataColumn columnSaleManagerName;
      private DataColumn columnStoreID;
      private DataColumn columnToStoreID;
      private DataColumn columnComment;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn OrderIDColumn
      {
        get
        {
          return this.columnOrderID;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn OrderDateColumn
      {
        get
        {
          return this.columnOrderDate;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn TicketNoColumn
      {
        get
        {
          return this.columnTicketNo;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn DONoColumn
      {
        get
        {
          return this.columnDONo;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn CustomerNameColumn
      {
        get
        {
          return this.columnCustomerName;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn ShipperNameColumn
      {
        get
        {
          return this.columnShipperName;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn IDCardNoColumn
      {
        get
        {
          return this.columnIDCardNo;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn TruckNoColumn
      {
        get
        {
          return this.columnTruckNo;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn TareWeightColumn
      {
        get
        {
          return this.columnTareWeight;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn GrossWeightColumn
      {
        get
        {
          return this.columnGrossWeight;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn TonnageColumn
      {
        get
        {
          return this.columnTonnage;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn TimeInColumn
      {
        get
        {
          return this.columnTimeIn;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn TimeOutColumn
      {
        get
        {
          return this.columnTimeOut;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn GoodNameColumn
      {
        get
        {
          return this.columnGoodName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn OperatorNameColumn
      {
        get
        {
          return this.columnOperatorName;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn StoreKeeperNameColumn
      {
        get
        {
          return this.columnStoreKeeperName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SupervisorNameColumn
      {
        get
        {
          return this.columnSupervisorName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SaleManagerNameColumn
      {
        get
        {
          return this.columnSaleManagerName;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn StoreIDColumn
      {
        get
        {
          return this.columnStoreID;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataColumn ToStoreIDColumn
      {
        get
        {
          return this.columnToStoreID;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn CommentColumn
      {
        get
        {
          return this.columnComment;
        }
      }

      [DebuggerNonUserCode]
      [Browsable(false)]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public dsDeliveryTicket.vOrdersRow this[int index]
      {
        get
        {
          return (dsDeliveryTicket.vOrdersRow) this.Rows[index];
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event dsDeliveryTicket.vOrdersRowChangeEventHandler vOrdersRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event dsDeliveryTicket.vOrdersRowChangeEventHandler vOrdersRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event dsDeliveryTicket.vOrdersRowChangeEventHandler vOrdersRowDeleting;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event dsDeliveryTicket.vOrdersRowChangeEventHandler vOrdersRowDeleted;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public vOrdersDataTable()
      {
        this.TableName = "vOrders";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal vOrdersDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected vOrdersDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddvOrdersRow(dsDeliveryTicket.vOrdersRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public dsDeliveryTicket.vOrdersRow AddvOrdersRow(DateTime OrderDate, string TicketNo, string DONo, string CustomerName, string ShipperName, string IDCardNo, string TruckNo, int TareWeight, int GrossWeight, int Tonnage, DateTime TimeIn, DateTime TimeOut, string GoodName, string OperatorName, string StoreKeeperName, string SupervisorName, string SaleManagerName, ushort StoreID, string ToStoreID, string Comment)
      {
        dsDeliveryTicket.vOrdersRow vOrdersRow = (dsDeliveryTicket.vOrdersRow) this.NewRow();
        object[] objArray = new object[21]{ null, (object) OrderDate, (object) TicketNo, (object) DONo, (object) CustomerName, (object) ShipperName, (object) IDCardNo, (object) TruckNo, (object) TareWeight, (object) GrossWeight, (object) Tonnage, (object) TimeIn, (object) TimeOut, (object) GoodName, (object) OperatorName, (object) StoreKeeperName, (object) SupervisorName, (object) SaleManagerName, (object) StoreID, (object) ToStoreID, (object) Comment };
        vOrdersRow.ItemArray = objArray;
        this.Rows.Add((DataRow) vOrdersRow);
        return vOrdersRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public dsDeliveryTicket.vOrdersRow FindByOrderID(int OrderID)
      {
        return (dsDeliveryTicket.vOrdersRow) this.Rows.Find(new object[1]{ (object) OrderID });
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        dsDeliveryTicket.vOrdersDataTable vOrdersDataTable = (dsDeliveryTicket.vOrdersDataTable) base.Clone();
        vOrdersDataTable.InitVars();
        return (DataTable) vOrdersDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new dsDeliveryTicket.vOrdersDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnOrderID = this.Columns["OrderID"];
        this.columnOrderDate = this.Columns["OrderDate"];
        this.columnTicketNo = this.Columns["TicketNo"];
        this.columnDONo = this.Columns["DONo"];
        this.columnCustomerName = this.Columns["CustomerName"];
        this.columnShipperName = this.Columns["ShipperName"];
        this.columnIDCardNo = this.Columns["IDCardNo"];
        this.columnTruckNo = this.Columns["TruckNo"];
        this.columnTareWeight = this.Columns["TareWeight"];
        this.columnGrossWeight = this.Columns["GrossWeight"];
        this.columnTonnage = this.Columns["Tonnage"];
        this.columnTimeIn = this.Columns["TimeIn"];
        this.columnTimeOut = this.Columns["TimeOut"];
        this.columnGoodName = this.Columns["GoodName"];
        this.columnOperatorName = this.Columns["OperatorName"];
        this.columnStoreKeeperName = this.Columns["StoreKeeperName"];
        this.columnSupervisorName = this.Columns["SupervisorName"];
        this.columnSaleManagerName = this.Columns["SaleManagerName"];
        this.columnStoreID = this.Columns["StoreID"];
        this.columnToStoreID = this.Columns["ToStoreID"];
        this.columnComment = this.Columns["Comment"];
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnOrderID = new DataColumn("OrderID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOrderID);
        this.columnOrderDate = new DataColumn("OrderDate", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOrderDate);
        this.columnTicketNo = new DataColumn("TicketNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTicketNo);
        this.columnDONo = new DataColumn("DONo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDONo);
        this.columnCustomerName = new DataColumn("CustomerName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCustomerName);
        this.columnShipperName = new DataColumn("ShipperName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnShipperName);
        this.columnIDCardNo = new DataColumn("IDCardNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnIDCardNo);
        this.columnTruckNo = new DataColumn("TruckNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTruckNo);
        this.columnTareWeight = new DataColumn("TareWeight", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTareWeight);
        this.columnGrossWeight = new DataColumn("GrossWeight", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGrossWeight);
        this.columnTonnage = new DataColumn("Tonnage", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTonnage);
        this.columnTimeIn = new DataColumn("TimeIn", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTimeIn);
        this.columnTimeOut = new DataColumn("TimeOut", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTimeOut);
        this.columnGoodName = new DataColumn("GoodName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnGoodName);
        this.columnOperatorName = new DataColumn("OperatorName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnOperatorName);
        this.columnStoreKeeperName = new DataColumn("StoreKeeperName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStoreKeeperName);
        this.columnSupervisorName = new DataColumn("SupervisorName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSupervisorName);
        this.columnSaleManagerName = new DataColumn("SaleManagerName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSaleManagerName);
        this.columnStoreID = new DataColumn("StoreID", typeof (ushort), (string) null, MappingType.Element);
        this.Columns.Add(this.columnStoreID);
        this.columnToStoreID = new DataColumn("ToStoreID", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnToStoreID);
        this.columnComment = new DataColumn("Comment", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnComment);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnOrderID
        }, 1 != 0));
        this.columnOrderID.AutoIncrement = true;
        this.columnOrderID.AutoIncrementSeed = -1L;
        this.columnOrderID.AutoIncrementStep = -1L;
        this.columnOrderID.AllowDBNull = false;
        this.columnOrderID.Unique = true;
        this.columnOrderDate.AllowDBNull = false;
        this.columnDONo.MaxLength = 20;
        this.columnCustomerName.MaxLength = 70;
        this.columnShipperName.MaxLength = 50;
        this.columnIDCardNo.MaxLength = 50;
        this.columnTruckNo.MaxLength = 10;
        this.columnGoodName.MaxLength = 50;
        this.columnOperatorName.AllowDBNull = false;
        this.columnOperatorName.MaxLength = 30;
        this.columnStoreKeeperName.AllowDBNull = false;
        this.columnStoreKeeperName.MaxLength = 30;
        this.columnSupervisorName.MaxLength = 30;
        this.columnSaleManagerName.AllowDBNull = false;
        this.columnSaleManagerName.MaxLength = 30;
        this.columnToStoreID.MaxLength = 3;
        this.columnComment.MaxLength = 250;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public dsDeliveryTicket.vOrdersRow NewvOrdersRow()
      {
        return (dsDeliveryTicket.vOrdersRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new dsDeliveryTicket.vOrdersRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (dsDeliveryTicket.vOrdersRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.vOrdersRowChanged == null)
          return;
        this.vOrdersRowChanged((object) this, new dsDeliveryTicket.vOrdersRowChangeEvent((dsDeliveryTicket.vOrdersRow) e.Row, e.Action));
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.vOrdersRowChanging == null)
          return;
        this.vOrdersRowChanging((object) this, new dsDeliveryTicket.vOrdersRowChangeEvent((dsDeliveryTicket.vOrdersRow) e.Row, e.Action));
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.vOrdersRowDeleted == null)
          return;
        this.vOrdersRowDeleted((object) this, new dsDeliveryTicket.vOrdersRowChangeEvent((dsDeliveryTicket.vOrdersRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.vOrdersRowDeleting == null)
          return;
        this.vOrdersRowDeleting((object) this, new dsDeliveryTicket.vOrdersRowChangeEvent((dsDeliveryTicket.vOrdersRow) e.Row, e.Action));
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void RemovevOrdersRow(dsDeliveryTicket.vOrdersRow row)
      {
        this.Rows.Remove((DataRow) row);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        dsDeliveryTicket dsDeliveryTicket = new dsDeliveryTicket();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = new Decimal(0);
        xmlSchemaAny1.MaxOccurs = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = new Decimal(1);
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = dsDeliveryTicket.Namespace
        });
        schemaComplexType.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "vOrdersDataTable"
        });
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = dsDeliveryTicket.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              schema.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    public class CoilsRow : DataRow
    {
      private dsDeliveryTicket.CoilsDataTable tableCoils;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string Shift
      {
        get
        {
          return (string) this[this.tableCoils.ShiftColumn];
        }
        set
        {
          this[this.tableCoils.ShiftColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public short Weight
      {
        get
        {
          return (short) this[this.tableCoils.WeightColumn];
        }
        set
        {
          this[this.tableCoils.WeightColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string CoilName
      {
        get
        {
          try
          {
            return (string) this[this.tableCoils.CoilNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CoilName' in table 'Coils' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCoils.CoilNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DateTime ProductionDate
      {
        get
        {
          return (DateTime) this[this.tableCoils.ProductionDateColumn];
        }
        set
        {
          this[this.tableCoils.ProductionDateColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string ProductLotName
      {
        get
        {
          try
          {
            return (string) this[this.tableCoils.ProductLotNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ProductLotName' in table 'Coils' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCoils.ProductLotNameColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string ProductName
      {
        get
        {
          return (string) this[this.tableCoils.ProductNameColumn];
        }
        set
        {
          this[this.tableCoils.ProductNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public byte QualityID
      {
        get
        {
          return (byte) this[this.tableCoils.QualityIDColumn];
        }
        set
        {
          this[this.tableCoils.QualityIDColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string GradeName
      {
        get
        {
          return (string) this[this.tableCoils.GradeNameColumn];
        }
        set
        {
          this[this.tableCoils.GradeNameColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string StoreName
      {
        get
        {
          try
          {
            return (string) this[this.tableCoils.StoreNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StoreName' in table 'Coils' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCoils.StoreNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ASize
      {
        get
        {
          try
          {
            return (string) this[this.tableCoils.ASizeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ASize' in table 'Coils' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCoils.ASizeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Barcode
      {
        get
        {
          try
          {
            return (string) this[this.tableCoils.BarcodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Barcode' in table 'Coils' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCoils.BarcodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Code
      {
        get
        {
          try
          {
            return (string) this[this.tableCoils.CodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Code' in table 'Coils' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCoils.CodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int NumOfBars
      {
        get
        {
          try
          {
            return (int) this[this.tableCoils.NumOfBarsColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'NumOfBars' in table 'Coils' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCoils.NumOfBarsColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string Length
      {
        get
        {
          try
          {
            return (string) this[this.tableCoils.LengthColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Length' in table 'Coils' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableCoils.LengthColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      internal CoilsRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableCoils = (dsDeliveryTicket.CoilsDataTable) this.Table;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsCoilNameNull()
      {
        return this.IsNull(this.tableCoils.CoilNameColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetCoilNameNull()
      {
        this[this.tableCoils.CoilNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsProductLotNameNull()
      {
        return this.IsNull(this.tableCoils.ProductLotNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetProductLotNameNull()
      {
        this[this.tableCoils.ProductLotNameColumn] = Convert.DBNull;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsStoreNameNull()
      {
        return this.IsNull(this.tableCoils.StoreNameColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetStoreNameNull()
      {
        this[this.tableCoils.StoreNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsASizeNull()
      {
        return this.IsNull(this.tableCoils.ASizeColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetASizeNull()
      {
        this[this.tableCoils.ASizeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsBarcodeNull()
      {
        return this.IsNull(this.tableCoils.BarcodeColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetBarcodeNull()
      {
        this[this.tableCoils.BarcodeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsCodeNull()
      {
        return this.IsNull(this.tableCoils.CodeColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetCodeNull()
      {
        this[this.tableCoils.CodeColumn] = Convert.DBNull;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsNumOfBarsNull()
      {
        return this.IsNull(this.tableCoils.NumOfBarsColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetNumOfBarsNull()
      {
        this[this.tableCoils.NumOfBarsColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsLengthNull()
      {
        return this.IsNull(this.tableCoils.LengthColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetLengthNull()
      {
        this[this.tableCoils.LengthColumn] = Convert.DBNull;
      }
    }

    public class vOrdersRow : DataRow
    {
      private dsDeliveryTicket.vOrdersDataTable tablevOrders;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int OrderID
      {
        get
        {
          return (int) this[this.tablevOrders.OrderIDColumn];
        }
        set
        {
          this[this.tablevOrders.OrderIDColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DateTime OrderDate
      {
        get
        {
          return (DateTime) this[this.tablevOrders.OrderDateColumn];
        }
        set
        {
          this[this.tablevOrders.OrderDateColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string TicketNo
      {
        get
        {
          try
          {
            return (string) this[this.tablevOrders.TicketNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TicketNo' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.TicketNoColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string DONo
      {
        get
        {
          try
          {
            return (string) this[this.tablevOrders.DONoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DONo' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.DONoColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string CustomerName
      {
        get
        {
          try
          {
            return (string) this[this.tablevOrders.CustomerNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CustomerName' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.CustomerNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ShipperName
      {
        get
        {
          try
          {
            return (string) this[this.tablevOrders.ShipperNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ShipperName' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.ShipperNameColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string IDCardNo
      {
        get
        {
          try
          {
            return (string) this[this.tablevOrders.IDCardNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'IDCardNo' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.IDCardNoColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string TruckNo
      {
        get
        {
          try
          {
            return (string) this[this.tablevOrders.TruckNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TruckNo' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.TruckNoColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public int TareWeight
      {
        get
        {
          try
          {
            return (int) this[this.tablevOrders.TareWeightColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TareWeight' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.TareWeightColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int GrossWeight
      {
        get
        {
          try
          {
            return (int) this[this.tablevOrders.GrossWeightColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GrossWeight' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.GrossWeightColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public int Tonnage
      {
        get
        {
          try
          {
            return (int) this[this.tablevOrders.TonnageColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Tonnage' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.TonnageColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DateTime TimeIn
      {
        get
        {
          try
          {
            return (DateTime) this[this.tablevOrders.TimeInColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TimeIn' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.TimeInColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DateTime TimeOut
      {
        get
        {
          try
          {
            return (DateTime) this[this.tablevOrders.TimeOutColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'TimeOut' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.TimeOutColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string GoodName
      {
        get
        {
          try
          {
            return (string) this[this.tablevOrders.GoodNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'GoodName' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.GoodNameColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string OperatorName
      {
        get
        {
          return (string) this[this.tablevOrders.OperatorNameColumn];
        }
        set
        {
          this[this.tablevOrders.OperatorNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string StoreKeeperName
      {
        get
        {
          return (string) this[this.tablevOrders.StoreKeeperNameColumn];
        }
        set
        {
          this[this.tablevOrders.StoreKeeperNameColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string SupervisorName
      {
        get
        {
          try
          {
            return (string) this[this.tablevOrders.SupervisorNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SupervisorName' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.SupervisorNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SaleManagerName
      {
        get
        {
          return (string) this[this.tablevOrders.SaleManagerNameColumn];
        }
        set
        {
          this[this.tablevOrders.SaleManagerNameColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public ushort StoreID
      {
        get
        {
          try
          {
            return (ushort) this[this.tablevOrders.StoreIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'StoreID' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.StoreIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ToStoreID
      {
        get
        {
          try
          {
            return (string) this[this.tablevOrders.ToStoreIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ToStoreID' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.ToStoreIDColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public string Comment
      {
        get
        {
          try
          {
            return (string) this[this.tablevOrders.CommentColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Comment' in table 'vOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tablevOrders.CommentColumn] = (object) value;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      internal vOrdersRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tablevOrders = (dsDeliveryTicket.vOrdersDataTable) this.Table;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsTicketNoNull()
      {
        return this.IsNull(this.tablevOrders.TicketNoColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetTicketNoNull()
      {
        this[this.tablevOrders.TicketNoColumn] = Convert.DBNull;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsDONoNull()
      {
        return this.IsNull(this.tablevOrders.DONoColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetDONoNull()
      {
        this[this.tablevOrders.DONoColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsCustomerNameNull()
      {
        return this.IsNull(this.tablevOrders.CustomerNameColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetCustomerNameNull()
      {
        this[this.tablevOrders.CustomerNameColumn] = Convert.DBNull;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsShipperNameNull()
      {
        return this.IsNull(this.tablevOrders.ShipperNameColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetShipperNameNull()
      {
        this[this.tablevOrders.ShipperNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsIDCardNoNull()
      {
        return this.IsNull(this.tablevOrders.IDCardNoColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetIDCardNoNull()
      {
        this[this.tablevOrders.IDCardNoColumn] = Convert.DBNull;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsTruckNoNull()
      {
        return this.IsNull(this.tablevOrders.TruckNoColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetTruckNoNull()
      {
        this[this.tablevOrders.TruckNoColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsTareWeightNull()
      {
        return this.IsNull(this.tablevOrders.TareWeightColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetTareWeightNull()
      {
        this[this.tablevOrders.TareWeightColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsGrossWeightNull()
      {
        return this.IsNull(this.tablevOrders.GrossWeightColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetGrossWeightNull()
      {
        this[this.tablevOrders.GrossWeightColumn] = Convert.DBNull;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsTonnageNull()
      {
        return this.IsNull(this.tablevOrders.TonnageColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetTonnageNull()
      {
        this[this.tablevOrders.TonnageColumn] = Convert.DBNull;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsTimeInNull()
      {
        return this.IsNull(this.tablevOrders.TimeInColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetTimeInNull()
      {
        this[this.tablevOrders.TimeInColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsTimeOutNull()
      {
        return this.IsNull(this.tablevOrders.TimeOutColumn);
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public void SetTimeOutNull()
      {
        this[this.tablevOrders.TimeOutColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsGoodNameNull()
      {
        return this.IsNull(this.tablevOrders.GoodNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetGoodNameNull()
      {
        this[this.tablevOrders.GoodNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSupervisorNameNull()
      {
        return this.IsNull(this.tablevOrders.SupervisorNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetSupervisorNameNull()
      {
        this[this.tablevOrders.SupervisorNameColumn] = Convert.DBNull;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsStoreIDNull()
      {
        return this.IsNull(this.tablevOrders.StoreIDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetStoreIDNull()
      {
        this[this.tablevOrders.StoreIDColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsToStoreIDNull()
      {
        return this.IsNull(this.tablevOrders.ToStoreIDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetToStoreIDNull()
      {
        this[this.tablevOrders.ToStoreIDColumn] = Convert.DBNull;
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public bool IsCommentNull()
      {
        return this.IsNull(this.tablevOrders.CommentColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetCommentNull()
      {
        this[this.tablevOrders.CommentColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class CoilsRowChangeEvent : EventArgs
    {
      private dsDeliveryTicket.CoilsRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public dsDeliveryTicket.CoilsRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public CoilsRowChangeEvent(dsDeliveryTicket.CoilsRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class vOrdersRowChangeEvent : EventArgs
    {
      private dsDeliveryTicket.vOrdersRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public dsDeliveryTicket.vOrdersRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      [DebuggerNonUserCode]
      public vOrdersRowChangeEvent(dsDeliveryTicket.vOrdersRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }
  }
}
