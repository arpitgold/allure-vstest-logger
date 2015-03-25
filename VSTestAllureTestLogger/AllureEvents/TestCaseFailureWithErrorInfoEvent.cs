﻿using System;
using AllureCSharpCommons.AllureModel;
using AllureCSharpCommons.Events;

namespace VSTestAllureTestLogger.AllureEvents
{
    public class TestCaseFailureWithErrorInfoEvent : TestCaseFailureEvent
    {
        string mMessage;
        string mStackTrace;

        public TestCaseFailureWithErrorInfoEvent(string message, string stackTrace)
        {
            mMessage = message;
            mStackTrace = stackTrace;
        }

        protected override string Message
        {
            get { return mMessage; }
            set { throw new InvalidOperationException(); }
        }

        public override string StackTrace
        {
            get { return mStackTrace; }
            set { throw new InvalidOperationException(); }
        }

        protected override status Status
        {
            get { return status.failed; }
        }

    }
}

