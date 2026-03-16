using UnityEngine;
///<summary>
/// Untiyちゃんの移動関係をコントロールしているプログラム
///</summary>

public class MainControl : MonoBehaviour
{
    private Animator amimator;
    private new Rigidbody rigidbody;
    /// <summary>
    /// 移動関数関係
    /// </summary>
    public float moveSpeed = 3;
    public float jumpForce = 5;
    private bool isGround = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        amimator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //A/D
        float v = Input.GetAxis("Vertical"); //W/S

        //移動処理
        Vector3 move = new Vector3(h, 0, v) * moveSpeed * Time.deltaTime;
        transform.Translate(move);

        //アニメーション制御

        float Speed = new Vector2(h, v).magnitude;
        amimator.SetFloat("Speed", Speed);
        amimator.SetFloat("Direction", h);

        //ジャンプ操作
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            amimator.SetBool("jump", true);
            isGround = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            amimator.SetBool("jump", false);
        }
    }
}
