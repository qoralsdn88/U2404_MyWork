using UnityEngine;

public partial class Player
{
    private bool bAttacking = false;

   private void UpdateAttacking() 
    {
        if (Input.GetButtonDown("Attack") == false)
            return;

        if (bAttacking == true)
            return;

        bCanMove = false;

        bAttacking = true;
        //animator.SetTrigger("Attack");
        animator.SetBool("IsAttacking", true);

    }

    private void End_Attack()
    {
        bCanMove = true;
        bAttacking = false;
        animator.SetBool("IsAttacking", false);

    }
}