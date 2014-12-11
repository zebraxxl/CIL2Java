using System.ComponentModel;
using System.Runtime.Serialization;
using System;
using System.IO;

namespace System.Media
{
    [Serializable]
    [ToolboxItemAttribute(false)]
    public class SoundPlayer : Component, ISerializable
    {
    
        public event AsyncCompletedEventHandler LoadCompleted;
    
        public event EventHandler SoundLocationChanged;
    
        public event EventHandler StreamChanged;
    
    
        public int LoadTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string SoundLocation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Stream Stream
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IsLoadCompleted
        {
            get { throw new NotImplementedException(); }
        }
    
        public object Tag
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SoundPlayer()
        {
             throw new NotImplementedException();
        }
        
        
        public SoundPlayer(string soundLocation)
        {
             throw new NotImplementedException();
        }
        
        
        public SoundPlayer(Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        protected SoundPlayer(SerializationInfo serializationInfo, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public void LoadAsync()
        {
             throw new NotImplementedException();
        }
        
        
        public void Load()
        {
             throw new NotImplementedException();
        }
        
        
        public void Play()
        {
             throw new NotImplementedException();
        }
        
        
        public void PlaySync()
        {
             throw new NotImplementedException();
        }
        
        
        public void PlayLooping()
        {
             throw new NotImplementedException();
        }
        
        
        public void Stop()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnLoadCompleted(AsyncCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnSoundLocationChanged(EventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnStreamChanged(EventArgs e)
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
