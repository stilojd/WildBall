using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    private Animator anim;
    private AnimationClip[] clips;
    private int index;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        clips = anim.runtimeAnimatorController.animationClips;
    }

    public void PlayRandomClip()
    {
        index = Random.Range(0, clips.Length);
        anim.SetInteger("index", index);
    }
}
