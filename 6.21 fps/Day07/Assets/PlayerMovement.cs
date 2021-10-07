using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //[SerializeField] : private로 설정된 아이들을 inspector 창에서 보여지게 만듬
    [SerializeField] private Animator ani;// animator 캐싱
    public float speed = 3f;
	// Use this for initialization
	void Awake()
    {
        ani = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        //전후 화살표, 위 max : 1f, 아래 max : -1f
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        //ani의 파라미터 중 Speed에 vertical 값 넣음
        ani.SetFloat("Speed", vertical);
        //transform.Translate : 정해진 방향으로 이동
        //vector3.forward : vector3(0f,0f,1f)
        //vertical : -1~1
        //time.deltaTime=0.02f;
        transform.Translate(Vector3.forward * vertical * Time.deltaTime * speed);
        //transform.rotate : 정해진 방향으로 회전
        //vector3.up : vector3(0f,1f,0f)
        //space.world : 축이 global 좌표 
        transform.Rotate(Vector3.up * horizontal, Space.World);
    }
}
