using UnityEngine;

public class ObjectRotation : MonoBehaviour {

    public float ObjRotationSpeed_X = 0.0f;
    public float ObjRotationSpeed_Y = 0.0f;
    public float ObjRotationSpeed_Z = 0.0f;

    void Update() {

        if (Operation_Permission_Controll._isOperation_Permission) {
            transform.Rotate(ObjRotationSpeed_X, ObjRotationSpeed_Y, ObjRotationSpeed_Z);
        }
    }
}
