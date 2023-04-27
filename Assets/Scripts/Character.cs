using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
	public string name;
	public int exp = 0;

	public Character()
	{
		name = "���ݒ�";
	}
	public Character(string name)
	{
		this.name = name;
	}

	public virtual void PrintStatsInfo()
	{
		UnityEngine.Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
	}

	private void Reset()
	{
		this.name = "���ݒ�";
		this.exp = 0;
	}
}// C#�ł̓Z�~�R�����s�v.

public class Paladin : Character
{
	public Weapon weapon;

	public Paladin(string name, Weapon weapon) : base(name)
	{
		this.weapon = weapon;
	}

	public override void PrintStatsInfo()
	{
		UnityEngine.Debug.LogFormat("�����ς� {0} - ����{1}���f����I", name, weapon.name);
	}
}

// �\���̂̒�`.
public struct Weapon
{
	public string name;
	public int damage;

/*
	// �\���̂ł̓p�����[�^�̂Ȃ��R���X�g���N�^�i�f�t�H���g�R���X�g���N�^�j�͒�`�o���Ȃ�.
	public Weapon()
	{
		name = "���ݒ�";
		damage = 0;
	}
*/
	public Weapon(string name, int damage)
	{
		this.name = name;
		this.damage = damage;
	}
	public void PrintWeaponStats()
	{
		UnityEngine.Debug.LogFormat("Weapon: {0} - {1} DMB", name, damage);
	}
}// C#�ł̓Z�~�R�����s�v.

/*
public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/