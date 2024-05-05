using CoreProject;
using CoreProject.GeneratorOutput;

namespace UIProject;

public static class UIProjectClass
{
    public static void TestUI()
    {
        // example doing the same test in a non-razor file, start typing "MyObjects" and text completions work here
        // they appear to only not work in the razor editor
        var _ = MyObjects.something;
    }
}
