using UnityEngine;

public class ForceManager : MonoBehaviour
{
    ObjectData obj;

    private const float g = 9.81f;      //Gravity
    private Vector3 forceGravity = Vector3.zero;

    private void Start()
    {
        obj = GameObject.Find("Sphere").GetComponent<ObjectData>();
        forceGravity = new Vector3(0, (-obj.m * g), 0);

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

}
