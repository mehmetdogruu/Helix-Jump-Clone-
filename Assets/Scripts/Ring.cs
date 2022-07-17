using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager gm;
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (transform.position.y+10>=ball.position.y)
        {
            Destroy(gameObject);
            gm.GameScore(25);
        }
    }
}
