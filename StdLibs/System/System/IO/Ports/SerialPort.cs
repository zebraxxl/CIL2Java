using System.Diagnostics;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace System.IO.Ports
{
    [MonitoringDescriptionAttribute("SerialPortDesc")]
    public class SerialPort : Component
    {
        public const int InfiniteTimeout = -1;
    
        [MonitoringDescriptionAttribute("SerialErrorReceived")]
        public event SerialErrorReceivedEventHandler ErrorReceived;
    
        [MonitoringDescriptionAttribute("SerialPinChanged")]
        public event SerialPinChangedEventHandler PinChanged;
    
        [MonitoringDescriptionAttribute("SerialDataReceived")]
        public event SerialDataReceivedEventHandler DataReceived;
    
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public Stream BaseStream
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(true)]
        [MonitoringDescriptionAttribute("BaudRate")]
        [DefaultValueAttribute(9600)]
        public int BaudRate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public bool BreakState
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [BrowsableAttribute(false)]
        public int BytesToWrite
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public int BytesToRead
        {
            get { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [BrowsableAttribute(false)]
        public bool CDHolding
        {
            get { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public bool CtsHolding
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("DataBits")]
        [BrowsableAttribute(true)]
        [DefaultValueAttribute(8)]
        public int DataBits
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute(false)]
        [MonitoringDescriptionAttribute("DiscardNull")]
        [BrowsableAttribute(true)]
        public bool DiscardNull
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public bool DsrHolding
        {
            get { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("DtrEnable")]
        [BrowsableAttribute(true)]
        [DefaultValueAttribute(false)]
        public bool DtrEnable
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescriptionAttribute("Encoding")]
        [BrowsableAttribute(false)]
        public Encoding Encoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("Handshake")]
        //[DefaultValueAttribute(Mono.Cecil.CustomAttributeArgument)]
        [BrowsableAttribute(true)]
        public Handshake Handshake
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        public bool IsOpen
        {
            get { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute("\n")]
        [MonitoringDescriptionAttribute("NewLine")]
        [BrowsableAttribute(false)]
        public string NewLine
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("Parity")]
        [BrowsableAttribute(true)]
        //[DefaultValueAttribute(Mono.Cecil.CustomAttributeArgument)]
        public Parity Parity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute(63)]
        [MonitoringDescriptionAttribute("ParityReplace")]
        [BrowsableAttribute(true)]
        public byte ParityReplace
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute("COM1")]
        [MonitoringDescriptionAttribute("PortName")]
        [BrowsableAttribute(true)]
        public string PortName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(true)]
        [DefaultValueAttribute(4096)]
        [MonitoringDescriptionAttribute("ReadBufferSize")]
        public int ReadBufferSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute(-1)]
        [BrowsableAttribute(true)]
        [MonitoringDescriptionAttribute("ReadTimeout")]
        public int ReadTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ReceivedBytesThreshold")]
        [BrowsableAttribute(true)]
        [DefaultValueAttribute(1)]
        public int ReceivedBytesThreshold
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(true)]
        [MonitoringDescriptionAttribute("RtsEnable")]
        [DefaultValueAttribute(false)]
        public bool RtsEnable
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[DefaultValueAttribute(Mono.Cecil.CustomAttributeArgument)]
        [MonitoringDescriptionAttribute("StopBits")]
        [BrowsableAttribute(true)]
        public StopBits StopBits
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(true)]
        [DefaultValueAttribute(2048)]
        [MonitoringDescriptionAttribute("WriteBufferSize")]
        public int WriteBufferSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute(-1)]
        [MonitoringDescriptionAttribute("WriteTimeout")]
        [BrowsableAttribute(true)]
        public int WriteTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SerialPort(IContainer container)
        {
             throw new NotImplementedException();
        }
        
        
        public SerialPort()
        {
             throw new NotImplementedException();
        }
        
        
        public SerialPort(string portName)
        {
             throw new NotImplementedException();
        }
        
        
        public SerialPort(string portName, int baudRate)
        {
             throw new NotImplementedException();
        }
        
        
        public SerialPort(string portName, int baudRate, Parity parity)
        {
             throw new NotImplementedException();
        }
        
        
        public SerialPort(string portName, int baudRate, Parity parity, int dataBits)
        {
             throw new NotImplementedException();
        }
        
        
        public SerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void DiscardInBuffer()
        {
             throw new NotImplementedException();
        }
        
        
        public void DiscardOutBuffer()
        {
             throw new NotImplementedException();
        }
        
        
        public static string[] GetPortNames()
        {
             throw new NotImplementedException();
        }
        
        
        public void Open()
        {
             throw new NotImplementedException();
        }
        
        
        public int Read(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public int ReadChar()
        {
             throw new NotImplementedException();
        }
        
        
        public int Read(char[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public int ReadByte()
        {
             throw new NotImplementedException();
        }
        
        
        public string ReadExisting()
        {
             throw new NotImplementedException();
        }
        
        
        public string ReadLine()
        {
             throw new NotImplementedException();
        }
        
        
        public string ReadTo(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Write(string text)
        {
             throw new NotImplementedException();
        }
        
        
        public void Write(char[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public void Write(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public void WriteLine(string text)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
