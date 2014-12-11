using System;

namespace System.Collections.Specialized
{
    public struct BitVector32
    {
        public struct Section
        {
        
            public short Mask
            {
                get { throw new NotImplementedException(); }
            }
        
            public short Offset
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public override bool Equals(object o)
            {
                 throw new NotImplementedException();
            }
            
            
            public bool Equals(Section obj)
            {
                 throw new NotImplementedException();
            }
            
            
            public static bool operator ==(Section a, Section b)
            {
                 throw new NotImplementedException();
            }
            
            
            public static bool operator !=(Section a, Section b)
            {
                 throw new NotImplementedException();
            }
            
            
            public override int GetHashCode()
            {
                 throw new NotImplementedException();
            }
            
            
            public static string ToString(Section value)
            {
                 throw new NotImplementedException();
            }
            
            
            public override string ToString()
            {
                 throw new NotImplementedException();
            }
            
            
        }
    
    
        public bool this[int bit]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int this[Section section]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Data
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public BitVector32(int data)
        {
             throw new NotImplementedException();
        }
        
        
        public BitVector32(BitVector32 value)
        {
             throw new NotImplementedException();
        }
        
        
        public static int CreateMask()
        {
             throw new NotImplementedException();
        }
        
        
        public static int CreateMask(int previous)
        {
             throw new NotImplementedException();
        }
        
        
        public static Section CreateSection(short maxValue)
        {
             throw new NotImplementedException();
        }
        
        
        public static Section CreateSection(short maxValue, Section previous)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public static string ToString(BitVector32 value)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
