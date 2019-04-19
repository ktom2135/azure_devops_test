using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace azureDevOpsTestLiab
{
    public class AzureService
    {
        public bool SleepAndReturnTrue()
        {
            Thread.Sleep(500);

            return true;
        }
    }
}
