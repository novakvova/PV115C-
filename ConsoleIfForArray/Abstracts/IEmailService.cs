using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIfForArray.Abstracts
{
    //Відправити листа на пошту.
    public interface IEmailService
    {
        void Send(Message message);
    }
}
