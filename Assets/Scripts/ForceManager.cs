using UnityEngine;

public class ForceManager : MonoBehaviour //Have button example that fill fields with deafult values;
{
    ObjectData obj;
    FluidData fluid;

    private const float g = 9.81f;      //Gravity
    private Vector3 forceGravity = Vector3.zero;
    float d;



    private void Start()
    {
        obj = GameObject.Find("Sphere").GetComponent<ObjectData>();
        forceGravity = new Vector3(0, (-obj.m * g), 0);
        d = (Mathf.PI/2) * fluid.fluidDensity * (obj.r * obj .r);
    }

    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    private void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            // execute block of code here
            obj.UpdatePosition();
        }
    }

    

    private Vector3 dragForce()
    {
        // return -d * fluid.dragCoefficient;
        return new Vector3();
    } 

}
