// <copyright file="PexAssemblyInfo.cs" company="">Copyright ©rido  2007</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Stubs;
using Microsoft.Pex.Framework.Validation;
using Microsoft.Pex.Linq;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("trx2html.Test")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("System.Xml.Linq")]
[assembly: PexInstrumentAssembly("Microsoft.VisualStudio.QualityTools.UnitTestFramework")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Xml.Linq")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "trx2html.Test")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.VisualStudio.QualityTools.UnitTestFramework")]

// Microsoft.Pex.Framework.Stubs
[assembly: PexAssumeContractEnsuresFailureAtStubSurface]
[assembly: PexChooseAsBehavedFallbackBehavior]
[assembly: PexUseStubsFromTestAssembly]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]

// Microsoft.Pex.Linq
[assembly: PexLinqPackage]

