using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>(); //�ִϸ����� ��������
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