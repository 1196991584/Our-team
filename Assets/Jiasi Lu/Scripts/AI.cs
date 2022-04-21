using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SocialPlatforms;

public class AI : MonoBehaviour
{
    public EnemyState currentState;
    private Animator m_animator;

    public Vector3 originalPos;
    float speed = 2f;
    private float attackTime;

    public float Hp = 100;

    public HUDHp hp;
    public enum EnemyState
    {
        Idle,
        Trace,
        ReturnBack,
        Attack,
        Death
    }
    private void Awake()
    {
        originalPos = this.transform.position;
    }
    private void Start()
    {
        m_animator = GetComponent<Animator>();
       
        this.GetComponent<NavMeshAgent>().isStopped = true;

    }

    public void Attack()
    {
        if (currentState == EnemyState.Attack)
        {
            m_animator.SetTrigger("Attack");
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        if (currentState == EnemyState.Death)
            return;

        hp.SetHp(Hp);
        if (Hp <= 0 && currentState != EnemyState.Death) {
            m_animator.SetTrigger("Death");
            PlayerStatusInfo.Instance.enemyNum--;
             currentState = EnemyState.Death;
            return;
        }

        if (currentState == EnemyState.ReturnBack && Mathf.Abs(this.GetComponent<NavMeshAgent>().remainingDistance) < 0.1)
        {
            currentState = EnemyState.Idle;
            m_animator.Play("Idle");
            m_animator.SetBool("Walk", false);
            m_animator.Update(0);
            this.GetComponent<NavMeshAgent>().isStopped = true;
            return;
        }
        if (!GameObject.Find("Player")){
            return;
        }
        var pos = GameObject.Find("Player").transform.position;
        var dis = Vector3.Distance(this.transform.position, pos);
        if (dis > 12)
        {
            currentState = EnemyState.ReturnBack;
            this.GetComponent<NavMeshAgent>().SetDestination(originalPos);

            this.GetComponent<NavMeshAgent>().isStopped = false;
            m_animator.SetTrigger("Walk");

        }
        else if (dis <12 && dis > 3)
        {
            currentState = EnemyState.Trace;
            this.GetComponent<NavMeshAgent>().destination = pos;
            this.GetComponent<NavMeshAgent>().isStopped = false;
            m_animator.SetTrigger("Walk");

        }
        else if (dis <= 3)
        {
            this.GetComponent<NavMeshAgent>().isStopped = true;
            currentState = EnemyState.Attack;
            attackTime += Time.deltaTime;
            
            m_animator.SetBool("Walk", false);
            Animator ani = gameObject.GetComponent<Animator>();
            //获取当前动画所在的层
            AnimatorStateInfo animatorStateInfo = ani.GetCurrentAnimatorStateInfo(0);
            if (attackTime > 1f)
            {
                GameObject.Find("Player").GetComponent<PlayerStatusInfo>().HP -= 20;
                attackTime = 0;
                m_animator.SetTrigger("Attack");
            }
        }
    }


    internal void speedOver()
    {
        this.GetComponent<NavMeshAgent>().speed = 1;
        Invoke("speedRe", 2f);
    }
    void speedRe()
    {
        speedOver();
    }
   
    
}
