var animator : Animator;
var soundeffect : AudioClip;
 
function Start () {
    animator.enabled = false;
}
 
function OnTriggerEnter () {
    AudioSource.PlayClipAtPoint(soundeffect, transform.position);
    animator.enabled = true;
    Destroy(gameObject);
}