﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocksAndStubsUnitTest
{
    class MockLogService : ILogService
    {
        public string? lastError;

        public void LogError(string error)
        {
            lastError = error;
        }
    }
}
