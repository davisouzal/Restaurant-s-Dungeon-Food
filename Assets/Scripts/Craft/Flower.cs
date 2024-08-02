using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float flowerHealth;
    [SerializeField] private Animator Anim;
    [SerializeField] private GameObject risePrefab;
    private bool isCut;

    public void OnHit()
    {
        flowerHealth--;

        Anim.SetTrigger("IsHit");
        if(flowerHealth <= 0)
        {
            Instantiate(risePrefab, transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f), transform.rotation);
            Anim.SetTrigger("cut");
            isCut = true;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item") && !isCut)
        {
            OnHit();
        }
    }
}
