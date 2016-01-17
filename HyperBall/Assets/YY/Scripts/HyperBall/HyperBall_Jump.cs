/* -クラスの説明-
 * =======================================================
 *  HyperBall_Jump.cs
 *  作成日：2016/1/17
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ・HyperBallのジャンプ
 ========================================================== */
using UnityEngine;

public class HyperBall_Jump : MonoBehaviour {

    public float JumpPower = 1000.0f;

	void Update () {
        if (Input.GetButtonDown("Jump")) {
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(0, JumpPower, 0);
        }
	}
}
