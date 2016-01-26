/*-クラスの説明-
*===================================================
*HyperBall_TouchDashPlate_Obj.cs
*作成日：2016/1/26
*作成者：Fujita Yuto
*
*【機能】
*・DashPlate接触時に、HyperBallに推進力を与える
====================================================*/
using UnityEngine;
using System.Collections;

public class HyperBall_TouchDashPlate_Obj : MonoBehaviour {

    Rigidbody rb;
    public float AddSpeed = 1000.0f;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

	void OnTriggerEnter(Collider coll){
        //DashPlate接触時に、HyperBallに推進力を与える
        if(coll.gameObject.tag == "DashPlate"){
            DebugInfo_Manager.DebugInfo_Update("DashPlateに接触しました");
            rb.AddForce(0, 0, AddSpeed);
        }
    }
}
