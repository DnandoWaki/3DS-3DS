using UnityEngine;

public class Updater : MonoBehaviour
{
    [Range(0f, 180f)][SerializeField] float atrasAngle = 65f;
    [Range(0f, 180f)][SerializeField] float LadAngle = 155f;
    [SerializeField] Transform mainTransform;
    [SerializeField] Animator animador;
    [SerializeField] SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void LateUpdater()
    {
        Vector3 camforwardVector = new Vector3(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);
        Debug.DrawRay(Camera.main.transform.position, camforwardVector * 5f, Color.magenta);
        float signedAngle = Vector3.SignedAngle(mainTransform.forward, camforwardVector, Vector3.up);
        Vector2 animationDirection = new Vector2(0f, -1f);
        float angle = Mathf.Abs(signedAngle);
        if (angle < atrasAngle)
        {
            animationDirection = new Vector2(0f, -1f);
        }
        else if (angle < LadAngle)
        {
            if (signedAngle < 0)
            {
                animationDirection = new Vector2(-1f, 0f);
            }
            else
            {
                animationDirection = new Vector2(1f, 0f);
            }
        }
        else
        {
            animationDirection = new Vector2(0f, 1f);
        }
        animador.SetFloat("moveX", animationDirection.x);
        animador.SetFloat("moveY", animationDirection.y);
    }
}
