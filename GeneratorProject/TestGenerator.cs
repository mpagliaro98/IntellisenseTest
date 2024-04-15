using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace GeneratorProject
{
    [Generator(LanguageNames.CSharp)]
    public class TestGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            // do nothing for simplicity
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var source = GenerateClass(context);
            context.AddSource("MyObjects.g.cs", SourceText.From(source, Encoding.UTF8));
        }

        private string GenerateClass(GeneratorExecutionContext context)
        {
            var namespaceName = "CoreProject";

            // basic generator example - it doesn't matter what this generates, the issue still happens, this is just a basic example
            var source = new StringBuilder($@"
namespace {namespaceName}.GeneratorOutput;

public static partial class MyObjects
{{
    public static int something => 2;
}}
");
            return source.ToString();
        }
    }
}
