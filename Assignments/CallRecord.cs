using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public CallRecord(int callId, long phNo, string? callTime)
        {
            this.callId = callId;
            this.phNo = phNo;
            this.callTime = callTime;
        }

        public int callId {  get; set; }
        public long phNo { get; set; }
        public string? callTime {  get; set; }
    }
}
