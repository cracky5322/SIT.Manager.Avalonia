﻿using System;

namespace SIT.Manager.Avalonia.Classes
{
    public class ValidationRule
    {
        public string Name { get; init; } = string.Empty;
        public Func<bool>? Check { get; init; } = null;
        public string ErrorMessage { get; init; } = string.Empty;
    }
}
