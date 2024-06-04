using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>(); //애니메이터 가져오기
    }
    private void Start ()
   {
   }

    public void Damage(GameObject attacker, Fist causer)
    {
        animator.SetTrigger("Damaged");

        return;
    }

    

    
}