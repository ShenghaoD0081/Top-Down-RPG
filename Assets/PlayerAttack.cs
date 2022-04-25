using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerAttack : MonoBehaviour
{
    public Vector3 screen;
    public Camera cam;
    Rigidbody2D rb;
    public GameObject bullet;
    public Transform firePoint;
    public Rigidbody2D bulletRigidBody;
    public float fireForce;
    public GameObject winMenu;

    public static Vector3 GetMouseWorldPosition(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }
    private void faceMouse()
    {
        Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

    }
    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(bullet, rb.position, firePoint.rotation);                                                
            projectile.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        screen = Input.mousePosition;
        faceMouse();
        Shoot();
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            winMenu.SetActive(true);
        }
    }
}
