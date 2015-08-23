/*
 ステージのUVを動かして、さも動いているように見せるクラス
 */

using UnityEngine;
using System.Collections;

public class moveUV : MonoBehaviour
{
    public GameObject gameObject;
    private Renderer rend;

    private float vecx = 0;
    private float vecy = 0;

    void Start()
    {
        //レンダラーからマテリアルにアクセスしないとうまく動かない模様　おのれUnity5
        this.rend = gameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        vecx = (vecx < 1) ? (vecx + 0.01f) : 0f;
        vecy = (vecy < 1) ? (vecy + 0.01f) : 0f;
        this.rend.material.SetTextureOffset("_MainTex", new Vector2(vecx, vecy));
    }
}
