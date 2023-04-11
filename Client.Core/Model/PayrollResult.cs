﻿using System;

namespace PayrollEngine.Client.Model;

/// <summary>The payroll result info client object</summary>
public class PayrollResult : Model, IPayrollResult, IEquatable<PayrollResult>
{
    /// <inheritdoc/>
    public int PayrollId { get; set; }

    /// <inheritdoc/>
    public int PayrunId { get; set; }

    /// <inheritdoc/>
    public int PayrunJobId { get; set; }

    /// <inheritdoc/>
    public string PayrunJobName { get; set; }

    /// <inheritdoc/>
    public int EmployeeId { get; set; }

    /// <inheritdoc/>
    public string EmployeeIdentifier { get; set; }

    /// <inheritdoc/>
    public int DivisionId { get; set; }

    /// <inheritdoc/>
    public string CycleName { get; set; }

    /// <inheritdoc/>
    public DateTime CycleStart { get; set; }

    /// <inheritdoc/>
    public DateTime CycleEnd { get; set; }

    /// <inheritdoc/>
    public string PeriodName { get; set; }

    /// <inheritdoc/>
    public DateTime PeriodStart { get; set; }

    /// <inheritdoc/>
    public DateTime PeriodEnd { get; set; }

    /// <summary>Initializes a new instance</summary>
    public PayrollResult()
    {
    }

    /// <summary>Initializes a new instance from a copy</summary>
    /// <param name="copySource">The copy source</param>
    public PayrollResult(PayrollResult copySource) :
        base(copySource)
    {
        CopyTool.CopyProperties(copySource, this);
    }

    /// <summary>Compare two objects</summary>
    /// <param name="compare">The object to compare with this</param>
    /// <returns>True for objects with the same data</returns>
    public virtual bool Equals(PayrollResult compare) =>
        CompareTool.EqualProperties(this, compare);

    /// <summary>Returns a <see cref="string" /> that represents this instance</summary>
    /// <returns>A <see cref="string" /> that represents this instance</returns>
    public override string ToString() =>
        $"result: {PeriodName} for employee {EmployeeId} on division {DivisionId} {base.ToString()}";
}