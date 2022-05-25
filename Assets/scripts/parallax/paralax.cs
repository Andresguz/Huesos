using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralax : MonoBehaviour
{
    [SerializeField]
    private float paralaxMultiple;
    private Transform cameraTransform;
    private Vector3 previusCameraPosition;
    private float spriteWidth,starPosition;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        previusCameraPosition = cameraTransform.position;
    //spriteWidth=GetComponent<SpriteRenderer>().bounds.size.x;
        starPosition = transform.position.x;
    }

    // cuanto se emovio
    void Update()
    {
        float deltaX= (cameraTransform.position.x - previusCameraPosition.x)* paralaxMultiple;
     //float amountPos=cameraTransform.position.x * (1-paralaxMultiple);
        transform.Translate(new Vector3(deltaX, 0, 0));
        previusCameraPosition= cameraTransform.position;

        //if (amountPos>starPosition+spriteWidth)
        //{
        //    transform.Translate(new Vector3(spriteWidth, 0, 0));
        //    starPosition+=spriteWidth;
        //}
        //else if (amountPos<starPosition-spriteWidth)
        //{
        //    transform.Translate(new Vector3(-spriteWidth, 0, 0));
        //    starPosition -= spriteWidth;
        //}
    }
}
