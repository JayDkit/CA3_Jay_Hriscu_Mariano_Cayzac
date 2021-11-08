using UnityEngine;

public class EulerMethod
{
    public Vector3[] position;
    public Vector3[] apparentVelocity;
    public float[] modularVa;
    public Vector3[] velocity;
    public Vector3 wind;

    public Vector3[] acceleration;

    public float time;
    public float finalTime;
    public int h;
    private float gravity;

    EulerMethod(Vector3 pos, Vector3 vel, Vector3 w, int t, int fTime, int pH, float g)
    {
        position[0] = pos;
        velocity[0] = vel;
        wind = w;
        time = t;
        h = pH;
        finalTime = fTime;
        gravity = g;
    }

    void execute()
    {
        //Step 0
        apparentVelocity[0] = velocity[0] - wind;
        modularVa[0] = Mathf.Sqrt(
               (apparentVelocity[0].x * apparentVelocity[0].x)
               + (apparentVelocity[0].y * apparentVelocity[0].y)
               + (apparentVelocity[0].z * apparentVelocity[0].z));
        acceleration[0] = calcAcc(apparentVelocity[0], modularVa[0]);

        int n = 1; //Next steps
        for (float i = time + h; i <= finalTime; i+= h)
        {

            position[n] = position[n - 1] + h * velocity[n - 1];
            velocity[n] = velocity[n - 1] + h * acceleration[n - 1];

            apparentVelocity[n] = velocity[n] - wind;
            modularVa[n] = Mathf.Sqrt(
                   (apparentVelocity[n].x * apparentVelocity[n].x)
                   + (apparentVelocity[n].y * apparentVelocity[n].y)
                   + (apparentVelocity[n].z * apparentVelocity[n].z));

            acceleration[n] = calcAcc(apparentVelocity[n], modularVa[n]);
            n++;
        }
    }

    private Vector3 calcAcc(Vector3 appV, float modV)
    {
        return new Vector3(0, -gravity, 0) - 0.1f * modV * appV;
    }

}
