using UnityEngine;
using System.Collections;

public class AddForcebyDashPlate : MonoBehaviour {

    Rigidbody Prb;
    GameObject Player;
    Vector3 PlateDir;
    public float AddSpeed = 1000.0f;

    void Start()
    {
        Prb = GameObject.Find("HyperBall").GetComponent<Rigidbody>();
        PlateDir = GetComponent<Transform>().up;
    }

    void OnTriggerEnter(Collider coll)
    {
        //DashPlate接触時に、HyperBallに推進力を与える
        if (coll.gameObject.tag == "Player")
        {
            DebugInfo_Manager.DebugInfo_Update("DashPlateに接触しました");
            Vector3 ToDirection = PlateDir * AddSpeed;
            Prb.AddForce(ToDirection);
            Debug.Log(ToDirection);
        }
    }
}
