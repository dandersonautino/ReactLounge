using System;
using System.Collections.Generic;
using System.Text;

namespace Autino.Lounge.Services.Exceptions
{
    public class ChatException : Exception
    {
        public ChatException()
        {
        }

        public ChatException(string message)
            : base(message)
        {
        }

        public ChatException(string message, Exception inner)
            : base(message, inner)
        {
        }


    }
}
