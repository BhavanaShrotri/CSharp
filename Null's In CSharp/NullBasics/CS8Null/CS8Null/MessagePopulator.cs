using System;
using System.Collections.Generic;
using System.Text;

namespace CS8Null
{
    class MessagePopulator
    {
        public static void Populate(Message message)
        {
            message.GetType().InvokeMember("From", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public
            | System.Reflection.BindingFlags.SetProperty, Type.DefaultBinder,
            message, new[] { "Jason (set using reflection)" });
        }
    }
}
