namespace NxBRE.FlowEngine.IO {
	using System.Xml;
	using System.Xml.Xsl;

	using net.ideaity.util.events;
	
	using NxBRE.Util;
	
	/// <summary>
	/// Driver for loading rules files valid against xBusinessRules.xsd (simplified NxBRE grammar).
	/// The native NxBRE rules file will be generated by XSLT.
	/// </summary>
	/// <author>David Dossot</author>
	/// <remarks>
	///  xBusinessRules.xsd, transformXRules.xsl and businessRules.xsd must be included in the assembly.
	/// </remarks>
	public class XBusinessRulesFileDriver:XSLTRulesFileDriver {
		
		public XBusinessRulesFileDriver(string xmlFileURI):base(xmlFileURI) {
			inputXMLSchema = "xBusinessRules.xsd";
			xslt = Xml.GetCachedCompiledTransform("transformXRules.xsl");
		}
	}
}
