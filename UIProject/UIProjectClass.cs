using CoreProject;
using CoreProject.GeneratorOutput;

namespace UIProject;

public static class UIProjectClass
{
    public static void TestUI()
    {
        // example doing the same test in a non-razor file, same issue happens
        var _ = MyObjects.something;

        // this shows up in typing suggestions just fine, but the above line does not
        CoreClass.SomeFunction();
    }
}
