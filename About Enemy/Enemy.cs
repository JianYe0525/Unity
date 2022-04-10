using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Animator anim;

    protected virtual void Start() //其他脚本也可以调用
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

    public void Death() //死亡动画效果
    {
        anim.SetTrigger("isDeath");
    }

    public void JumpOnDestory()
    {
        Destroy(gameObject);
    }
}
