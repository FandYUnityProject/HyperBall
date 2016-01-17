using UnityEngine;
using System.Collections;

public class HyperBall_FreezePosition_Controll : MonoBehaviour {

    void Update () {
        // 移動許可時は回転・移動を固定しない
        if (Operation_Permission_Controll._isOperation_Permission) {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        } else {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
