using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApplication
{
    public class TestHub : Hub
    {
        public byte[] GetData(int size) => new byte[size];
    }
}
