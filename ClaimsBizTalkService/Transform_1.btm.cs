namespace ClaimsBizTalkService {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ClaimsBizTalkService.claimsRequest", typeof(global::ClaimsBizTalkService.claimsRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ClaimsBizTalkService.claimsResponse", typeof(global::ClaimsBizTalkService.claimsResponse))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://ClaimsBizTalkService.claimsResponse"" xmlns:s0=""http://ClaimsBizTalkService.claimsRequest"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ClaimsRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:ClaimsRequest"">
    <ns0:ClaimsResponse>
      <input>
        <xsl:value-of select=""output/text()"" />
      </input>
    </ns0:ClaimsResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ClaimsBizTalkService.claimsRequest";
        
        private const global::ClaimsBizTalkService.claimsRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"ClaimsBizTalkService.claimsResponse";
        
        private const global::ClaimsBizTalkService.claimsResponse _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"ClaimsBizTalkService.claimsRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ClaimsBizTalkService.claimsResponse";
                return _TrgSchemas;
            }
        }
    }
}
