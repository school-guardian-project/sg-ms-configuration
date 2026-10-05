using System.Reflection;

namespace ms_configuration.Tests;

/// <summary>
/// Setup smoke test. It fails whenever the API project stops compiling or its
/// entry point is renamed, which is the only thing this branch wires up.
/// </summary>
public class SmokeTests
{
    [Fact]
    public void ApiAssembly_ExposesProgramEntryPoint()
    {
        var assembly = Assembly.Load("ms-configuration.Api");

        Assert.NotNull(assembly.GetType("Program"));
    }
}
