/* -クラスの説明-
 * ==============================================================================
 *  ThirdPersonCameraController.cs
 *  作成者：http://kdey.cocolog-nifty.com/blog/2013/03/cameracontrolle.html#more
 *
 * 【機能】
 *  ・３人称視点のカメラ
 *  ・マウスの右ドラッグで視点変更
 ================================================================================ */

using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    public Transform MainCamera;
    public Vector3 Offset = new Vector3(0, 0, 0);   // プレイヤーとの距離（座標）
    public float Radius = 10.0f;                    // プレイヤーとの距離（半径）
    public float RotSpeed = 10.0f;                  // 視点の回転スピード
    public float RotHorizonSpeed = 140.0f;          // 視点の回転スピード
    public float AngX = 6, AngY = 0;               // カメラの角度

    private Transform myTrf;
    private float nAngX, nAngY;
    private float MousePosX, MousePosY, subRadius;
    private Vector3 CameraPos, initCameraPos, Center;

    // カメラの初期位置を設定
    void Start() {
        initCameraPos = new Vector3(0, 0, Radius);
        myTrf = transform;
        MainCamera.position = myTrf.position + Offset + initCameraPos;
    }

    // ３人称カメラの移動・回転処理
    void LateUpdate()
    {
        Center = myTrf.position + Offset;

        // 右クリックでカメラ回転開始
        if (Input.GetMouseButtonDown(1)) {
            MousePosX = Input.mousePosition.x;
            MousePosY = Input.mousePosition.y;
            nAngX = AngX;
            nAngY = AngY;
        }

        // 右ドラッグでカメラ回転
        if (Input.GetMouseButton(1)) {
            AngY = nAngY - (MousePosX - Input.mousePosition.x) / 5.0f;
            AngX = nAngX + (MousePosY - Input.mousePosition.y) / 5.0f;
        }

        if (Input.GetKey(KeyCode.Q)) {
            // Qキーでカメラを左回転
            AngY = AngY - 10.0f * Time.deltaTime * RotSpeed;
        } else if (Input.GetKey(KeyCode.E)) {
            // Eキーでカメラを右回転
            AngY = AngY + 10.0f * Time.deltaTime * RotSpeed;
        } else if(Input.GetAxis("Horizontal") != 0) {
            // 左右キーでカメラを回転
            AngY += RotHorizonSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        }
        AngX = Mathf.Clamp(AngX, 0.0f, 89.999f);

        // カメラの中心（プレイヤー）との距離を測る
        float dist = Vector3.Distance(MainCamera.position, Center);
        RaycastHit RayHit;
        if (Physics.Raycast(Center, CameraPos, out RayHit, dist, 1 << 8)) {
            subRadius = RayHit.distance + 0.5f;
            initCameraPos = new Vector3(0, 0, -subRadius);
            if (Radius <= subRadius) {
                initCameraPos = new Vector3(0, 0, -Radius);
            }
        } else {
            if (Radius >= subRadius) {
                subRadius = subRadius + 20.0f * Time.deltaTime;
                initCameraPos = new Vector3(0, 0, -subRadius);
            } else {
                initCameraPos = new Vector3(0, 0, -Radius);
            }
        }

        // マウスホイールでカメラの拡大・縮小
        if (Input.GetAxis("Mouse ScrollWheel") != 0) {
            Radius = Radius + Input.GetAxis("Mouse ScrollWheel") *
                Time.deltaTime * 500;
            Radius = Mathf.Clamp(Radius, 3.0f, 30.0f);
        }

        // カメラのポジションを反映
        CameraPos = Quaternion.AngleAxis(AngY, Vector3.up) * Quaternion.AngleAxis(AngX, Vector3.right) * initCameraPos;
        MainCamera.position = Center + CameraPos;
        MainCamera.LookAt(Center);
    }
}