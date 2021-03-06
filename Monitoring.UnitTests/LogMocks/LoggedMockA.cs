﻿using System;

namespace PubComp.Aspects.Monitoring.UnitTests.LogMocks
{
    public class LoggedMockA : ILoggedMock
    {
        [LogExceptions]
        public LoggedMockA(bool doThrow = false)
        {
            if (doThrow)
                throw new ApplicationException();
        }

        [Log]
        public void ThrowSomething()
        {
            throw new ApplicationException("Something");
        }

        [Log]
        public void Short()
        {
        }

        [Log("MyLog")]
        public void Other()
        {
        }
    }
}
