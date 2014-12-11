using System.ComponentModel;
using System;

namespace System.Text.RegularExpressions
{
    [EditorBrowsableAttribute(EditorBrowsableState.Never)]
    public abstract class RegexRunner
    {
        protected int runtextbeg;
        protected int runtextend;
        protected int runtextstart;
        protected string runtext;
        protected int runtextpos;
        protected int[] runtrack;
        protected int runtrackpos;
        protected int[] runstack;
        protected int runstackpos;
        protected int[] runcrawl;
        protected int runcrawlpos;
        protected int runtrackcount;
        protected Match runmatch;
        protected Regex runregex;
    
        protected RegexRunner()
        {
             throw new NotImplementedException();
        }
        
        
        protected Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick)
        {
             throw new NotImplementedException();
        }
        
        
        protected Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        protected void CheckTimeout()
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void Go();
        
        
        protected abstract bool FindFirstChar();
        
        
        protected abstract void InitTrackCount();
        
        
        protected void EnsureStorage()
        {
             throw new NotImplementedException();
        }
        
        
        protected bool IsBoundary(int index, int startpos, int endpos)
        {
             throw new NotImplementedException();
        }
        
        
        protected bool IsECMABoundary(int index, int startpos, int endpos)
        {
             throw new NotImplementedException();
        }
        
        
        protected static bool CharInSet(char ch, string set, string category)
        {
             throw new NotImplementedException();
        }
        
        
        protected static bool CharInClass(char ch, string charClass)
        {
             throw new NotImplementedException();
        }
        
        
        protected void DoubleTrack()
        {
             throw new NotImplementedException();
        }
        
        
        protected void DoubleStack()
        {
             throw new NotImplementedException();
        }
        
        
        protected void DoubleCrawl()
        {
             throw new NotImplementedException();
        }
        
        
        protected void Crawl(int i)
        {
             throw new NotImplementedException();
        }
        
        
        protected int Popcrawl()
        {
             throw new NotImplementedException();
        }
        
        
        protected int Crawlpos()
        {
             throw new NotImplementedException();
        }
        
        
        protected void Capture(int capnum, int start, int end)
        {
             throw new NotImplementedException();
        }
        
        
        protected void TransferCapture(int capnum, int uncapnum, int start, int end)
        {
             throw new NotImplementedException();
        }
        
        
        protected void Uncapture()
        {
             throw new NotImplementedException();
        }
        
        
        protected bool IsMatched(int cap)
        {
             throw new NotImplementedException();
        }
        
        
        protected int MatchIndex(int cap)
        {
             throw new NotImplementedException();
        }
        
        
        protected int MatchLength(int cap)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
