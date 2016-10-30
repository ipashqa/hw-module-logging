using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MSUtil;

namespace LogReader
{
    class LogReader
    {
        private string _logFileName = @"..\..\..\MvcMusicStore\logs\2016-10-30.log";

        private LogQueryClass _logQuery;
        private COMTSVInputContextClass _input;

        public LogReader()
        {
            _logQuery = new LogQueryClass();

            //_input = new COMTSVInputContextClass();
            //_input.headerRow = false;
        }
    }
}
