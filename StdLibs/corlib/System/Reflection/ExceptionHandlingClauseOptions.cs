using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Identifies kinds of exception-handling clauses.</summary>
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum ExceptionHandlingClauseOptions : int
    {
        /// <summary>The clause accepts all exceptions that derive from a specified type.</summary>
        Clause = 0,
        /// <summary>The clause contains user-specified instructions that determine whether the exception should be ignored (that is, whether normal execution should resume), be handled by the associated handler, or be passed on to the next clause.</summary>
        Filter = 1,
        /// <summary>The clause is executed whenever the try block exits, whether through normal control flow or because of an unhandled exception.</summary>
        Finally = 2,
        /// <summary>The clause is executed if an exception occurs, but not on completion of normal control flow.</summary>
        Fault = 4
    }
}
