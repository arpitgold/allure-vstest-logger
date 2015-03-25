using System;
using AllureCSharpCommons.Events;

namespace VSTestAllureTestLogger.AllureEvents
{
    public class TestCaseFinishedWithTimeEvent : TestCaseFinishedEvent
    {
        public TestCaseFinishedWithTimeEvent(DateTime finished)
        {
            Finished = finished;
        }

        public DateTime Finished { get; private set; }

        public override void Process(AllureCSharpCommons.AllureModel.testcaseresult context)
        {
            base.Process(context);
            context.stop = Finished.ToUnixEpochTime();
        }
    }
}

