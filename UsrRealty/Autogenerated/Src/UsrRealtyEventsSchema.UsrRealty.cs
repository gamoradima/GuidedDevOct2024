namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38ffb239-949a-42a7-9de8-5f35dca58def");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0956db6b-bd61-4343-a523-8dbeba1628e7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,107,219,64,16,189,11,250,31,6,157,36,48,75,114,173,219,64,109,148,18,8,109,177,229,94,66,15,235,213,88,217,178,31,98,103,229,212,45,254,239,221,213,218,137,101,167,52,115,146,102,222,190,121,111,120,134,107,164,142,11,132,26,157,227,100,55,158,205,173,217,200,182,119,220,75,107,178,63,25,132,234,73,154,22,150,59,242,168,167,39,157,211,87,90,91,243,175,153,67,86,25,47,189,68,122,3,132,85,91,52,254,128,124,24,186,187,161,117,47,131,0,131,174,88,138,71,212,252,75,80,15,31,33,95,145,91,32,87,126,151,151,63,134,55,93,191,86,82,128,80,156,8,210,232,21,22,120,15,51,78,248,202,100,32,73,206,79,232,236,54,200,149,13,194,214,202,6,190,154,37,223,6,19,133,93,255,68,225,129,208,52,232,38,144,232,102,184,9,142,6,210,79,174,37,192,242,153,237,133,55,214,58,40,96,207,92,71,18,44,167,35,84,34,5,55,88,9,150,139,212,40,19,126,140,109,80,72,205,21,116,78,138,120,158,244,136,125,70,95,239,58,108,230,86,245,218,124,231,170,199,15,7,232,77,17,79,248,45,226,171,213,34,63,219,45,55,80,36,174,27,184,190,58,86,57,194,140,61,197,66,118,71,115,110,4,42,108,130,8,239,122,156,102,23,40,242,46,230,32,132,144,120,139,53,234,78,113,31,69,27,124,130,123,43,184,146,191,249,90,225,114,192,21,7,43,43,66,23,82,106,194,217,67,68,217,2,201,246,78,4,144,117,129,101,242,238,98,77,172,151,148,164,116,229,19,200,47,54,16,27,14,115,71,181,181,51,217,166,191,188,100,181,61,40,40,255,107,34,136,79,13,118,107,157,230,190,56,51,23,214,94,179,171,25,84,189,179,231,167,142,229,31,157,125,26,252,87,191,4,118,209,225,145,226,12,189,207,198,95,251,108,159,253,5,123,14,228,240,209,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aea73546-d6aa-4a50-2d20-5d7481ff3448"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("0956db6b-bd61-4343-a523-8dbeba1628e7"),
				CreatedInSchemaUId = new Guid("38ffb239-949a-42a7-9de8-5f35dca58def"),
				ModifiedInSchemaUId = new Guid("38ffb239-949a-42a7-9de8-5f35dca58def")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38ffb239-949a-42a7-9de8-5f35dca58def"));
		}

		#endregion

	}

	#endregion

}

