using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace IndexerExample
{
    public partial class YoungProfessional
    {

        public string Address { get; private set; }

        public void setAddress(string address)
        {
            Address = address;
        }
    }
}
