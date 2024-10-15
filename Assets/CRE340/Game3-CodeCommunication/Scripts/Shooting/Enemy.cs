using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Enemy : MonoBehaviour, IDamagable
{
    public int health = 10;
    private Material mat;
    private Color originalColor;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
        originalColor = mat.color;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        ShowHitEffect();

        if (health <= 0)
        {
            Die(); // Call die method when health reaches zero
        }
    }

    public void ShowHitEffect()
    {
        mat.color = Color.red; // Flash red to show hit effect
        Invoke("ResetMaterial", 0.1f);
    }

    private void ResetMAterial()
    {
        mat.color = originalColor;
    }

    private void Die()
    {
        // Optional: add logic like playing an animation or droping loot
        Destroy(gameObject); // Destroy enemy object
    }
}
