

using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using STEP;
	
namespace IFC
{
	/// <summary>
	/// <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconstructionequipmentresource.htm"/>
	/// </summary>
	public  partial class IfcConstructionEquipmentResource : IfcConstructionResource
	{
		public IfcConstructionEquipmentResourceTypeEnum PredefinedType{get;set;} // optional


		/// <summary>
		/// Construct a IfcConstructionEquipmentResource with all required attributes.
		/// </summary>
		public IfcConstructionEquipmentResource(IfcGloballyUniqueId globalId):base(globalId)
		{


		}
		/// <summary>
		/// Construct a IfcConstructionEquipmentResource with required and optional attributes.
		/// </summary>
		[JsonConstructor]
		public IfcConstructionEquipmentResource(IfcGloballyUniqueId globalId,IfcOwnerHistory ownerHistory,IfcLabel name,IfcText description,IfcLabel objectType,IfcIdentifier identification,IfcText longDescription,IfcResourceTime usage,List<IfcAppliedValue> baseCosts,IfcPhysicalQuantity baseQuantity,IfcConstructionEquipmentResourceTypeEnum predefinedType):base(globalId,ownerHistory,name,description,objectType,identification,longDescription,usage,baseCosts,baseQuantity)
		{

			PredefinedType = predefinedType;

		}
		public static new IfcConstructionEquipmentResource FromJSON(string json){ return JsonConvert.DeserializeObject<IfcConstructionEquipmentResource>(json); }

        public override string GetStepParameters()
        {
            var parameters = new List<string>();
			parameters.Add(GlobalId != null ? GlobalId.ToStepValue() : "$");
			parameters.Add(OwnerHistory != null ? OwnerHistory.ToStepValue() : "$");
			parameters.Add(Name != null ? Name.ToStepValue() : "$");
			parameters.Add(Description != null ? Description.ToStepValue() : "$");
			parameters.Add(ObjectType != null ? ObjectType.ToStepValue() : "$");
			parameters.Add(Identification != null ? Identification.ToStepValue() : "$");
			parameters.Add(LongDescription != null ? LongDescription.ToStepValue() : "$");
			parameters.Add(Usage != null ? Usage.ToStepValue() : "$");
			parameters.Add(BaseCosts != null ? BaseCosts.ToStepValue() : "$");
			parameters.Add(BaseQuantity != null ? BaseQuantity.ToStepValue() : "$");
			parameters.Add(PredefinedType.ToStepValue());

            return string.Join(", ", parameters.ToArray());
        }
	}
}
