using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_1
{
    public class Starter
    {
        private const string LoggerFilePath = "log.txt";
        private readonly Logger _logger;
        private readonly Actions _actions;
        private readonly FileService _fileService;
        private readonly int _minRandom = 0;
        private readonly int _maxRandom = 3;
        private readonly Random _random = new Random();

        public Starter()
        {
            _logger = Logger.Instance;
            _actions = new Actions();
            _fileService = new FileService();
        }

        public void Run()
        {
            for (var i = 0; i <= 100; i++)
            {
                var result = new Result();
                var randomAction = _random.Next(_minRandom, _maxRandom);
                switch (randomAction)
                {
                    case 0:
                        result = _actions.Info();
                        break;
                    case 1:
                        result = _actions.Warning();
                        break;
                    case 2:
                        result = _actions.Error();
                        break;
                }

                if (!result.Status)
                {
                    _logger.LogEventError($"Action failed by a reason: {result.ErrorMessage}");
                }
            }

            _fileService.Write(LoggerFilePath, _logger.Log);
        }
    }
}
