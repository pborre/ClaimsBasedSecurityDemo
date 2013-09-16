
#pragma warning disable 162

namespace ClaimsBizTalkService
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "CaimsOrchestration",
        new System.Type[]{
            typeof(ClaimsBizTalkService.__messagetype_ClaimsBizTalkService_claimsRequest), 
            typeof(ClaimsBizTalkService.__messagetype_ClaimsBizTalkService_claimsResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class ClaimsBizTalkServicePortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ClaimsBizTalkServicePortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ClaimsBizTalkServicePortType(ClaimsBizTalkServicePortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ClaimsBizTalkServicePortType p = new ClaimsBizTalkServicePortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo CaimsOrchestration = new Microsoft.XLANGs.Core.OperationInfo
        (
            "CaimsOrchestration",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(ClaimsBizTalkServicePortType),
            typeof(__messagetype_ClaimsBizTalkService_claimsRequest),
            typeof(__messagetype_ClaimsBizTalkService_claimsResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "CaimsOrchestration" ] = CaimsOrchestration;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 144 "C:\Projects\Research\ADFSWIF\ClaimsBizTalkService\ClaimEnumerator.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ClaimsBizTalkServicePort", "CaimsOrchestration", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(ClaimsBizTalkService.ClaimsBizTalkServicePortType)
        },
        new System.String[] {
            "ClaimsBizTalkServicePort"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ClaimEnumerator : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ClaimEnumerator));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static ClaimEnumerator()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __ClaimEnumerator_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ClaimEnumerator(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ClaimEnumerator", tracker)
        {
            ConstructorHelper();
        }

        public ClaimEnumerator(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ClaimEnumerator")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>0df86b36-96d3-47e6-970b-f9b50feb2073</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>db205104-865f-4cc7-936a-93f7917eba4b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Resonse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>319a820b-4016-427a-89fa-fe3f86fc8bb8</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>0016fbc5-e184-40c2-ae24-515d24357f7a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5ab27291-f0d6-4226-916d-bfc60815c32f</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1af8bad4-6a94-4853-93b4-d2fe95634869</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>550228d4-089d-4fba-8c79-fc5472098dcb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>065f27bc-be15-43bb-a3e2-70175a5cc006</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ClaimEnumerator'</ActionName><IsAtomic>0</IsAtomic><Line>144</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>154</Line><Position>22</Position><ShapeID>'db205104-865f-4cc7-936a-93f7917eba4b'</ShapeID>
<Messages>
	<MsgInfo><name>msg_claimsRequest</name><part>part</part><schema>ClaimsBizTalkService.claimsRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>157</Line><Position>13</Position><ShapeID>'319a820b-4016-427a-89fa-fe3f86fc8bb8'</ShapeID>
<Messages>
	<MsgInfo><name>msg_claimsResponse</name><part>part</part><schema>ClaimsBizTalkService.claimsResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msg_claimsRequest</name><part>part</part><schema>ClaimsBizTalkService.claimsRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>163</Line><Position>13</Position><ShapeID>'065f27bc-be15-43bb-a3e2-70175a5cc006'</ShapeID>
<Messages>
	<MsgInfo><name>msg_claimsResponse</name><part>part</part><schema>ClaimsBizTalkService.claimsResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='d473ad6a-0cd8-4832-afc0-ac783ca1813a' LowerBound='1.1' HigherBound='35.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='ClaimsBizTalkService' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='2f78a733-ae7d-4029-8302-cba500c416fb' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ClaimsBizTalkServicePortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='55efe867-27e9-4439-a17c-35626312ce47' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CaimsOrchestration' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='a16ef594-ec1e-4d1f-9799-efd9d8557ce5' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.26'>
                    <om:Property Name='Ref' Value='ClaimsBizTalkService.claimsRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='e47d142f-7a75-47f2-9b7c-02ffd495e3b5' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.28' HigherBound='8.42'>
                    <om:Property Name='Ref' Value='ClaimsBizTalkService.claimsResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='5d74e136-3f1b-409a-8fb1-c422c1adf2ae' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='34.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ClaimEnumerator' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='b5ea0b07-68c8-452f-976e-7997ecda2c8a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='responseXml' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8439fa44-3ee1-4454-b007-148860bd68ae' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='ClaimsBizTalkService.claimsRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msg_claimsRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='78b9c474-e6c6-4812-abd1-13c9fb75aa3f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='Type' Value='ClaimsBizTalkService.claimsResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msg_claimsResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='0df86b36-96d3-47e6-970b-f9b50feb2073' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='db205104-865f-4cc7-936a-93f7917eba4b' ParentLink='ServiceBody_Statement' LowerBound='21.1' HigherBound='24.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ClaimsBizTalkServicePort' />
                    <om:Property Name='MessageName' Value='msg_claimsRequest' />
                    <om:Property Name='OperationName' Value='CaimsOrchestration' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Resonse' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='319a820b-4016-427a-89fa-fe3f86fc8bb8' ParentLink='ServiceBody_Statement' LowerBound='24.1' HigherBound='30.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct response' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='0016fbc5-e184-40c2-ae24-515d24357f7a' ParentLink='ComplexStatement_Statement' LowerBound='27.1' HigherBound='29.1'>
                        <om:Property Name='ClassName' Value='ClaimsBizTalkService.Transform_1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='5ab27291-f0d6-4226-916d-bfc60815c32f' ParentLink='Transform_InputMessagePartRef' LowerBound='28.84' HigherBound='28.101'>
                            <om:Property Name='MessageRef' Value='msg_claimsRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='1af8bad4-6a94-4853-93b4-d2fe95634869' ParentLink='Transform_OutputMessagePartRef' LowerBound='28.28' HigherBound='28.46'>
                            <om:Property Name='MessageRef' Value='msg_claimsResponse' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='550228d4-089d-4fba-8c79-fc5472098dcb' ParentLink='Construct_MessageRef' LowerBound='25.23' HigherBound='25.41'>
                        <om:Property Name='Ref' Value='msg_claimsResponse' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='065f27bc-be15-43bb-a3e2-70175a5cc006' ParentLink='ServiceBody_Statement' LowerBound='30.1' HigherBound='32.1'>
                    <om:Property Name='PortName' Value='ClaimsBizTalkServicePort' />
                    <om:Property Name='MessageName' Value='msg_claimsResponse' />
                    <om:Property Name='OperationName' Value='CaimsOrchestration' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='39420458-66b2-409d-9f88-33dc6693e1cb' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='ClaimsBizTalkService.ClaimsBizTalkServicePortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ClaimsBizTalkServicePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7339253b-1cc7-4cde-8d62-86bda20bd0f0' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ClaimEnumerator_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ClaimEnumerator_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ClaimEnumerator")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ClaimEnumerator __svc__ = (ClaimEnumerator)_service;
                __ClaimEnumerator_root_0 __ctx0__ = (__ClaimEnumerator_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ClaimsBizTalkServicePort != null)
                {
                    __svc__.ClaimsBizTalkServicePort.Close(this, null);
                    __svc__.ClaimsBizTalkServicePort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ClaimEnumerator_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ClaimEnumerator_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ClaimEnumerator")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ClaimEnumerator __svc__ = (ClaimEnumerator)_service;
                __ClaimEnumerator_1 __ctx1__ = (__ClaimEnumerator_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msg_claimsRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_claimsRequest);
                    __ctx1__.__msg_claimsRequest = null;
                }
                if (__ctx1__ != null && __ctx1__.__msg_claimsResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_claimsResponse);
                    __ctx1__.__msg_claimsResponse = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__responseXml = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msg_claimsRequest")]
            public __messagetype_ClaimsBizTalkService_claimsRequest __msg_claimsRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msg_claimsResponse")]
            public __messagetype_ClaimsBizTalkService_claimsResponse __msg_claimsResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("responseXml")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __responseXml;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ClaimsBizTalkServicePort")]
        internal ClaimsBizTalkServicePortType ClaimsBizTalkServicePort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ClaimsBizTalkServicePortType.CaimsOrchestration},
                                               typeof(ClaimEnumerator).GetField("ClaimsBizTalkServicePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ClaimEnumerator), "ClaimsBizTalkServicePort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "db205104-865f-4cc7-936a-93f7917eba4b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "db205104-865f-4cc7-936a-93f7917eba4b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "319a820b-4016-427a-89fa-fe3f86fc8bb8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "319a820b-4016-427a-89fa-fe3f86fc8bb8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "065f27bc-be15-43bb-a3e2-70175a5cc006", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "065f27bc-be15-43bb-a3e2-70175a5cc006", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,6,6,6,7,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ClaimEnumerator_root_0 __ctx0__ = (__ClaimEnumerator_root_0)_stateMgrs[0];
            __ClaimEnumerator_1 __ctx1__ = (__ClaimEnumerator_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ClaimsBizTalkServicePort = new ClaimsBizTalkServicePortType(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ClaimsBizTalkServicePort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ClaimEnumerator_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ClaimEnumerator_root_0 __ctx0__ = (__ClaimEnumerator_root_0)_stateMgrs[0];
            __ClaimEnumerator_1 __ctx1__ = (__ClaimEnumerator_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__responseXml = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!ClaimsBizTalkServicePort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msg_claimsRequest != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msg_claimsRequest);
                __ctx1__.__msg_claimsRequest = new __messagetype_ClaimsBizTalkService_claimsRequest("msg_claimsRequest", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msg_claimsRequest);
                ClaimsBizTalkServicePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msg_claimsRequest, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msg_claimsRequest);
                    __edata.PortName = @"ClaimsBizTalkServicePort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__responseXml.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if (__ctx1__ != null)
                    __ctx1__.__responseXml = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    __messagetype_ClaimsBizTalkService_claimsResponse __msg_claimsResponse = new __messagetype_ClaimsBizTalkService_claimsResponse("msg_claimsResponse", __ctx1__);

                    ApplyTransform(typeof(ClaimsBizTalkService.Transform_1), new object[] {__msg_claimsResponse.part}, new object[] {__ctx1__.__msg_claimsRequest.part});

                    if (__ctx1__.__msg_claimsResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msg_claimsResponse);
                    __ctx1__.__msg_claimsResponse = __msg_claimsResponse;
                    __ctx1__.RefMessage(__ctx1__.__msg_claimsResponse);
                }
                __ctx1__.__msg_claimsResponse.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msg_claimsResponse);
                    __edata.Messages.Add(__ctx1__.__msg_claimsRequest);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msg_claimsRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_claimsRequest);
                    __ctx1__.__msg_claimsRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                ClaimsBizTalkServicePort.SendMessage(0, __ctx1__.__msg_claimsResponse, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (ClaimsBizTalkServicePort != null)
                {
                    ClaimsBizTalkServicePort.Close(__ctx1__, __seg__);
                    ClaimsBizTalkServicePort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msg_claimsResponse);
                    __edata.PortName = @"ClaimsBizTalkServicePort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msg_claimsResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_claimsResponse);
                    __ctx1__.__msg_claimsResponse = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 16;
            case 16:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __ClaimsBizTalkService_claimsRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ClaimsBizTalkService.claimsRequest _schema = new ClaimsBizTalkService.claimsRequest();

        public __ClaimsBizTalkService_claimsRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ClaimsBizTalkService.claimsRequest",
        new System.Type[]{
            typeof(ClaimsBizTalkService.claimsRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ClaimsBizTalkService_claimsRequest__)
        },
        0,
        @"http://ClaimsBizTalkService.claimsRequest#ClaimsRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ClaimsBizTalkService_claimsRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ClaimsBizTalkService_claimsRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __ClaimsBizTalkService_claimsRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ClaimsBizTalkService_claimsRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __ClaimsBizTalkService_claimsResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ClaimsBizTalkService.claimsResponse _schema = new ClaimsBizTalkService.claimsResponse();

        public __ClaimsBizTalkService_claimsResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ClaimsBizTalkService.claimsResponse",
        new System.Type[]{
            typeof(ClaimsBizTalkService.claimsResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ClaimsBizTalkService_claimsResponse__)
        },
        0,
        @"http://ClaimsBizTalkService.claimsResponse#ClaimsResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ClaimsBizTalkService_claimsResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ClaimsBizTalkService_claimsResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __ClaimsBizTalkService_claimsResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ClaimsBizTalkService_claimsResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
