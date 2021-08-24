using System;
using System.Collections.Generic;
using System.Text;
using Todoquintero.Function;
using Todoquintero.Test.Helpers;
using Xunit;

namespace Todoquintero.Test.Test
{
   public class ScheduledFunctionTest
    {
        [Fact]
        public void ScheduledFunction_Should_Log_Message()
        {
            // Arrange
            MockCloudTableTodos mockTodos = new MockCloudTableTodos(new Uri("http://127.0.0.1:10002/devstoreaccount1/reports"));
            ListLogger logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);

            // Act
            ScheduledFunction.Run(null, mockTodos, logger);
            string message = logger.logs[0];

            // Assert
            Assert.Contains("Deleting completed", message);
        }

    }
}
