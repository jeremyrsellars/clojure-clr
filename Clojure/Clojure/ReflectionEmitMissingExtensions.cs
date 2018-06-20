using Microsoft.Scripting.Generation;
using System;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace clojure.lang
{
    internal static class ReflectionEmitMissingExtensions
    {
        [Obsolete("CompileToMethod is not implemented", true)]
        public static void CompileToMethod(this LambdaExpression le, MethodBuilder mb) =>
            throw new NotImplementedException("LambdaExpression.CompileToMethod");

        [Obsolete("IsTransient is not available")]
        public static bool IsTransient(this ModuleBuilder mb) =>
            false;

        [Obsolete("DefineDocument is not available")]
        public static System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(this ModuleBuilder mb, string sourceName, Guid languageGuid, Guid vendorGuid, Guid guid) =>
            null;

        [Obsolete("MarkSequencePoint is not available")]
        public static void MarkSequencePoint(this ILGen gen, object _docWriter, int startLine, int startCol, int finishLine, int finishCol)
        { }

        [Obsolete("SetLocalSymInfo is not available")]
        public static void SetLocalSymInfo(this LocalBuilder lb, string name)
        { }


        [Obsolete("SetEntryPoint is not available")]
        public static void SetEntryPoint(this AssemblyBuilder ab, MethodBuilder cb)
        { }
    }
}
