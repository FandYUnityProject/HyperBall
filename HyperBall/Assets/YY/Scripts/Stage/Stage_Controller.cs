/* -クラスの説明-
 * =======================================================
 *  Stage_Controller.cs
 *  作成日：2016/1/17
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  ・カメラ方向に応じてステージを傾ける
 ========================================================== */

using UnityEngine;

public class Stage_Controller : MonoBehaviour {

    public float 最大傾き角度 = 8.0f;
    Vector3 moveDirection;

    void Start() {
        Physics.gravity = new Vector3(0, -100.0f, 0);
    }

    // カメラの向きに応じて入力方向を変更
    void FixedUpdate() {
        Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward); //移動速度を定義
        Vector3 right = Camera.main.transform.TransformDirection(Vector3.right);     //正面方向を取得
        moveDirection = Input.GetAxis("Horizontal") * -forward + Input.GetAxis("Vertical") * right; //横方向を取得
        moveDirection.y = 0; //入力値を掛けて最終的な入力方向を決定。
    }

    // 操作可能時、傾き反映
    void Update() {
        if (Operation_Permission_Controll._isOperation_Permission) {
            transform.rotation = Quaternion.Euler(moveDirection * 最大傾き角度);
        }
    }
}
