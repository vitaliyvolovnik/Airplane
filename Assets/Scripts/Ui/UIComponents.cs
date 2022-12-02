using TMPro;
using UnityEngine;

public class UIComponents : MonoBehaviour
{

    [SerializeField] private TMP_Text _text;
    [SerializeField] private Rigidbody _rigidbody;
    

    private void Update()
    {
        _text.text = Time.time.ToString("0.0");
    }
    public void DoJump(float jumpForce)
    {
        _rigidbody.velocity = Vector3.up * jumpForce;
    }
    public void PlaySound(AudioSource jumpSound)
    {
        jumpSound.Play();
    }

}
