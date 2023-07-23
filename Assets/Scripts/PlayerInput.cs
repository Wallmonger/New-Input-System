using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public void OnLeft()
    {
        transform.position += Vector3.left;
    }

    public void OnRight()
    {
        transform.position += Vector3.right;
    }

    public void OnUp()
    {
        transform.position += Vector3.forward;
    }

    public void OnDown ()
    {
        transform.position += Vector3.back;
        // b2*8
    }
}
