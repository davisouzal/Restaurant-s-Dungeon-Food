using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("HUD")]
    public float currentHealth;
    public Image healthBar;
    public float totalHealth;


    [SerializeField] private float speed;
    private Vector2 _direction;
    private Rigidbody2D rig;
    private float initialSpeed;
    private bool _isCutting;
    public bool isDead; 



    public Vector2 direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

    public bool IsCutting { get => _isCutting; set => _isCutting = value; }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = totalHealth;
        rig = GetComponent<Rigidbody2D>();
        initialSpeed = speed;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        OnMove();
    }
    void Update()
    {
        if (!isDead)
        {
            OnInput();
            OnCutting();

        }

    }

    #region movement

    void OnCutting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isCutting = true;
            speed = 0;

        }
        if (Input.GetMouseButtonUp(0))
        {
            _isCutting = false;
            speed = initialSpeed;
        }
    }
    void OnInput()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    void OnMove()
    {
        rig.MovePosition(rig.position + _direction * speed * Time.deltaTime);
    }


    #endregion
}

