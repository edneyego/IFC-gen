/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfillareastylehatching.htm
	/// </summary>
	internal  partial class FillAreaStyleHatching : GeometricRepresentationItem 
	{
		public CurveStyle HatchLineAppearance {get;set;}

		public FillAreaStyleHatchingStartOfNextHatchLine StartOfNextHatchLine {get;set;}

		public CartesianPoint PointOfReferenceHatchLine {get;set;}

		public CartesianPoint PatternStart {get;set;}

		public Double HatchLineAngle {get;set;}

		public FillAreaStyleHatching(CurveStyle hatchLineAppearance,
				FillAreaStyleHatchingStartOfNextHatchLine startOfNextHatchLine,
				CartesianPoint pointOfReferenceHatchLine,
				CartesianPoint patternStart,
				Double hatchLineAngle,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.HatchLineAppearance = hatchLineAppearance;
			this.StartOfNextHatchLine = startOfNextHatchLine;
			this.PointOfReferenceHatchLine = pointOfReferenceHatchLine;
			this.PatternStart = patternStart;
			this.HatchLineAngle = hatchLineAngle;
		}
	}
}