using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateControl : MonoBehaviour
{
    [SerializeField] private Transform attackPoint;
    [SerializeField] private float radius;
    [SerializeField] private LayerMask playerLayer;

    private AnimationPlayer player;
    private Animator anim;
    private Slime slime;
    [SerializeField] private GameObject slimePrefab;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        player = FindObjectOfType<AnimationPlayer>();
        slime = GetComponentInParent<Slime>();
    }

    // Update is called once per frame
    public void PlayAnim(int value)
    {
        anim.SetInteger("transition", value);
    }

    public void Attack()
    {
        if (!slime.isDead)
        {
            Collider2D hit = Physics2D.OverlapCircle(attackPoint.position, radius, playerLayer);

            if (hit != null)
            {
                player.OnHit();
            }
        }
       

    }
    public void OnHit()
    {
        
        if(slime.currentHealth <=   0)
        {
            slime.isDead = true;
            Instantiate(slimePrefab, transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f), transform.rotation);
            anim.SetTrigger("Die");

            Destroy(slime.gameObject, 1f);
        }
        else
        {
            anim.SetTrigger("Hit");
            slime.currentHealth--;

            slime.healthBar.fillAmount = slime.currentHealth / slime.totalHealth;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, radius);
    }
}
