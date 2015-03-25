using System;
using AllureCSharpCommons.Events;

namespace VSTestAllureTestLogger.AllureEvents
{
    public class TestSuiteFinishedWithTimeEvent : TestSuiteFinishedEvent
    {
        public TestSuiteFinishedWithTimeEvent(string uid, DateTime finished)
            : base(uid)
        {
            Finished = finished;
        }

        public DateTime Finished { get; private set; }

        public override void Process(AllureCSharpCommons.AllureModel.testsuiteresult context)
        {
            base.Process(context);
            context.stop = Finished.ToUnixEpochTime();
        }
    }
}

