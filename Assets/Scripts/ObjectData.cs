using UnityEngine;

/// <summary>
/// This script is used to define the object data and to change data at runtime
/// </summary>
public class ObjectData : MonoBehaviour
{
    public Vector3 pos = Vector3.zero;                   //Position of object
    public uint m = 1;                                   //Mass
    public float r = 1.0f;                               //Radius
    public uint objDensity = 0;                          //Density of object
    public Vector3 objVelocity = Vector3.zero;           //Velocity of object
    public bool isSpinning = false;                      //Is the object spinning
    public Vector3 objSpin = Vector3.zero;               //Pseudo Vector

    private void Start()
    {
        gameObject.transform.position = pos;
        gameObject.transform.localScale = new Vector3(r*2, r*2, r*2);
    }

    public void UpdatePosition()
    {
        gameObject.transform.position = pos;
    }
}
