﻿using System;
using System.Collections.Generic;

namespace PayrollEngine.Client.Model;

/// <summary>The payroll regulation set client object</summary>
public class RegulationSet : Regulation, IRegulationSet, IEquatable<RegulationSet>
{
    /// <inheritdoc/>
    public List<CaseSet> Cases { get; set; }

    /// <inheritdoc/>
    public List<CaseRelation> CaseRelations { get; set; }

    /// <inheritdoc/>
    public List<WageType> WageTypes { get; set; }

    /// <inheritdoc/>
    public List<Collector> Collectors { get; set; }

    /// <inheritdoc/>
    public List<LookupSet> Lookups { get; set; }

    /// <inheritdoc/>
    public List<Script> Scripts { get; set; }

    /// <inheritdoc/>
    public List<ReportSet> Reports { get; set; }

    /// <summary>Initializes a new instance</summary>
    public RegulationSet()
    {
    }

    /// <summary>Initializes a new instance from a copy</summary>
    /// <param name="copySource">The copy source</param>
    public RegulationSet(Regulation copySource) :
        base(copySource)
    {
    }

    /// <summary>Initializes a new instance from a copy</summary>
    /// <param name="copySource">The copy source</param>
    public RegulationSet(RegulationSet copySource) :
        base(copySource)
    {
        CopyTool.CopyProperties(copySource, this);
    }

    /// <summary>Compare two objects</summary>
    /// <param name="compare">The object to compare with this</param>
    /// <returns>True for objects with the same data</returns>
    public virtual bool Equals(RegulationSet compare) =>
        CompareTool.EqualProperties(this, compare);
}