﻿namespace SentryOne.UnitTestGenerator.Core.Options
{
    public interface IUnitTestGeneratorOptions
    {
        IGenerationOptions GenerationOptions { get; }

        IVersioningOptions VersioningOptions { get; }
    }
}