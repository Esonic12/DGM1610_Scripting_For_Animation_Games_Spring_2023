using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Stats")]
    public float moveSpeed;
    public float jumpForce;
    public int curHp;
    public int maxHp;

    [Header("Mouse Look")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;

    private Camera camera;
    private Rigidbody rb;
    //private Weapon weapon;

    void Awake()
    {
        //weapon = GetComponent<Weapon>();
        curHp = maxHp;
    }

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();

        /*
        GameUI.instance.UpdateHealthBar(curHp, maxHp);
        GameUI.instance.UpdateScoreText(0);
        GameUI.instance.UpdateAmmoText(weapon.curAmmo, weapon.maxAmmo); */
    }

    public void TakeDamage(int damage)
    {
        curHp -= damage;

        if(curHp <= 0)
            Die();
        
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        // Move direction relative to camera
        Vector3 dir = transform.right * x + transform.forward * z;

        dir.y = rb.velocity.y;
        rb.velocity = dir;
    }

    void CamLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;

        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void Die()
    {
        //GameManager.instance.LoseGame();
        Debug.Log("Player has died! Game Over!");
        Time.timeScale = 0;
    }

    public void GiveHealth(int amountToGive)
    {
        //curHp = Mathf.Clamp(curHp + amountToGive, 0, maxHp);
        //GameUI.instance.UpdateHealthBar(CurHp, maxHp);
        Debug.Log("Player has been healed!");
    }

    public void GiveAmmo(int amountToGive)
    {
        //weapon.curAmmo = Mathf.Clamp(weapon.curAmmo + amountToGive, 0, weapon.maxAmmo);
        //GameUI.instance.UpdateAmmoText(weapon.curAmmo, weapon.maxAmmo);
        Debug.Log("Player has collected ammo!");
    }

    // Update is called once per frame
    void Update()
    {
       Move();
       CamLook(); 
       
       if(Input.GetKeyDown(KeyCode.Space))
       {
        Jump();
       }
    }
}
