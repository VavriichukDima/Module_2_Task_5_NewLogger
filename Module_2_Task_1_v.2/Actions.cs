using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_1
{
    public class Actions
    {
        private readonly Logger _logger = Logger.Instance;
        public Result Info()
        {
            _logger.LogEventInfo($"Start method: {nameof(Info)}");
            return new Result() { Status = true };
        }

        public Result Warning()
        {
            _logger.LogEventWarning($"Skipped logic in method: {nameof(Warning)}");
            return new Result() { Status = true };
        }

        public Result Error()
        {
            return new Result() { Status = false, ErrorMessage = "I broke a logic." };
        }
    }
}
