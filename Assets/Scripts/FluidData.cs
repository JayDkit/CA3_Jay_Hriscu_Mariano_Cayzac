using UnityEngine;

/// <summary>
/// This script is used to define the fluid data and to change data at runtime
/// </summary>
public class FluidData
{
    public uint fluidDensity = 0;
    public float dragCoefficient = 0.0f;
    public Vector3 flowRate = Vector3.zero;
}
