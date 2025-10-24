using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador2D_Terra : MonoBehaviour
{
    private Rigidbody2D rig;
    private Camera visaoAtaque;

    public bool CamSeguindo = true;
    public Vector3 destinoCam;

    [Header ("CasaMorgan")]
    public GameObject mochila, mochilaInteracao;
    public GameObject mapa, mapaInteracao;
    public float distanciaMochila, distanciaMapa;

    public GameObject rampa;

    [Header("Movimento")]
    [SerializeField] int velocidade;
    [SerializeField] float velocidadeDash, pulo;
    [SerializeField] Vector2 destino;
    [SerializeField] Vector2 move;
    [SerializeField] bool DashAtivado = false;

    public string nomeCena;

    [Header("Animação")]
    Animator anima;
    float xMove, yMove;

    void Start()
    {
        anima = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();

        nomeCena = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        if (DashAtivado)
        {
            Dash();
        }

        if (nomeCena == "MorganHouse")
        {
            InteracaoFerramentas();
        }

        OnMove();

        anima.SetFloat("SideMove", Mathf.Abs(xMove));
        anima.SetFloat("UDMove", yMove);
    }
    
    void InteracaoFerramentas()
    {
        distanciaMochila = Vector2.Distance(transform.position, mochila.transform.position);
        distanciaMapa = Vector2.Distance(transform.position, mapa.transform.position);

        if (distanciaMochila < 2)
        {
            mochilaInteracao.SetActive(true);
        }
        else
        {
            mochilaInteracao.SetActive(false);
        }

        if (distanciaMapa < 2)
        {
            mapaInteracao.SetActive(true);
        }
        else
        {
            mapaInteracao.SetActive(false);
        }
    }

    void OnMove()
    {
        rig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * velocidade, rig.velocity.y);
        xMove = Input.GetAxisRaw("Horizontal");

        if (xMove < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
    }

    //REPAGINAR ISSO AQUI
    /*void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "area ataque")
        {
            DashAtivado = true;
            destino = col.transform.position;
            destinoCam = new Vector3(col.transform.position.x, col.transform.position.y, -10);

            CamSeguindo = false;
        }
    

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "area ataque")
        {
            DashAtivado = false;
            CamSeguindo = true;
        }
    }*/

    void OnColliderEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "chao")
        {
            rampa.SetActive(false);
            Debug.Log ("Rampa cade");
        }
    }

    void Dash()
    {
        if (Input.GetMouseButtonDown(0))
        {
            destino = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        transform.position = Vector2.MoveTowards(transform.position, destino, velocidadeDash * Time.deltaTime);
    }
}