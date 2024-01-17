using UnityEngine;
using UnityEngine.UI;

public class Gamesetting : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerscoretext;
    public Text computerscoretext;


    private int _playerScore;

    private int _computerScore;


    public void PlayerScores()
    {
        _playerScore++;
        this.playerscoretext.text = _playerScore.ToString();
        Resetround();
    }

    public void computerScores()
    {
        _computerScore++;
        this.computerscoretext.text = _computerScore.ToString();
        Resetround();
    }

    private void Resetround()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.Resetposition();
        this.ball.AddStartingForce();
    }




}
