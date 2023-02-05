using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.modelos
{
    class TextRequestMessage :  RequestMessage<string>
    {
    }

    public class EnviarNombre : RequestMessage<string> { }

    public class EnviarEdad : RequestMessage<int> { }

    public class EnviarPais : RequestMessage<string> { }

    public class SendNameSelect : RequestMessage<string> { }

    public class SendAgeSelect : RequestMessage<int> { }

    public class SendCountrySelect : RequestMessage<string> { }
}
