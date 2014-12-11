using System.ComponentModel;
using System.Collections;
using System;

namespace System.ComponentModel.Design
{
    public abstract class DesignerOptionService : IDesignerOptionService
    {
        [EditorAttribute("", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public sealed class DesignerOptionCollection : IList
        {
        
            public int Count
            {
                get { throw new NotImplementedException(); }
            }
        
            public string Name
            {
                get { throw new NotImplementedException(); }
            }
        
            public DesignerOptionCollection Parent
            {
                get { throw new NotImplementedException(); }
            }
        
            public PropertyDescriptorCollection Properties
            {
                get { throw new NotImplementedException(); }
            }
        
            public DesignerOptionCollection this[int index]
            {
                get { throw new NotImplementedException(); }
            }
        
            public DesignerOptionCollection this[string name]
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public void CopyTo(Array array, int index)
            {
                 throw new NotImplementedException();
            }
            
            
            public IEnumerator GetEnumerator()
            {
                 throw new NotImplementedException();
            }
            
            
            public int IndexOf(DesignerOptionCollection value)
            {
                 throw new NotImplementedException();
            }
            
            
            public bool ShowDialog()
            {
                 throw new NotImplementedException();
            }



            int IList.Add(object value)
            {
                throw new NotImplementedException();
            }

            void IList.Clear()
            {
                throw new NotImplementedException();
            }

            bool IList.Contains(object value)
            {
                throw new NotImplementedException();
            }

            int IList.IndexOf(object value)
            {
                throw new NotImplementedException();
            }

            void IList.Insert(int index, object value)
            {
                throw new NotImplementedException();
            }

            bool IList.IsFixedSize
            {
                get { throw new NotImplementedException(); }
            }

            bool IList.IsReadOnly
            {
                get { throw new NotImplementedException(); }
            }

            void IList.Remove(object value)
            {
                throw new NotImplementedException();
            }

            void IList.RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            object IList.this[int index]
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            void ICollection.CopyTo(Array array, int index)
            {
                throw new NotImplementedException();
            }

            int ICollection.Count
            {
                get { throw new NotImplementedException(); }
            }

            bool ICollection.IsSynchronized
            {
                get { throw new NotImplementedException(); }
            }

            object ICollection.SyncRoot
            {
                get { throw new NotImplementedException(); }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    
    
        public DesignerOptionCollection Options
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected DesignerOptionCollection CreateOptionCollection(DesignerOptionCollection parent, string name, object value)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void PopulateOptionCollection(DesignerOptionCollection options)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual bool ShowDialog(DesignerOptionCollection options, object optionObject)
        {
             throw new NotImplementedException();
        }
        
        
        protected DesignerOptionService()
        {
             throw new NotImplementedException();
        }



        object IDesignerOptionService.GetOptionValue(string pageName, string valueName)
        {
            throw new NotImplementedException();
        }

        void IDesignerOptionService.SetOptionValue(string pageName, string valueName, object value)
        {
            throw new NotImplementedException();
        }
    }
}
