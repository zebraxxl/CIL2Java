using System;
using System.Collections.Generic;


public static class Local
{
    public static string GetText(string Text)
    {
        return Text;
    }

    public static string GetText(string Text, params object[] values)
    {
        return string.Format(Text, values);
    }
}

