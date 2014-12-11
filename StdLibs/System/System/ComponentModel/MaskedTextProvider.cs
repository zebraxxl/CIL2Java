using System;
using System.Globalization;
using System.Collections;

namespace System.ComponentModel
{
    public class MaskedTextProvider : ICloneable
    {
    
        public bool AllowPromptAsInput
        {
            get { throw new NotImplementedException(); }
        }
    
        public int AssignedEditPositionCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public int AvailableEditPositionCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public CultureInfo Culture
        {
            get { throw new NotImplementedException(); }
        }
    
        public static char DefaultPasswordChar
        {
            get { throw new NotImplementedException(); }
        }
    
        public int EditPositionCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public IEnumerator EditPositions
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IncludeLiterals
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IncludePrompt
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool AsciiOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsPassword
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static int InvalidIndex
        {
            get { throw new NotImplementedException(); }
        }
    
        public int LastAssignedPosition
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Length
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Mask
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool MaskCompleted
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool MaskFull
        {
            get { throw new NotImplementedException(); }
        }
    
        public char PasswordChar
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public char PromptChar
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool ResetOnPrompt
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool ResetOnSpace
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool SkipLiterals
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public char this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MaskedTextProvider(string mask)
        {
             throw new NotImplementedException();
        }
        
        
        public MaskedTextProvider(string mask, bool restrictToAscii)
        {
             throw new NotImplementedException();
        }
        
        
        public MaskedTextProvider(string mask, CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        public MaskedTextProvider(string mask, CultureInfo culture, bool restrictToAscii)
        {
             throw new NotImplementedException();
        }
        
        
        public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput)
        {
             throw new NotImplementedException();
        }
        
        
        public MaskedTextProvider(string mask, CultureInfo culture, char passwordChar, bool allowPromptAsInput)
        {
             throw new NotImplementedException();
        }
        
        
        public MaskedTextProvider(string mask, CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii)
        {
             throw new NotImplementedException();
        }
        
        
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Add(char input)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Add(char input, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Add(string input)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Add(string input, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear(ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindAssignedEditPositionFrom(int position, bool direction)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindEditPositionFrom(int position, bool direction)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindEditPositionInRange(int startPosition, int endPosition, bool direction)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindNonEditPositionFrom(int position, bool direction)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindUnassignedEditPositionFrom(int position, bool direction)
        {
             throw new NotImplementedException();
        }
        
        
        public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool GetOperationResultFromHint(MaskedTextResultHint hint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool InsertAt(char input, int position)
        {
             throw new NotImplementedException();
        }
        
        
        public bool InsertAt(char input, int position, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool InsertAt(string input, int position)
        {
             throw new NotImplementedException();
        }
        
        
        public bool InsertAt(string input, int position, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsAvailablePosition(int position)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsEditPosition(int position)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsValidInputChar(char c)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsValidMaskChar(char c)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsValidPasswordChar(char c)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Remove()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Remove(ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool RemoveAt(int position)
        {
             throw new NotImplementedException();
        }
        
        
        public bool RemoveAt(int startPosition, int endPosition)
        {
             throw new NotImplementedException();
        }
        
        
        public bool RemoveAt(int startPosition, int endPosition, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Replace(char input, int position)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Replace(char input, int position, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Replace(char input, int startPosition, int endPosition, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Replace(string input, int position)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Replace(string input, int position, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Replace(string input, int startPosition, int endPosition, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Set(string input)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Set(string input, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToDisplayString()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public string ToString(bool ignorePasswordChar)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToString(int startPosition, int length)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToString(bool ignorePasswordChar, int startPosition, int length)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToString(bool includePrompt, bool includeLiterals)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length)
        {
             throw new NotImplementedException();
        }
        
        
        public bool VerifyChar(char input, int position, ref MaskedTextResultHint hint)
        {
             throw new NotImplementedException();
        }
        
        
        public bool VerifyEscapeChar(char input, int position)
        {
             throw new NotImplementedException();
        }
        
        
        public bool VerifyString(string input)
        {
             throw new NotImplementedException();
        }
        
        
        public bool VerifyString(string input, ref int testPosition, ref MaskedTextResultHint resultHint)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
