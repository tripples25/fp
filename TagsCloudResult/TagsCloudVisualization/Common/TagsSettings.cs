﻿using System.ComponentModel;
using System.Drawing;

namespace TagsCloudVisualization.Common;

public record TagsSettings
{
    [TypeConverter(typeof(FontConverter.FontNameConverter))]
    public string Font { get; init; } = "Arial";
    public int FontSize { get; init; } = 42;
    public Color PrimaryColor { get; init; } = Color.Yellow;
    public Color SecondaryColor { get; init; } = Color.Red;
    public Color TertiaryColor { get; init; } = Color.Aquamarine;
    public Color BackgroundColor { get; init; } = Color.DarkBlue;
}