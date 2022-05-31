using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    [SerializeField]
    private Transform controlGolpe;
    [SerializeField]
    private float radioGolpe;
    [SerializeField]
    private float damage;

    public Animator animator;
    private float contCooldown=5f;
    private float cont;
    private bool activo;
    private void Start()
    {
        activo = false;
        animator=GetComponent<Animator>();
    }
    private void Update()
    {
       // Debug.Log(cont);
        if (activo==true)
        {
            cont += 0.03f;
        }
        if (cont >= contCooldown)
        {
            cont = 0;
            activo=false;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
           
            CoolDown();
        }

    }
   public void CoolDown()
    {
        if (activo==false && cont ==0)
        {
            Golpe();
        }
        
      
    }
    public void Golpe()
    {
        activo = true;
        animator.SetTrigger("ataque");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controlGolpe.position, radioGolpe);
        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("enemigo"))
            {
                destroyEnemy enemy = colisionador.transform.GetComponent<destroyEnemy>();
                enemy.vida -= 20;
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controlGolpe.position,radioGolpe);
    }
}
