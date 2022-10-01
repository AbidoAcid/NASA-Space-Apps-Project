using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] LayerMask playerLayer;

    public Animator animator;
    public Transform doorPoint;
    public float doorRange = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DoorMechanism();
    }

    public void DoorMechanism()
    {
        Collider2D[] checkForPlayer = Physics2D.OverlapCircleAll(doorPoint.position, doorRange, playerLayer);
        if (checkForPlayer.Length > 0)
        {
            animator.SetBool("Open", true);
            animator.SetBool("Close", false);
        } else
        {
            animator.SetBool("Close", true);
            animator.SetBool("Open", false);
        }
        
    }
    private void OnDrawGizmos()
    {
        if (doorPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(doorPoint.position, doorRange);
    }
}
