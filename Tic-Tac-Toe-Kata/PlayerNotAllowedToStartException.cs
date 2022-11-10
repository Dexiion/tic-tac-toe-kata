using System;

namespace Tic;

public class PlayerNotAllowedToStartException : Exception
{
    public PlayerNotAllowedToStartException(string message) : base(message) {}
}