using System.Runtime.Serialization;
using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Text.RegularExpressions
{
    [Serializable]
    public class Regex : ISerializable
    {
        protected string pattern;
        protected RegexRunnerFactory factory;
        protected RegexOptions roptions;
        public static readonly TimeSpan InfiniteMatchTimeout;
        [OptionalFieldAttribute(VersionAdded = 2)]
        protected TimeSpan internalMatchTimeout;
        protected Hashtable caps;
        protected Hashtable capnames;
        protected string[] capslist;
        protected int capsize;
    
        public static int CacheSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public RegexOptions Options
        {
            get { throw new NotImplementedException(); }
        }
    
        public TimeSpan MatchTimeout
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool RightToLeft
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected Regex()
        {
             throw new NotImplementedException();
        }
        
        
        public Regex(string pattern)
        {
             throw new NotImplementedException();
        }
        
        
        public Regex(string pattern, RegexOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public Regex(string pattern, RegexOptions options, TimeSpan matchTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        protected Regex(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        protected static void ValidateMatchTimeout(TimeSpan matchTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public static string Escape(string str)
        {
             throw new NotImplementedException();
        }
        
        
        public static string Unescape(string str)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public string[] GetGroupNames()
        {
             throw new NotImplementedException();
        }
        
        
        public int[] GetGroupNumbers()
        {
             throw new NotImplementedException();
        }
        
        
        public string GroupNameFromNumber(int i)
        {
             throw new NotImplementedException();
        }
        
        
        public int GroupNumberFromName(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsMatch(string input, string pattern)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsMatch(string input, string pattern, RegexOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsMatch(string input)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsMatch(string input, int startat)
        {
             throw new NotImplementedException();
        }
        
        
        public static Match Match(string input, string pattern)
        {
             throw new NotImplementedException();
        }
        
        
        public static Match Match(string input, string pattern, RegexOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public Match Match(string input)
        {
             throw new NotImplementedException();
        }
        
        
        public Match Match(string input, int startat)
        {
             throw new NotImplementedException();
        }
        
        
        public Match Match(string input, int beginning, int length)
        {
             throw new NotImplementedException();
        }
        
        
        public static MatchCollection Matches(string input, string pattern)
        {
             throw new NotImplementedException();
        }
        
        
        public static MatchCollection Matches(string input, string pattern, RegexOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public MatchCollection Matches(string input)
        {
             throw new NotImplementedException();
        }
        
        
        public MatchCollection Matches(string input, int startat)
        {
             throw new NotImplementedException();
        }
        
        
        public static string Replace(string input, string pattern, string replacement)
        {
             throw new NotImplementedException();
        }
        
        
        public static string Replace(string input, string pattern, string replacement, RegexOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public string Replace(string input, string replacement)
        {
             throw new NotImplementedException();
        }
        
        
        public string Replace(string input, string replacement, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public string Replace(string input, string replacement, int count, int startat)
        {
             throw new NotImplementedException();
        }
        
        
        public static string Replace(string input, string pattern, MatchEvaluator evaluator)
        {
             throw new NotImplementedException();
        }
        
        
        public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public string Replace(string input, MatchEvaluator evaluator)
        {
             throw new NotImplementedException();
        }
        
        
        public string Replace(string input, MatchEvaluator evaluator, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public string Replace(string input, MatchEvaluator evaluator, int count, int startat)
        {
             throw new NotImplementedException();
        }
        
        
        public static string[] Split(string input, string pattern)
        {
             throw new NotImplementedException();
        }
        
        
        public static string[] Split(string input, string pattern, RegexOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public static string[] Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public string[] Split(string input)
        {
             throw new NotImplementedException();
        }
        
        
        public string[] Split(string input, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public string[] Split(string input, int count, int startat)
        {
             throw new NotImplementedException();
        }
        
        
        public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname)
        {
             throw new NotImplementedException();
        }
        
        
        public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname, CustomAttributeBuilder[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname, CustomAttributeBuilder[] attributes, string resourceFile)
        {
             throw new NotImplementedException();
        }
        
        
        protected void InitializeReferences()
        {
             throw new NotImplementedException();
        }
        
        
        protected bool UseOptionC()
        {
             throw new NotImplementedException();
        }
        
        
        protected bool UseOptionR()
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
