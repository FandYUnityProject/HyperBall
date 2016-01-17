/* -クラスの説明-
 * =======================================================
 *  HyperBall_Jump.cs
 *  作成日：2016/1/17
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ・HyperBallのジャンプ機能
 ========================================================== */
using UnityEngine;

public class HyperBall_Jump : MonoBehaviour {

    public float JumpPower = 1000.0f;

	void Update () {

        // 操作可能時にジャンプボタンでジャンプ
        if (Input.GetButtonDown("Jump") && Operation_Permission_Controll._isOperation_Permission) {
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(0, JumpPower, 0);
        }
	}
}
