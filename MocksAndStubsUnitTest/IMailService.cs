using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocksAndStubsUnitTest
{
    public interface IMailService
    {
        void SendMail(string destination, string message);
    }
}
