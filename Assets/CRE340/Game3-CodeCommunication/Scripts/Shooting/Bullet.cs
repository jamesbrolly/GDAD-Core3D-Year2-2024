
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1; // the amount of damage the bullet deals

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        // Stop the bullet's movement and enable gravity
        rb.velocity = Vector3.zero;
        rb.useGravity = true;
        
        //check if the bullet hit something that has the 'IDamagable' interface   (Modify this script here to check if the object has the 'IDamagable' interface and call the 'TakeDamage' and ShowHitEffect method)
        if (collision.gameObject.GetComponent<IDamagable>() !=null)
        {
            //get the IDamagable Interface from the collider object
            IDamagable damageable = collision.gameObject.GetComponent<IDamagable>();

            //Call the IDamagable interface to ake damage and show hit effect
            damageable.TakeDamage(damage);
            damageable.ShowHitEffect();

        }

        //Destroy the bullet after it collides with an object
        Destroy(gameObject);

    }
}