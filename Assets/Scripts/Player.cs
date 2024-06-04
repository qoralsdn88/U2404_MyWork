using UnityEditor.Experimental.GraphView;
using UnityEngine;

public partial class Player : MonoBehaviour
{
    [SerializeField] 
    private float walkSpeed = 2.0f;

    [SerializeField]
    private float runSpeed = 4.0f;

    private Animator animator; // Animator ��ü ��������




   private void Start ()
   {
      animator = GetComponent<Animator>();
   }

    private void Update()
    {
        UpdateMoving();
        UpdateAttacking();
    }

    Vector3 direction;

    private bool bCanMove = true;
    private void UpdateMoving() // �÷��̾� �̵� �Լ�
    {
        if (bCanMove == false) // �÷��̾ ������ �� ������ ���� ����
            return;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        bool bRun = Input.GetButton("Run"); // ���ȴ��� �ƴ��� bool�� �Ǵ�

        float speed = bRun ? runSpeed : walkSpeed; //bRun�� true�� �޸��� �ӵ�, �ƴϸ� �ȴ� �ӵ�
        
        
        direction = (Vector3.forward * vertical) + (Vector3.right * horizontal); //�����̴� ���� �ʱ�ȭ
        direction = direction.normalized * speed; // ���� ���� ����ȭ���ְ� �ӵ� ���ϱ�

        transform.Translate(direction * Time.deltaTime); //�� ������ ��ġ ��ȯ
        
        animator.SetInteger("SpeedZ", (int)direction.magnitude); // ���� �ӵ��� �ִϸ��̼� blend treed�� �ݿ�
    }
}