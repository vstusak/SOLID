using System;

namespace SOLID
{
    public class InvalidOperationResult : IOperationResult
    {
        public int Value => throw new NotImplementedException();

        public string Description { get; set; }
    }

}
