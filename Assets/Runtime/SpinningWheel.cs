using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinningWheel : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Rotations per second")]
    private float speed = 1; //

    [SerializeField]
    private Image image;

    void Update()
    {
        var angle = -Time.deltaTime * 360.0f * speed;
        image.transform.Rotate(Vector3.forward, angle);
    }
}
