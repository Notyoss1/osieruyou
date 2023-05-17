using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;//←Speedという数字が入るハコを作る

    void Update()
    {
        if(Input.GetKey("w"))
        {                                      //    X    Y  Z 　の増加する量を指定する
            this.transform.position += new Vector3(speed, 0, 0);
        }                                      　//↑↑↑Xの増加量は7行目で作ったspeedというハコを指定する

        if (Input.GetKey("s"))
        {
            this.transform.position += new Vector3(speed * -1, 0, 0);
        }                                        //↑↑↑speedのハコの中の数字に -1を掛けることで箱の中の数字を負の数にできる

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