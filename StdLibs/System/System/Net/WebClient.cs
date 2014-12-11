using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Text;
using System.Collections.Specialized;
using System.Net.Cache;
using System.IO;
using System.Threading.Tasks;

namespace System.Net
{
    [ComVisibleAttribute(true)]
    public class WebClient : Component
    {
    
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public event WriteStreamClosedEventHandler WriteStreamClosed;
    
        public event OpenReadCompletedEventHandler OpenReadCompleted;
    
        public event OpenWriteCompletedEventHandler OpenWriteCompleted;
    
        public event DownloadStringCompletedEventHandler DownloadStringCompleted;
    
        public event DownloadDataCompletedEventHandler DownloadDataCompleted;
    
        public event AsyncCompletedEventHandler DownloadFileCompleted;
    
        public event UploadStringCompletedEventHandler UploadStringCompleted;
    
        public event UploadDataCompletedEventHandler UploadDataCompleted;
    
        public event UploadFileCompletedEventHandler UploadFileCompleted;
    
        public event UploadValuesCompletedEventHandler UploadValuesCompleted;
    
        public event DownloadProgressChangedEventHandler DownloadProgressChanged;
    
        public event UploadProgressChangedEventHandler UploadProgressChanged;
    
    
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public bool AllowReadStreamBuffering
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AllowWriteStreamBuffering
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Encoding Encoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string BaseAddress
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ICredentials Credentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool UseDefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public NameValueCollection QueryString
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public WebHeaderCollection ResponseHeaders
        {
            get { throw new NotImplementedException(); }
        }
    
        public IWebProxy Proxy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public RequestCachePolicy CachePolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IsBusy
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WebClient()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        protected virtual void OnWriteStreamClosed(WriteStreamClosedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual WebRequest GetWebRequest(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual WebResponse GetWebResponse(WebRequest request)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] DownloadData(string address)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] DownloadData(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        public void DownloadFile(string address, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public void DownloadFile(Uri address, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public Stream OpenRead(string address)
        {
             throw new NotImplementedException();
        }
        
        
        public Stream OpenRead(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        public Stream OpenWrite(string address)
        {
             throw new NotImplementedException();
        }
        
        
        public Stream OpenWrite(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        public Stream OpenWrite(string address, string method)
        {
             throw new NotImplementedException();
        }
        
        
        public Stream OpenWrite(Uri address, string method)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadData(string address, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadData(Uri address, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadData(string address, string method, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadData(Uri address, string method, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadFile(string address, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadFile(Uri address, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadFile(string address, string method, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadFile(Uri address, string method, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadValues(string address, NameValueCollection data)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadValues(Uri address, NameValueCollection data)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadValues(string address, string method, NameValueCollection data)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] UploadValues(Uri address, string method, NameValueCollection data)
        {
             throw new NotImplementedException();
        }
        
        
        public string UploadString(string address, string data)
        {
             throw new NotImplementedException();
        }
        
        
        public string UploadString(Uri address, string data)
        {
             throw new NotImplementedException();
        }
        
        
        public string UploadString(string address, string method, string data)
        {
             throw new NotImplementedException();
        }
        
        
        public string UploadString(Uri address, string method, string data)
        {
             throw new NotImplementedException();
        }
        
        
        public string DownloadString(string address)
        {
             throw new NotImplementedException();
        }
        
        
        public string DownloadString(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void OpenReadAsync(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        public void OpenReadAsync(Uri address, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void OpenWriteAsync(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        public void OpenWriteAsync(Uri address, string method)
        {
             throw new NotImplementedException();
        }
        
        
        public void OpenWriteAsync(Uri address, string method, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void DownloadStringAsync(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        public void DownloadStringAsync(Uri address, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void DownloadDataAsync(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        public void DownloadDataAsync(Uri address, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnDownloadFileCompleted(AsyncCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void DownloadFileAsync(Uri address, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public void DownloadFileAsync(Uri address, string fileName, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadStringAsync(Uri address, string data)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadStringAsync(Uri address, string method, string data)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadStringAsync(Uri address, string method, string data, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadDataAsync(Uri address, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadDataAsync(Uri address, string method, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadDataAsync(Uri address, string method, byte[] data, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadFileAsync(Uri address, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadFileAsync(Uri address, string method, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadFileAsync(Uri address, string method, string fileName, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadValuesAsync(Uri address, NameValueCollection data)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadValuesAsync(Uri address, string method, NameValueCollection data)
        {
             throw new NotImplementedException();
        }
        
        
        public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void CancelAsync()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<string> DownloadStringTaskAsync(string address)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<string> DownloadStringTaskAsync(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<Stream> OpenReadTaskAsync(string address)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<Stream> OpenReadTaskAsync(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<Stream> OpenWriteTaskAsync(string address)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<Stream> OpenWriteTaskAsync(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<Stream> OpenWriteTaskAsync(string address, string method)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<Stream> OpenWriteTaskAsync(Uri address, string method)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<string> UploadStringTaskAsync(string address, string data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<string> UploadStringTaskAsync(Uri address, string data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<string> UploadStringTaskAsync(string address, string method, string data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<string> UploadStringTaskAsync(Uri address, string method, string data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> DownloadDataTaskAsync(string address)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> DownloadDataTaskAsync(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task DownloadFileTaskAsync(string address, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task DownloadFileTaskAsync(Uri address, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadDataTaskAsync(string address, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadDataTaskAsync(Uri address, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadDataTaskAsync(string address, string method, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadDataTaskAsync(Uri address, string method, byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadFileTaskAsync(string address, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadFileTaskAsync(Uri address, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadFileTaskAsync(string address, string method, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadFileTaskAsync(Uri address, string method, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadValuesTaskAsync(string address, NameValueCollection data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadValuesTaskAsync(string address, string method, NameValueCollection data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadValuesTaskAsync(Uri address, NameValueCollection data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public Task<byte[]> UploadValuesTaskAsync(Uri address, string method, NameValueCollection data)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
