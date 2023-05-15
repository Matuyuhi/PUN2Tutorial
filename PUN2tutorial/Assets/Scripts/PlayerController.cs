using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly float speed = 3f;
    void Update()
    {
        Vector3 h = Input.GetAxis("Horizontal") * Vector2.right;
        Vector3 v = Input.GetAxis("Vertical") * Vector2.up;
        transform.Translate(
             (h + v) * (Time.deltaTime * speed)
        );
    }
}
