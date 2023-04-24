﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PayrollEngine.Serialization;

namespace PayrollEngine.Client.Model;

/// <summary>Localized lookup for UI cases like list/grid selections</summary>
public class LookupData : ILookupData
{
    /// <inheritdoc/>
    [Required]
    [StringLength(128)]
    public string Name { get; set; }

    /// <inheritdoc/>
    [JsonConverter(typeof(StringNullableEnumConverter<Language?>))]
    public Language? Language { get; set; }

    /// <inheritdoc/>
    [Required]
    public LookupValueData[] Values { get; set; }

    /// <inheritdoc/>
    public decimal? RangeSize { get; set; }

    /// <summary>Initializes a new instance</summary>
    public LookupData()
    {
    }

    /// <summary>Initializes a new instance from a copy</summary>
    /// <param name="copySource">The copy source</param>
    public LookupData(ILookupData copySource)
    {
        CopyTool.CopyProperties(copySource, this);
    }

    /// <inheritdoc/>
    public virtual bool Equals(ILookupData compare) =>
        CompareTool.EqualProperties(this, compare);

    /// <summary>Returns a <see cref="string" /> that represents this instance</summary>
    /// <returns>A <see cref="string" /> that represents this instance</returns>
    public override string ToString() =>
        $"{Name} {base.ToString()}";
}