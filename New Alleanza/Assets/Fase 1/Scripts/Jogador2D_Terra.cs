using UnityEngine;

public class Jogador2D_Terra : MonoBehaviour
{
    private Rigidbody2D rig;
    private Camera visaoAtaque;

    public bool CamSeguindo = true;
    public Vector3 destinoCam;

    public GameObject mochila, mochilaInteracao;
    public GameObject mapa, mapaInteracao;
    public float distanciaMochila, distanciaMapa;

    [Header("Movimento")]
    [SerializeField] int velocidade;
    [SerializeField] float velocidadeDash, pulo;
    [SerializeField] Vector2 destino;
    [SerializeField] Vector2 move;
    [SerializeField] bool DashAtivado = false;
    //[SerializeField] bool canJump = false;

    [Header("Animação")]
    Animator anima;
    float xMove, yMove;

    //[Header("Minigame")]
    //public Transform fragmentoFilho;
    //public Transform jogadorParente;

    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DashAtivado)
        {
            Dash();
        }

        OnMove();

        anima.SetFloat("SideMove", Mathf.Abs(xMove));
        anima.SetFloat("UDMove", yMove);

        distanciaMochila = Vector2.Distance (transform.position, mochila.transform.position);
        distanciaMapa = Vector2.Distance (transform.position, mapa.transform.position);

        if (distanciaMochila < 2)
        {
            mochilaInteracao.SetActive (true);
        }
        else
        {
            mochilaInteracao.SetActive (false);
        }

        if (distanciaMapa < 2)
        {
            mapaInteracao.SetActive (true);
        }
        else
        {
            mapaInteracao.SetActive (false);
        }
    }

    private void OnMove()
    {
        rig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * velocidade, Input.GetAxisRaw("Vertical") * velocidade);

        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");

        if (xMove < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "area ataque")
        {
            DashAtivado = true;
            destino = col.transform.position;
            destinoCam = new Vector3(col.transform.position.x, col.transform.position.y, -10);

            CamSeguindo = false;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "area ataque")
        {
            DashAtivado = false;
            CamSeguindo = true;
        }
    }

    private void Dash()
    {
        if (Input.GetMouseButtonDown(0))
        {
            destino = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        transform.position = Vector2.MoveTowards(transform.position, destino, velocidadeDash * Time.deltaTime);
    }
}