﻿namespace SIT.Manager.Avalonia.Models
{
    public struct TarkovEdition(string edition, string? description = null)
    {
        private readonly string _description = description ?? string.Empty;
        public string Edition { get; } = edition;
        public readonly string Description => _description;
    }
}