using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody[] wheels = new Rigidbody[4]; // Rigidbody �迭�� ����
    public float torque = 200;  // ȸ����

    void Start()
    {
        // Rigidbody ������Ʈ�� ã�� �迭�� �Ҵ�
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
                // Rigidbody�� ��ũ�� ����
                wheels[i].AddRelativeTorque(Vector3.forward * torque);
            }
        }
    }
}
