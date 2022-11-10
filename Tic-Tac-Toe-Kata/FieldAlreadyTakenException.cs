using System;

namespace Tic;

public class FieldAlreadyTakenException : Exception
{
    public FieldAlreadyTakenException(string message) : base(message) {}
}