using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;
public class changeSkin : MonoBehaviour
{
    public SpriteResolver spriteResolver;
    void Start()
    {
        spriteResolver.SetCategoryAndLabel("head", "sombrero");
       // spriteResolver.SetCategoryAndLabel("torso", "1");
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    spriteResolver.SetCategoryAndLabel("head", "premium");
        //    //spriteResolver.SetCategoryAndLabel("torso", "2");
        //}
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    spriteResolver.SetCategoryAndLabel("head", "gorro");
        //    //spriteResolver.SetCategoryAndLabel("torso", "3");
        //}
    }

}
