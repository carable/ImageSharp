﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;

using Xunit;

namespace SixLabors.ImageSharp.Tests.Processing.Processors.Filters
{
    using SixLabors.ImageSharp.Processing.Filters;

    [GroupOutput("Filters")]
    public class BlackWhiteTest
    {
        [Theory]
        [WithTestPatternImages(48, 48, PixelTypes.Rgba32)]
        public void ApplyBlackWhiteFilter<TPixel>(TestImageProvider<TPixel> provider)
            where TPixel : struct, IPixel<TPixel>
        {
            provider.RunValidatingProcessorTest(ctx => ctx.BlackWhite());
        }
    }
}