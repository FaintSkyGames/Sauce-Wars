using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    // Variables which can be changed manually in unity.
    public float velocidadMax = 0.02f;
    public float xMax;
    public float yMax;
    public float xMin;
    public float yMin;

    // Variables that hold the transformation for each axis.
    private float x;
    private float y;

    // Use this for initialization
    void Start()
    {
        float maxrange = 0.5f;
        float minrange = 0.0f;
        velocidadMax = Random.Range(minrange, maxrange);
        x = Random.Range(-velocidadMax, velocidadMax);
        y = Random.Range(-velocidadMax, velocidadMax);
    }

    // Update is called once per frame
    // When the target hits the boundries it will change direction
    // If the target is within the boundries the code will not enter an if statement
    // The previous x & y values will be used
    void Update()
    {

        // If the transformation is greater than the max x boundry
        if (transform.localPosition.x > xMax)
            x = Random.Range(-velocidadMax, 0.0f);

        // If the transformation is less than the min x boundry
        if (transform.localPosition.x < xMin)
            x = Random.Range(0.0f, velocidadMax);

        // If the transformation is greater than the max y boundry
        if (transform.localPosition.y > yMax)
            y = Random.Range(-velocidadMax, 0.0f);

        // If the transformation is less than the min y boundry
        if (transform.localPosition.y < yMin)
            y = Random.Range(0.0f, velocidadMax);

        // Adjust the position based off the current position and the random values
        transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y + y, transform.localPosition.z);
    }
}
