using System;

namespace SOLID.Commands
{
    public class CommandFactory
    {

        public static ICommand GetCommandByKey(char key)
        {
            return key switch
            {
                '+' => new AddCommand(),
                '-' => new SubCommand(),
                '*' => new MulCommand(),
                '/' => new DivCommand(),
                _ => throw new NotSupportedException($"Any operation for key [{key}] is not supported."),
            };
        }
    }
}