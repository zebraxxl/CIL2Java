using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Collections;

namespace System.Net
{
    [Serializable]
    [ComVisibleAttribute(true)]
    public class WebHeaderCollection : NameValueCollection, ISerializable
    {
    
        public string this[HttpRequestHeader header]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string this[HttpResponseHeader header]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public override KeysCollection Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string[] AllKeys
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public void Add(HttpRequestHeader header, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(HttpResponseHeader header, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Set(HttpRequestHeader header, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Set(HttpResponseHeader header, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(HttpRequestHeader header)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(HttpResponseHeader header)
        {
             throw new NotImplementedException();
        }
        
        
        protected void AddWithoutValidate(string headerName, string headerValue)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Add(string name, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(string header)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Set(string name, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Remove(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public override string[] GetValues(string header)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] ToByteArray()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsRestricted(string headerName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsRestricted(string headerName, bool response)
        {
             throw new NotImplementedException();
        }
        
        
        public WebHeaderCollection()
        {
             throw new NotImplementedException();
        }
        
        
        protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public override void OnDeserialization(object sender)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public override string Get(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public override IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public override string Get(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public override string[] GetValues(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public override string GetKey(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Clear()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
