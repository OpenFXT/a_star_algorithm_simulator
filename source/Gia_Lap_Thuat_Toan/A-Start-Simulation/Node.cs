using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Start_Console
{
    internal class Node
    {
        private int index;
        private int gValue;
        private int hValue;
        private int prev;

        public int getIndex()
        {
            return index;
        }

        public int getgValue()
        {
            return gValue;
        }

        public int gethValue()
        {
            return hValue;
        }

        public int getfValue()
        {
            return gValue + hValue;
        }

        public int getprev() 
        { 
            return prev;
        }

        public void setIndex (int index)
        {
            this.index = index;
        }

        public void setgValue (int gValue) 
        { 
            this .gValue = gValue;
        }

        public void sethValue (int hValue)
        {
            this .hValue = hValue;
        }
    
        public void setprev(int prev)
        {
            this .prev = prev;
        }
    }
}
