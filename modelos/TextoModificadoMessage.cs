using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.modelos
{
    public class TextoModificadoMessage : ValueChangedMessage<string>
    {
        public TextoModificadoMessage(string texto) : base(texto) { }
    }
}
