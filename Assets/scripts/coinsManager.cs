using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsManager : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Transform initial;
    public GameObject coinPrebafb;
    public Camera cam;

    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
    }
    IEnumerator MoveCoin(Transform obj, Vector3 starPos,Vector3 endPos)
    {
        float time =0;
        while (time < 1)
        {
            time+= speed *Time.deltaTime;   
           obj.position =Vector3.Lerp(starPos,endPos, time);
            yield return new WaitForEndOfFrame();
        }
        yield return null;
    }
    // Update is called once per frame
  public void SartCoinMove(Vector3 _initial)
    {
       // Vector3 initialPos =cam.ScreenToViewportPoint(new Vector3(initial.position.x,initial.position.y,cam.transform.position.z*-1));
        Vector3 TargetPos =cam.ScreenToViewportPoint(new Vector3(target.position.x,target.position.y,cam.transform.position.z*-1));
        GameObject _coin = Instantiate(coinPrebafb, transform);

        StartCoroutine(MoveCoin(_coin.transform, _initial, TargetPos));
    }
}
