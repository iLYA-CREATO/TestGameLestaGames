using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public CharacterMove characterMove;

    public Animator animatorPlayer;
    public void Update()
    {
        if(characterMove.playerState == PlayerState.idle)
        {
            animatorPlayer.Play("idle");
        }

        if (characterMove.playerState == PlayerState.move)
        {
            animatorPlayer.Play("move");
        }
    }
}
