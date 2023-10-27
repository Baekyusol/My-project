using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity = Vector3.right;
        //rigid.velocity = Vector3.left;
        rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        //rigid.velocity = new Vector3(2, 4, -1);
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical")
            );
        rigid.AddForce (vec, ForceMode.Impulse); //�� ������

        //ȸ����
        rigid.AddTorque(Vector3.back); // .up = vec�� ������ �ϰ� ���ư�
        */

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);

    }
    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
