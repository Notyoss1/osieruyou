using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;//��Speed�Ƃ�������������n�R�����

    void Update()
    {
        if(Input.GetKey("w"))
        {                                      //    X    Y  Z �@�̑�������ʂ��w�肷��
            this.transform.position += new Vector3(speed, 0, 0);
        }                                      �@//������X�̑����ʂ�7�s�ڂō����speed�Ƃ����n�R���w�肷��

        if (Input.GetKey("s"))
        {
            this.transform.position += new Vector3(speed * -1, 0, 0);
        }                                        //������speed�̃n�R�̒��̐����� -1���|���邱�ƂŔ��̒��̐����𕉂̐��ɂł���

        if (Input.GetKey("a"))
        {
            this.transform.position += new Vector3(0, 0, speed);
        }

        if (Input.GetKey("d"))
        {
            this.transform.position += new Vector3(0, 0, speed * -1);
        }
    }
}