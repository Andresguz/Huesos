using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
private float checkPointX, checkPointY;

        void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointX")!=0)
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("checkPointX"), PlayerPrefs.GetFloat("checkPointY")));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReachedCheckPoint(float x,float y)
    {
        PlayerPrefs.SetFloat("checkPointX",x);
        PlayerPrefs.SetFloat("checkPointY", y);
    }
}
