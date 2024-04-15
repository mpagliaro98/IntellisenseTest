using CoreProject.GeneratorOutput;

namespace CoreProject;

public static class CoreClass
{
    public static void SomeFunction()
    {
        // since this is in CoreProject, if i start typing MyObjects, it does show up in the typing suggestions
        // generated code shows up in the typing suggestions in the project it was generated in, but not in projects that reference this project
        // all the code in all these projects still compiles and works just fine, the only issue is lack of typing suggestions
        var _ = MyObjects.something;
    }
}