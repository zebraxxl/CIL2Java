using CIL2Java.Attributes;
using System;
using System.Collections.Generic;
using boolean = System.Boolean;

namespace java.lang
{
    [FromJava]
    public sealed class Boolean : io.Serializable, Comparable
    {
        [FromJava] public static sealed Boolean TRUE;
        [FromJava] public static sealed Boolean FALSE;
        [FromJava] public static readonly Class TYPE;


        [FromJava] public Boolean(boolean value) { }
        [FromJava] public Boolean(string s) { }
        [FromJava] public static boolean parseBoolean(string s) { return false; }
        [FromJava] public boolean booleanValue() { return false; }
        [FromJava] public static Boolean valueOf(boolean b) { return null; }
        [FromJava] public static Boolean valueOf(string s) { return null; }
        [FromJava] public static string toString(boolean b) { return null; }
        [FromJava] public override string ToString() { return null; }
        [FromJava] public override int GetHashCode() { return 0; }
        [FromJava] public override boolean Equals(object obj) { return false; }
        [FromJava] public static boolean getBoolean(string name) { return false; }
        [FromJava] public int compareTo(object b) { return 0; }
        [FromJava] public static int compare(boolean x, boolean y) { return 0; }
    }
}
