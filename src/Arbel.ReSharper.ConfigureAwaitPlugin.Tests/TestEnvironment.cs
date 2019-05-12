﻿using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: RequiresSTA]

namespace Arbel.ReSharper.ConfigureAwaitPlugin.Tests
{
    [ZoneDefinition]
    public interface IConfigureAwaitPluginTestZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>
    {
    }

    [SetUpFixture]
    public class TestEnvironment : ExtensionTestEnvironmentAssembly<IConfigureAwaitPluginTestZone>
    {
    }
}