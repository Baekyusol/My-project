using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        /*
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        */
        /*
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵��� ���߾����ϴ�.");
        */

        /*
        if (Input.anyKeyDown)
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");
        */

        /*
        if (Input.GetButtonDown("Jump"))
            Debug.Log("����!");

        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!");
        */

        /*
        if (Input.GetButton("Horizontal"))
        {
            //�߰� ��
            //Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));
            //�� ��
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));
        }

        if (Input.GetButton("Vertical"))
        {
            //�߰� ��
            //Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Vertical"));
            //�� ��
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Vertical"));
        }
        */

        /*
        void Start()
        {
            
        }

        void Update()
        {
            //Vector3 vec = new Vector3(0, 1f, 0); //���Ͱ�
            Vector3 vec = new Vector3(
                //GetAxis(~~)�� �ϸ� õõ�� ������
                Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical"),
                0);
            transform.Translate(vec);
        }
        */

        // ��ŸŸ��
        void Start()
        {

        }

        void Update()
        {
            //Vector3 vec = new Vector3(0, 1f, 0); //���Ͱ�
            Vector3 vec = new Vector3(
                //GetAxis(~~)�� �ϸ� õõ�� ������
                Input.GetAxisRaw("Horizontal") * Time.deltaTime,
                Input.GetAxisRaw("Vertical") * Time.deltaTime,
                0);
            transform.Translate(vec);
        }


    }
    
}
