using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.EventSourcing.Common
{
    public struct Event
    {
        public struct NotificationLog
        {
            public struct LogId
            {
                public struct Regex
                {
                    public const string Pattern = @"^
(?<Low>[\d]+)
\x2C
(?<High>[\d]+)
\z";
                    public struct CaptureName
                    {
                        public const string Low = "Low";
                        public const string High = "High";
                    }
                }
            }
        }
    }
}