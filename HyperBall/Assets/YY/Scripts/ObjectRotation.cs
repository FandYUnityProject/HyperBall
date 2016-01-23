/* -クラスの説明-
 * =======================================================
 *  ObjectRotation.cs
 *  作成日：2016/1/21
 *  作成者：Yamaguchi Yohei
 *
 * 【機能】
 *  Inspectorで指定したスピードでオブジェクトを回転させる
 ========================================================== */

using UnityEngine;

public class ObjectRotation : MonoBehaviour {

    private float _ObjRotation_X = 0;
    private float _ObjRotation_Y = 0;
    private float _ObjRotation_Z = 0;

    public float X軸の回転スピード = 0;
    public float Y軸の回転スピード = 0;
    public float Z軸の回転スピード = 0;

    void Update() {

        // オブジェクトを回転
        if (Operation_Permission_Controll._isOperation_Permission) {

            _ObjRotation_X = X軸の回転スピード;
            _ObjRotation_Y = Y軸の回転スピード;
            _ObjRotation_Z = Z軸の回転スピード;

            transform.Rotate(_ObjRotation_X, _ObjRotation_Y, _ObjRotation_Z);
        }
    }
}
