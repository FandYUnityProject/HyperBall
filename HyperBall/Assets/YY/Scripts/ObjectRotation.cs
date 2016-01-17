using UnityEngine;

public class ObjectRotation : MonoBehaviour {

    private float _ObjRotation = 0;

    void Update() {
        _ObjRotation += Time.deltaTime;
        transform.Rotate(0, 0, _ObjRotation);
    }
}
