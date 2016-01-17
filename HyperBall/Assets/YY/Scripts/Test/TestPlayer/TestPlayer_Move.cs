using UnityEngine;
using System.Collections;

public class TestPlayer_Move : MonoBehaviour {

    // speedを制御する
    public float speed = 10;

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(x * speed, 0, z * speed);
    }

    /*
    void OnCollisionEnter(Collision coll)
    {

    }

    void OnCollisionStay(Collision coll) {
        if (coll.gameObject.tag == "Gravity_Floor")
        {
            float CameraRotation_X;

            if (Mathf.Abs(coll.contacts[0].normal.x) > Mathf.Abs(coll.contacts[0].normal.z)){
                CameraRotation_X = coll.contacts[0].normal.x;
            } else {
                CameraRotation_X = coll.contacts[0].normal.z;
            }
            //transform.rotation = Quaternion.Euler(CameraRotation_X * 90, coll.transform.rotation.y, 0);
            //transform.rotation = Quaternion.Euler(1, coll.transform.rotation.y, 0);
            Physics.gravity = new Vector3(-coll.contacts[0].normal.x, -coll.contacts[0].normal.y, -coll.contacts[0].normal.z);
            Debug.Log(coll.contacts[0].normal);
        }
    }

    void OnCollisionExit(Collision coll)
    {
        if (coll.gameObject.tag == "Gravity_Floor")
        {
            //transform.rotation = Quaternion.Euler(0,0,0);
            //Physics.gravity = new Vector3(0, -9.8f, 0);
        }
    }
    */
}
