using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraAxis : MonoBehaviour
    {
    // Start is called before the first frame update
    private Vector3 offset;      //距離取得用
    public GameObject Player;
    void Start()
        {
        // MainCamera(自分自身)とplayerとの相対距離を求める
        offset = transform.position - Player.transform.position;

        }

    // Update is called once per frame
    void Update()
        {

        //新しいトランスフォームの値を代入する
        transform.position = Player.transform.position + offset;

        }
    }
