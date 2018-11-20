using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSmoothLook : MonoBehaviour {

    // Inputs the camera
    public Camera theCamera;
    // Smoothing prevents the character looking at a strange pace
    public float smoothing = 5.0f;
    // Adjusts the angle to keep the player facing the mouse
    public float adjustmentAngle = 0.0f;

    // Update is called once per frame
    void Update()
    {
        print("MouseSmoothLook - Update");

        Vector3 target = theCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 difference = target - transform.position;
        difference.Normalize();
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        Quaternion newRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle));
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing);

    }
}
