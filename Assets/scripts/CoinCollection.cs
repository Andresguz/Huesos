using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CoinCollection : MonoBehaviour
{
    public float speed;
    public Transform target;
   // public Transform initial;
    public GameObject coinPrefab;
    public Camera cam;
    void Start()
    {
        if (cam== null)
        {
            cam = Camera.main;
        } 
    }
    private void Update()
    {
        
    }
    public void StartCoinMove(Vector3 _intial,Action onComplete)
    {
        //Vector3 initialPos = cam.ScreenToViewportPoint(new Vector3(_intial.x, _intial.y, cam.transform.position.z*-1));
        Vector3 targetPos = cam.ScreenToWorldPoint(new Vector3(target.position.x, target.position.y, cam.transform.position.z*-1));
        GameObject _coin = Instantiate(coinPrefab,transform);

        StartCoroutine(MoveCoin(_coin.transform, _intial, targetPos, onComplete));
    }
   IEnumerator MoveCoin(Transform obj, Vector3 starPosition,Vector3 endPos, Action onComplete)
    {
        float time = 0;
        while (time < 1)
        {
            time += speed *Time.deltaTime;
            obj.position = Vector3.Lerp(starPosition, endPos, time);

            yield return new WaitForEndOfFrame();
        }
        onComplete.Invoke();
        Destroy(obj.gameObject);
    }
}
