using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Paddle _paddle;

    private Vector2 _paddleToBallVector;

    // Start is called before the first frame update
    private void Start()
    {
        _paddleToBallVector = transform.position - _paddle.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 paddlePos = new Vector2(_paddle.transform.position.x, _paddle.transform.position.y);
        transform.position = paddlePos + _paddleToBallVector;
    }
}
