using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody[] wheels = new Rigidbody[4]; // Rigidbody 배열로 변경
    public float torque = 200;  // 회전힘

    void Start()
    {
        // Rigidbody 컴포넌트를 찾아 배열에 할당
        for (int i = 0; i < wheels.Length; i++)
        {
            wheels[i] = transform.GetChild(i).GetComponent<Rigidbody>();
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            for (int i = 0; i < wheels.Length; i++)
            {
                // Rigidbody에 토크를 적용
                wheels[i].AddRelativeTorque(Vector3.forward * torque);
            }
        }
    }
}
