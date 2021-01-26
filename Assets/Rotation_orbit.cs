using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_orbit : MonoBehaviour
{   
    public Collider2D satelite;
    public Transform satTransform;
    public float density;
    private float rotationSpeed;
    public float dampAmount;
    public bool invertedRotation = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    float mass()
    {
        double p;
        double m = satelite.bounds.size.x * density;
        double g = 6.674 * Mathf.Pow(10, -11);

        p = m * g;

        return (float) p;
    }

    float getDist(Vector3 a, Vector3 b)
    {
        float result = 0;

        result = Mathf.Sqrt(Mathf.Pow(a.x - b.x, 2) + Mathf.Pow(a.y - b.y, 2));

        return result;
    }

    // Update is called once per frame
    void Update()
    {
        //Speed = racine de (G + Masse A/ Distance )
        rotationSpeed = Mathf.Sqrt(((float) 6.67 * Mathf.Pow(10, -11) + mass()) / getDist(satTransform.position, new Vector3(0, 0, 0)));
        rotationSpeed = rotationSpeed * Mathf.Pow(10,6);
        if (invertedRotation == false) {
            transform.Rotate((Vector3.forward * rotationSpeed) * (Time.deltaTime * dampAmount), Space.Self);
        } else {
            transform.Rotate((Vector3.forward * rotationSpeed * -1) * (Time.deltaTime * dampAmount), Space.Self);
        }
    }

    public void setRotation(bool inverted)
    {
        invertedRotation = inverted;
    }
}