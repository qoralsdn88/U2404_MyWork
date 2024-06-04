using UnityEditor.Experimental.GraphView;
using UnityEngine;

public partial class Player : MonoBehaviour
{
    [SerializeField] 
    private float walkSpeed = 2.0f;

    [SerializeField]
    private float runSpeed = 4.0f;

    private Animator animator; // Animator 객체 가져오기




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
    private void UpdateMoving() // 플레이어 이동 함수
    {
        if (bCanMove == false) // 플레이어가 움직일 수 없으면 실행 중지
            return;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        bool bRun = Input.GetButton("Run"); // 눌렸는지 아닌지 bool로 판단

        float speed = bRun ? runSpeed : walkSpeed; //bRun이 true면 달리는 속도, 아니면 걷는 속도
        
        
        direction = (Vector3.forward * vertical) + (Vector3.right * horizontal); //움직이는 방향 초기화
        direction = direction.normalized * speed; // 방향 벡터 정규화해주고 속도 곱하기

        transform.Translate(direction * Time.deltaTime); //이 값으로 위치 변환
        
        animator.SetInteger("SpeedZ", (int)direction.magnitude); // 현재 속도로 애니메이션 blend treed에 반영
    }
}