using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Paddle _paddle;
    [SerializeField] private float _xPush = 2f;
    [SerializeField] private float _yPush = 15f;

    private Vector2 _paddleToBallVector;
    private bool _hasStarted = false;

    // Start is called before the first frame update
    private void Start()
    {
        _paddleToBallVector = transform.position - _paddle.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!_hasStarted)
        {
            LockBallToPaddle();
            LaunchBallOnMouseClick();
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(_paddle.transform.position.x, _paddle.transform.position.y);
        transform.position = paddlePos + _paddleToBallVector;
    }

    private void LaunchBallOnMouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(_xPush, _yPush);
            _hasStarted = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_hasStarted)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
