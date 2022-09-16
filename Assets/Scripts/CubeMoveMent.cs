using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoveMent : MonoBehaviour
{
    public Rigidbody cube_Rb;
    private Joystick joyStick;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        joyStick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();
    }

    void MoveCube()
    {
        Vector3 dir = new Vector3(joyStick.Direction.x, 0, joyStick.Direction.y);
        cube_Rb.velocity = dir * moveSpeed;
    }
}
